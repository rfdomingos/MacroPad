using System;
using System.Collections.Generic;
using System.Linq;
using RSoft.MacroPad.BLL.Infrasturture.Model;
using RSoft.MacroPad.BLL.Infrasturture.Protocol.Mappers;

namespace RSoft.MacroPad.BLL.Infrasturture.Protocol
{
    public class SdInnovationReportComposer : ReportComposerBase, IReportComposer
    {
        private const byte SdReportId = 0x02;
        private readonly byte _buttonCount;

        public SdInnovationReportComposer(byte buttonCount) : base(SdReportId)
        {
            _buttonCount = buttonCount == 15 ? (byte)15 : (byte)3;
        }

        public IEnumerable<Report> Key(InputAction action, byte layerNo, ushort delay, IEnumerable<(KeyCode Key, Modifier Modifiers)> sequence)
        {
            if (layerNo > 1)
                throw new NotSupportedException("SDINNOVATION devices currently support only one layer in MacroPad.");
            var strokes = sequence?.ToArray() ?? new[] { (KeyCode.None, Modifier.None) };
            if (strokes.Length != 1)
                throw new NotSupportedException("SDINNOVATION devices currently support only one keyboard key per control.");

            var address = MapAddress(action);
            return new[]
            {
                CreatePrepare(address),
                CreateWriteKeyboard(address, strokes[0].Key, strokes[0].Modifiers)
            };
        }

        public IEnumerable<Report> Media(InputAction action, byte layerNo, MediaKey key)
        {
            if (layerNo > 1)
                throw new NotSupportedException("SDINNOVATION devices currently support only one layer in MacroPad.");

            var address = MapAddress(action);
            return new[]
            {
                CreatePrepare(address),
                CreateWriteConsumer(address, key.B1(3), key.B2(3))
            };
        }

        public IEnumerable<Report> Mouse(InputAction action, byte layerNo, MouseButton func, Modifier modifiers)
        {
            if (layerNo > 1)
                throw new NotSupportedException("SDINNOVATION devices currently support only one layer in MacroPad.");
            if (modifiers != Modifier.None)
                throw new NotSupportedException("SDINNOVATION mouse modifiers are not supported yet.");
            if (func.Scroll() != 0)
                throw new NotSupportedException("SDINNOVATION mouse wheel programming is not supported yet.");

            var address = MapAddress(action);
            return new[]
            {
                CreatePrepareSpecial(address),
                CreateWriteMouse(address, func.Button())
            };
        }

        public IEnumerable<Report> System(InputAction action, byte layerNo, SystemKey key)
        {
            if (layerNo > 1)
                throw new NotSupportedException("SDINNOVATION devices currently support only one layer in MacroPad.");

            var address = MapAddress(action);
            return new[]
            {
                CreatePrepareSpecial(address),
                CreateWriteSystem(address, (byte)key)
            };
        }

        public IEnumerable<Report> Led(byte layerNo, LedMode mode, LedColor color)
        {
            throw new NotSupportedException("SDINNOVATION LED programming is not supported yet.");
        }

        private byte MapAddress(InputAction action)
        {
            var slot = MapSlot(action);
            return (byte)((slot - 1) * 3);
        }

        private byte MapSlot(InputAction action)
        {
            var rawAction = (byte)action;
            if (rawAction >= (byte)InputAction.Key1 && rawAction <= (byte)InputAction.Key15)
                return rawAction;

            if (rawAction >= (byte)InputAction.Knob1Left)
            {
                var knobOffset = rawAction - (byte)InputAction.Knob1Left;
                var knobIndex = knobOffset / 3;
                var knobPart = knobOffset % 3;
                var partSlotOffset = knobPart == 1 ? 0 : knobPart == 0 ? 1 : 2;
                return (byte)(_buttonCount + (knobIndex * 3) + partSlotOffset + 1);
            }

            throw new NotSupportedException($"SDINNOVATION action {action} is not supported.");
        }

        private static Report CreatePrepare(byte address)
        {
            return Create(0x82, 0x00, 0x04, 0x00, address);
        }

        private static Report CreatePrepareSpecial(byte address)
        {
            return Create(0x84, 0x00, 0x04, 0x00, address);
        }

        private static Report CreateWriteKeyboard(byte address, KeyCode key, Modifier modifiers)
        {
            return Create(0x02, (byte)modifiers, (byte)key, 0x00, address);
        }

        private static Report CreateWriteConsumer(byte address, byte usageLow, byte usageHigh)
        {
            return Create(0x03, usageLow, usageHigh, 0x00, address);
        }

        private static Report CreateWriteMouse(byte address, byte usage)
        {
            return Create(0x00, usage, 0x00, 0x00, address);
        }

        private static Report CreateWriteSystem(byte address, byte usage)
        {
            return Create(0x01, usage, 0x00, 0x00, address);
        }

        private static Report Create(byte command, byte p1, byte p2, byte p3, byte address)
        {
            var report = new Report32(SdReportId);
            report.Data[0] = command;
            report.Data[1] = p1;
            report.Data[2] = p2;
            report.Data[3] = p3;
            report.Data[4] = address;
            report.Data[5] = 0x00;
            report.Data[6] = 0x03;
            return report;
        }

        private class Report32 : Report
        {
            public Report32(byte reportId)
            {
                ReportId = reportId;
                Data = new byte[31];
            }
        }
    }
}

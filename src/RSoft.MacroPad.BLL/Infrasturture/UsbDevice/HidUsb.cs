using System;
using HID;
using RSoft.MacroPad.BLL.Infrasturture.Model;
using RSoft.MacroPad.BLL.Infrasturture.Protocol;

namespace RSoft.MacroPad.BLL.Infrasturture.UsbDevice
{
    public class HidUsb : UsbBase
    {
        Hid _hid = new Hid();
        IntPtr _hidPtr;

        public override bool Write(Report report)
        {
            return _hid.Write(new report(report.ReportId, report.Data)) == Hid.HID_RETURN.SUCCESS;
        }

        protected override bool CheckIfConnectedInternal()
        {
            return IsConnected = _hid.Opened;
        }

        protected override bool ConnectInternal()
        {
            foreach (var dev in SupportedDevices)
            {
                if ((int)(_hidPtr = _hid.OpenDevice(dev.VendorId, dev.ProductId)) != -1)
                {
                    VendorId = dev.VendorId;
                    ProductId = dev.ProductId;

                    ProtocolType = dev.protocolType;

                    Connected();
                    return IsConnected = true;
                }
            }

            // Add new device descriptors
            var newDevices = new (ushort VendorId, ushort ProductId, string PathFragment, ProtocolType ProtocolType)[]
            {
                (28027, 56506, "mi_00", RSoft.MacroPad.BLL.Infrasturture.Model.ProtocolType.Extended), // SIDE-KEYBOARD
                (28027, 56507, "mi_00", RSoft.MacroPad.BLL.Infrasturture.Model.ProtocolType.Extended)  // SIDE-KEYBOARD
            };

            foreach (var newDevice in newDevices)
            {
                if ((int)(_hidPtr = _hid.OpenDevice(newDevice.VendorId, newDevice.ProductId)) != -1)
                {
                    VendorId = newDevice.VendorId;
                    ProductId = newDevice.ProductId;

                    ProtocolType = newDevice.ProtocolType;

                    Connected();
                    return IsConnected = true;
                }
            }

            return IsConnected = false;
        }
    }
}

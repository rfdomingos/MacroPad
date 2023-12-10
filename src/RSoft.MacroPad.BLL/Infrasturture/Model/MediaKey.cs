namespace RSoft.MacroPad.BLL.Infrasturture.Model
{
    public enum MediaKey : ushort
    {
        [MediaValue(0, 64, 0)]
        [MediaValue(2, 0, 4)]
        [MediaValue(3, 205, 0)]
        [VirtualKeyMap(VirtualKey.MediaPlayPause)]PlayPause,

        [MediaValue(0, 0, 1)]
        [MediaValue(2, 0, 10)]
        [MediaValue(3, 181, 0)]
        [VirtualKeyMap(VirtualKey.MediaNextTrack)]NextTrack,

        [MediaValue(0, 128, 0)]
        [MediaValue(2, 0, 11)]
        [MediaValue(3, 182, 0)]
        [VirtualKeyMap(VirtualKey.MediaPreviousTrack)]PrevTrack,

        [MediaValue(0, 4, 0)]
        [MediaValue(2, 0, 1)]
        [MediaValue(3, 226, 0)]
        [VirtualKeyMap(VirtualKey.VolumeMute)]VolMute,

        [MediaValue(0, 2, 0)]
        [MediaValue(2, 64, 0)]
        [MediaValue(3, 233, 0)]
        [VirtualKeyMap(VirtualKey.VolumeUp)]VolUp,

        [MediaValue(0, 1, 0)]
        [MediaValue(2, 128, 0)]
        [MediaValue(3, 234, 0)]
        [VirtualKeyMap(VirtualKey.VolumeDown)]VolDn,

        [MediaValue(3, 0x83, 0x01)]
        [VirtualKeyMap(VirtualKey.SelectMedia)]MediaPlayer,

        [MediaValue(3, 0x92, 0x01)]
        [VirtualKeyMap(VirtualKey.LaunchApplication2)]Calculator,

        [MediaValue(3, 0x94, 0x01)]
        [VirtualKeyMap(VirtualKey.LaunchApplication1)]LocalComputer,

        [MediaValue(3, 0x23, 0x02)]
        [VirtualKeyMap(VirtualKey.BrowserHome)]Homepage,

        [MediaValue(3, 0x8A, 0x01)]
        [VirtualKeyMap(VirtualKey.LaunchMail)]Email,

        [MediaValue(3, 0x21, 0x02)]
        [VirtualKeyMap(VirtualKey.BrowserSearch)]Search
    }
}

namespace RSoft.MacroPad.BLL.Infrasturture.Model
{
    public enum MouseButton
    {
        [MouseValues(1,0)]
        Left,

        [MouseValues(4, 0)]
        Middle,

        [MouseValues(2, 0)]
        Right,

        [MouseValues(8, 0)]
        Back,

        [MouseValues(16, 0)]
        Forward,

        [MouseValues(0, 1)]
        ScrollUp,

        [MouseValues(0, 255)]
        ScrollDown
    }
}

namespace WinFormsSkPlayGround.Views;

[Flags]
public enum HourMarksStyle
{
    Undefined = 0b000,
    ArabicNumerals = 0b001,
    RomanNumerals = 0b010,
    BinaryNumerals = 0b011,
    TurningClockFace = 0b1_00000000
}

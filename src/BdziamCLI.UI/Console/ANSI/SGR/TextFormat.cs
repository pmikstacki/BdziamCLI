using System.Text;

public struct TextFormat 
{
    public const string ResetAll = "0m";
    public static ResetableControlSequence Bold { get; } = new ResetableControlSequence(1, 22);
    public static ResetableControlSequence Dim { get; } = new ResetableControlSequence(2, 22);
    public static ResetableControlSequence Italic { get; } = new ResetableControlSequence(3, 23);
    public static ResetableControlSequence Underline { get; } = new ResetableControlSequence(4, 24);
    public static ResetableControlSequence Blinking { get; } = new ResetableControlSequence(5, 25);
    public static ResetableControlSequence Reverse { get; } = new ResetableControlSequence(7, 27);
    public static ResetableControlSequence Hidden { get; } = new ResetableControlSequence(8, 28);
    public static ResetableControlSequence Striketrough { get; } = new ResetableControlSequence(9, 29);
}

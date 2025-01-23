using LinkDotNet.StringBuilder;

public struct BasicColor
{
    public static readonly ColorCode Black = new ColorCode(30, 40);
    public static readonly ColorCode Red = new ColorCode(31, 41);
    public static readonly ColorCode Green = new ColorCode(32, 42);
    public static readonly ColorCode Yellow = new ColorCode(33, 43);
    public static readonly ColorCode Blue = new ColorCode(34, 44);
    public static readonly ColorCode Magenta = new ColorCode(35, 45);
    public static readonly ColorCode Cyan = new ColorCode(36, 46);
    public static readonly ColorCode White = new ColorCode(37, 47);
    public static readonly ColorCode Default = new ColorCode(39, 49);
    public static readonly ColorCode BrightBlack = new ColorCode(90, 100);
    public static readonly ColorCode BrightRed = new ColorCode(91, 101);
    public static readonly ColorCode BrightGreen = new ColorCode(92, 102);
    public static readonly ColorCode BrightYellow = new ColorCode(93, 103);
    public static readonly ColorCode BrightBlue = new ColorCode(94, 104);
    public static readonly ColorCode BrightMagenta = new ColorCode(95, 105);
    public static readonly ColorCode BrightCyan = new ColorCode(96, 106);
    public static readonly ColorCode BrightWhite = new ColorCode(97, 107);
}

public struct ColorCode(int foreground, int background)
{
    public readonly int Foreground { get; } = foreground;
    public readonly int Background { get; } = background;
}
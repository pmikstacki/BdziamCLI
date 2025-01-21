using System.Runtime.CompilerServices;

/// <summary>
/// Provides ANSI control code for console manipulation.
/// </summary>
public struct ControlCode
{
    /// <summary>
    /// The escape character (ESC), represented by the ASCII value 27.
    /// </summary>
    public const char ESC = '\u001B';

    /// <summary>
    /// The control sequence introducer ESC[.
    /// </summary>
    public const string CSI = "\u001B\u005B";
}

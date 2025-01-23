/// <summary>
/// Represents ANSI control codes used for terminal cursor and display manipulation.
/// </summary>
public struct FinalSeqToken
{
    /// <summary>
    /// Select Graphic Rendition (SGR).
    /// CSI n m - Sets colors and style of the characters following this code.
    /// </summary>
    public const char SGR = 'm';

    /// <summary>
    /// Cursor Up (CUU).
    /// CSI n A - Moves the cursor n (default 1) cells up. If the cursor is already at the edge of the screen, this has no effect.
    /// </summary>
    public const char CursorUp = 'A';

    /// <summary>
    /// Cursor Down (CUD).
    /// CSI n B - Moves the cursor n (default 1) cells down.
    /// </summary>
    public const char CursorDown = 'B';

    /// <summary>
    /// Cursor Forward (CUF).
    /// CSI n C - Moves the cursor n (default 1) cells forward.
    /// </summary>
    public const char CursorForward = 'C';

    /// <summary>
    /// Cursor Back (CUB).
    /// CSI n D - Moves the cursor n (default 1) cells back.
    /// </summary>
    public const char CursorBack = 'D';

    /// <summary>
    /// Cursor Next Line (CNL).
    /// CSI n E - Moves cursor to beginning of the line n (default 1) lines down. (not ANSI.SYS)
    /// </summary>
    public const char CursorNextLine = 'E';

    /// <summary>
    /// Cursor Previous Line (CPL).
    /// CSI n F - Moves cursor to beginning of the line n (default 1) lines up. (not ANSI.SYS)
    /// </summary>
    public const char CursorPreviousLine = 'F';

    /// <summary>
    /// Cursor Horizontal Absolute (CHA).
    /// CSI n G - Moves the cursor to column n (default 1). (not ANSI.SYS)
    /// </summary>
    public const char CursorHorizontalAbsolute = 'G';

    /// <summary>
    /// Cursor Position (CUP).
    /// CSI n ; m H - Moves the cursor to row n, column m. The values are 1-based, and default to 1 (top left corner) if omitted.
    /// A sequence such as CSI ;5H is a synonym for CSI 1;5H as well as CSI 17;H is the same as CSI 17H and CSI 17;1H.
    /// </summary>
    public const char CursorPosition = 'H';

    /// <summary>
    /// Erase in Display (ED).
    /// CSI n J - Clears part of the screen. If n is 0 (or missing), clear from cursor to end of screen. If n is 1, clear from cursor to beginning of the screen.
    /// If n is 2, clear entire screen (and moves cursor to upper left on DOS ANSI.SYS). If n is 3, clear entire screen and delete all lines saved in the scrollback buffer (this feature was added for xterm and is supported by other terminal applications).
    /// </summary>
    public const char EraseInDisplay = 'J';

    /// <summary>
    /// Erase in Line (EL).
    /// CSI n K - Erases part of the line. If n is 0 (or missing), clear from cursor to the end of the line. If n is 1, clear from cursor to beginning of the line.
    /// If n is 2, clear entire line. Cursor position does not change.
    /// </summary>
    public const char EraseInLine = 'K';

    /// <summary>
    /// Scroll Up (SU).
    /// CSI n S - Scroll whole page up by n (default 1) lines. New lines are added at the bottom. (not ANSI.SYS)
    /// </summary>
    public const char ScrollUp = 'S';

    /// <summary>
    /// Scroll Down (SD).
    /// CSI n T - Scroll whole page down by n (default 1) lines. New lines are added at the top. (not ANSI.SYS)
    /// </summary>
    public const char ScrollDown = 'T';

    /// <summary>
    /// Horizontal Vertical Position (HVP).
    /// CSI n ; m f - Same as CUP, but counts as a format effector function (like CR or LF) rather than an editor function (like CUD or CNL).
    /// This can lead to different handling in certain terminal modes.
    /// </summary>
    public const char HorizontalVerticalPosition = 'f';

    /// <summary>
    /// AUX Port On.
    /// CSI 5i - Enable aux serial port usually for local serial printer.
    /// </summary>
    public const char AuxPort = 'i';

    /// <summary>
    /// Device Status Report (DSR).
    /// CSI 6n - Reports the cursor position (CPR) by transmitting ESC[n;mR, where n is the row and m is the column.
    /// </summary>
    public const char DeviceStatusReport = 'n';
}
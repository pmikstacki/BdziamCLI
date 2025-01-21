public struct StyleCode {
    public const string ResetAll = "0m";
    public static ResetableControlSequence Bold {get;} = new ResetableControlSequence("1m", "22m");
    public static ResetableControlSequence Dim {get;} = new ResetableControlSequence("2m", "22m");
    public static ResetableControlSequence Italic {get;} = new ResetableControlSequence("3m", "23m");
    public static ResetableControlSequence Underline {get;} = new ResetableControlSequence("4m", "24m");
    public static ResetableControlSequence Blinking {get;} = new ResetableControlSequence("5m", "25m");
    public static ResetableControlSequence Reverse {get;} = new ResetableControlSequence("7m", "27m");
    public static ResetableControlSequence Hidden {get;} = new ResetableControlSequence("8m", "28m");
    public static ResetableControlSequence Striketrough {get;} = new ResetableControlSequence("9m", "29m");

    public static 
}

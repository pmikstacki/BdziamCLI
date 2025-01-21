public struct ResetableControlSequence(string init, string reset)
{
    public readonly string Init { get; } = init;
    public readonly string Reset { get; } = reset;
}

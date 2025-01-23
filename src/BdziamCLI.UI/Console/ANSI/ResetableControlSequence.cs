using LinkDotNet.StringBuilder;

public struct ResetableControlSequence(int init, int reset)
{
    public readonly int Init { get; } = init;
    public readonly int Reset { get; } = reset;
    public string Apply(string input) => ValueStringBuilder.Concat(ControlCode.Sequence('m', Init), input, ControlCode.Sequence('m', Reset));
}

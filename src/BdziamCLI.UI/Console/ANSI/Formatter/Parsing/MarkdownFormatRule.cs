using LinkDotNet.StringBuilder;
using Pidgin;
using Pidgin.TokenStreams;
using static Pidgin.Parser<char>;
using static Pidgin.Parser;

public struct MarkdownFormatRule(string token, string startSequence, string endSequence)
{
    public readonly string Token { get; } = token;
    public readonly string StartSequence { get; } = startSequence;
    public readonly string EndSequence { get; } = endSequence;
    public readonly Parser<char, string> RuleParser = CreateParser(token, startSequence, endSequence);
    private static Parser<char, string> CreateParser(string token, string startSequence, string endSequence)
    {
        var tokenCharParsers = token.Select(ct => Char(ct));

        var tokenParser = Sequence(tokenCharParsers);
        var anyParser = Any.Until(tokenParser);
        var wholeContentParser = Any.ManyString();
        var blockParser = anyParser.Between(tokenParser);

        return Map((content) => {
            Console.WriteLine($"Processing {content}") ;
            return ValueStringBuilder.Concat(startSequence, content, endSequence); 
        }, blockParser);
    }
}
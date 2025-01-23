
using System.Collections.Immutable;
using System.Data;
using LinkDotNet.StringBuilder;
using Pidgin;
using static Pidgin.Parser;
using static Pidgin.Parser<char>;  // we'll be parsing strings - sequences of characters. For other applications (eg parsing binary file formats) TToken may be some other type (eg byte).

/// <summary>
/// The core principle of the AnsiFormatter is to parse and replace the special markup with ANSI control codes.
/// for text styling it will support limited subset of markdown syntax.
/// Supported markdown:
/// - Bold (**text**)
/// - Italic (*text*)
/// - Underline (__text__)
/// - Strikethrough (~~text~~)
/// 
/// Color Support:
/// For color we will define a special syntax that will be replaced with ANSI control codes.
/// Each 
/// ;;(b=[color token], f=[color token]) ;;
/// - 
/// </summary>
public struct AnsiFormatter
{
    public static readonly MarkdownFormatRule[] markdownFormatRules = 
    [
        new MarkdownFormatRule("**", ControlCode.Sequence(FinalSeqToken.SGR, TextFormat.Bold.Init), ControlCode.Sequence(FinalSeqToken.SGR, TextFormat.Bold.Reset)),
        new MarkdownFormatRule("*",  ControlCode.Sequence(FinalSeqToken.SGR, TextFormat.Italic.Init), ControlCode.Sequence(FinalSeqToken.SGR, TextFormat.Italic.Reset)),
        new MarkdownFormatRule("~~", ControlCode.Sequence(FinalSeqToken.SGR, TextFormat.Striketrough.Init), ControlCode.Sequence(FinalSeqToken.SGR, TextFormat.Striketrough.Reset)),
        new MarkdownFormatRule("__", ControlCode.Sequence(FinalSeqToken.SGR, TextFormat.Underline.Init), ControlCode.Sequence(FinalSeqToken.SGR, TextFormat.Underline.Reset)),
    ];



    public static string FromMarkdown(string input)
    {
        var inputProcess = input;
        var markdownTokens = OneOf(markdownFormatRules.Select(x => Sequence(x/.Select(t => t.Char(t)))));
        var anyParser = AnyCharExcept(markdownFormatRules.SelectMany(x => x.Token)).ManyString();
        var result = new ValueStringBuilder();

        var markdownContentParser = Map((token, content) => {
            Console.WriteLine($"{token}, {content}");
            return content;
        }
        , markdownTokens, anyParser.Between(markdownTokens).Or(anyParser)).Until(End);

        var finished = false;
        while(!finished)
        {
            var parseResult = markdownContentParser.Parse(inputProcess);
            finished = !parseResult.Success;
            if(!finished)
            {
                foreach(var res in parseResult.GetValueOrDefault())
                {
                    result.Append(res);
                }
                inputProcess = result.ToString();
            }
        }
        Console.WriteLine(inputProcess);
        return inputProcess;
    }



    private static string? GetParserResult(string input, Parser<char, string> parser) => parser.Parse(input).GetValueOrDefault();
    
}
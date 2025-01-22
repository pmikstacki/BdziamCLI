using Pidgin;
using Pidgin.Expression;

Console.WriteLine($"Hello {TextFormat.Underline.Apply(TextFormat.Bold.Apply("World"))}!");

Console.WriteLine($"And now {ControlCode.Sequence('m', BasicColor.Blue.Foreground)}COO{ControlCode.Sequence('m', BasicColor.Cyan.Foreground)}OL{ControlCode.Sequence('m', BasicColor.Magenta.Foreground)}ORS{ControlCode.Sequence('m', BasicColor.Default.Foreground)}"); 
//var markdown = "Markdown!!! **THIS IS BOLD** \n *THIS IS ITALIC* \n  **Bold *Italic Bold*** \n ~~STRIKETROUGH~~ \n __Underline__ \n ~~__STRIKETROUGH UNDERLINE~~__ ";
//Console.WriteLine(AnsiFormatter.FromMarkdown());

var tokenParser = Parser.String("**");
var anyParser = Parser.AnyCharExcept("**").ManyString();
var startBold = ControlCode.Sequence(FinalSeqToken.SGR, TextFormat.Bold.Init);
var endBold = ControlCode.Sequence(FinalSeqToken.SGR, TextFormat.Bold.Reset);

var blockParser = Parser.Try(tokenParser
            .Then(anyParser.Before(tokenParser))    
            .Select(content => startBold + content + endBold));

var resultingParser = Parser.Map((leftAny, block, rightAny) => leftAny + block + rightAny,
    anyParser,
    blockParser,
    anyParser
).ManyString();


var result = resultingParser.Parse("TESTS **TEST BOLD** -TEST AGAIN- *DIFFERENT TEST*");
if(!result.Success)
{
    Console.WriteLine(result.Error.RenderErrorMessage());
}
else{
    Console.WriteLine(string.Join("", result.Value));
}

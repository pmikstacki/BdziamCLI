using Pidgin;
using Pidgin.Expression;
using static Pidgin.Parser;
using static Pidgin.Parser<char>;  // we'll be parsing strings - sequences of characters. For other applications (eg parsing binary file formats) TToken may be some other type (eg byte).
Console.WriteLine($"Hello {TextFormat.Underline.Apply(TextFormat.Bold.Apply("World"))}!");

Console.WriteLine($"And now {ControlCode.Sequence('m', BasicColor.Blue.Foreground)}COO{ControlCode.Sequence('m', BasicColor.Cyan.Foreground)}OL{ControlCode.Sequence('m', BasicColor.Magenta.Foreground)}ORS{ControlCode.Sequence('m', BasicColor.Default.Foreground)}"); 
var markdown = "Markdown!!! **THIS IS BOLD** \n *THIS IS ITALIC* \n  **Bold *Italic Bold*** \n ~~STRIKETROUGH~~ \n __Underline__ \n ~~__STRIKETROUGH UNDERLINE~~__ ";


AnsiFormatter.FromMarkdown("**this**");

//AnsiFormatter.FromMarkdown(markdown);

//var anyToken = OneOf(AnsiFormatter.markdownFormatRules.Select(x => String(x.Token))).ManyString();
//var anyNonMarkdownParser = Any.Until(anyToken);
//Console.WriteLine(anyNonMarkdownParser.Parse(markdown).GetValueOrDefault());
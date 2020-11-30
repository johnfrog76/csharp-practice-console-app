using System;
using System.Collections.Generic;

namespace CSharpFundamentals {
    class TruncateSomeStrings : MenuItem {
        public override string Title => "Truncate summary text from long strings";
        public override string Instructions => "class and method to truncate texts";

        public override bool Execute() {

            static string SummarizeText(string sentense, int maxLength = 20)
            {

                if (sentense.Length < maxLength)
                {
                    return sentense;
                }

                var words = sentense.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);
                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                        break;
                }

                return String.Join(" ", summaryWords) + " ...";
            }

            var longStr = "This is a really really long lorem ipsum dolor sit " +
                "amet string that should really be truncated.";

            var loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "In egestas est quis velit auctor, sed hendrerit ipsum porta. Aenean " +
                "suscipit et eros sed viverra. Vestibulum eu nunc at lectus sagittis " +
                "tempus id at nulla. Quisque eget nisl lorem. Fusce lorem tortor, " +
                "mattis et pharetra vel, congue sit amet quam. Nulla facilisi. " +
                "Donec hendrerit, nulla id scelerisque facilisis, justo nulla " +
                "consequat leo, at euismod eros dolor vel leo.";

            var sentense = longStr;

            Messages.Instruction(Instructions);

            // class
            var smartTruncate = new SmartTruncate();
            Console.WriteLine(smartTruncate.Truncate(longStr, 60));
            Console.WriteLine(smartTruncate.Truncate(loremIpsum, 30));

            // method
            Console.WriteLine(SummarizeText(loremIpsum, 120));
            Console.WriteLine(SummarizeText(sentense));
            Console.WriteLine(SummarizeText("wassup short string"));

            MenuApp.SubMenu();

            return true;
        }
    }
}
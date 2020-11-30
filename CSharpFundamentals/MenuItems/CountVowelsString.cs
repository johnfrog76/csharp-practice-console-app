using System;

namespace CSharpFundamentals {
    public class CountVowelsString : MenuItem {
        public override string Title => "Count Vowels in String";
        public override string Instructions => "VowelCounter: type a word with lots of vowels!";

        public override bool Execute() {

            Messages.Instruction( Instructions );

            static int VowelCount(string str)
            {
                var count = 0;
                var low = str.ToLower();
                var len = low.Length;

                for (var i = 0; i < len; i++)
                {
                    if (low[i] == 'a' || low[i] == 'e' || low[i] == 'i' || low[i] == 'o' || low[i] == 'u')
                    {
                        count++;
                    }
                }

                return count;
            }

            while (true)
            {
                var input = Console.ReadLine();

                try
                {
                    if (!String.IsNullOrWhiteSpace(input))
                    {
                        var success = String.Format(
                            "Number of vowels in {0} is {1}",
                            input,
                            VowelCount(input)
                        );
                        Messages.Success(success);

                        MenuApp.SubMenu();
                        break;
                    }
                    continue;

                }
                catch (Exception)
                {
                    Messages.Error();
                    continue;
                }
            }
            return true;
        }
    }
}

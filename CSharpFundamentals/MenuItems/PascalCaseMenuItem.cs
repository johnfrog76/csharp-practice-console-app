using System;

namespace CSharpFundamentals
{
    public class PascalCaseMenuItem : RepeatingStatelessMenuItem
    {
        public override string Title => "PascalCase";
        public override string Instructions => "Enter a sentence to become PascalCased:";

        // LineHandler is original MakePascalCase function with following modifications:
        // * write temp instead of return temp
        // * change str variable name to text
        // * is no longer static -- data held in the class instance
        protected override void LineHandler(string text)
        {
            var arr = text.Split(" ");

            var temp = "";

            for (var i = 0; i < arr.Length; i++)
            {

                for (var c = 0; c < arr[i].Length; c++)
                {

                    string myChar = Convert.ToString(arr[i][c]);

                    if (c == 0)
                    {
                        temp += myChar.ToUpper();
                    }
                    else
                    {
                        temp += myChar.ToLower();
                    }
                }

            }
            Messages.Success( temp );
        }
    }
}
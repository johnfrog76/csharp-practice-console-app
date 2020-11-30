using System;
using System.Text;

namespace CSharpFundamentals {
    class TestStringConsecutiveNumbers : MenuItem {
        public override string Title => "String contains consecutive numbers";
        public override string Instructions => "Please type string of consecutive numbers separated by hyphen";

        public override bool Execute() {

            Messages.Instruction(Instructions);

            while (true)
            {
                var input = Console.ReadLine();

                try
                {
                    if (!String.IsNullOrWhiteSpace(input))
                    {

                        var builder = new StringBuilder(input);
                        var commaStr = builder.Replace('-', ',').ToString();
                        var arr = commaStr.Split(',');
                        var template = "Numbers {0} consecutive";

                        var isConsecutive = true;
                        var notStr = "";


                        for (var i = 0; i < arr.Length; i++)
                        {
                            var curr = Convert.ToInt32(arr[i]);
                            if (i + 1 < arr.Length)
                            {
                                var next = Convert.ToInt32(arr[i + 1]);
                                var diff = curr - next;
                                diff = diff < 0 ? diff * -1 : diff;

                                if (diff != 1)
                                {
                                    isConsecutive = false;
                                    break;
                                }
                            }
                        }

                        notStr = isConsecutive ? "are" : "not";

                        Messages.Success(String.Format(template, notStr));
                        MenuApp.SubMenu();
                        break;
                    }
                    break;

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
using System;

namespace CSharpFundamentals {
    public class EnterValidTimeFormat : MenuItem {
        public override string Title => "String parse 24 hour format";
        public override string Instructions => "Enter a time valid value in 24hr format";

        public override bool Execute()
        {
            Messages.Instruction( Instructions );

            while (true)
            {
                var input = Console.ReadLine();

                try
                {
                    if (!String.IsNullOrWhiteSpace(input))
                    {
                        try
                        {
                            var myDate = DateTime.Parse(input);
                            Console.WriteLine(myDate);

                            MenuApp.SubMenu();
                            break;

                        }
                        catch (FormatException)
                        {
                            Messages.Error("Invalid time string!");
                        }
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

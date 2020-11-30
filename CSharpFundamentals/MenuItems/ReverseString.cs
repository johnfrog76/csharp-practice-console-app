using System;

namespace CSharpFundamentals {
    public class ReverseString : MenuItem {
        public override string Title => "Reverse String";
        public override string Instructions => "Please type your name and press 'enter'";

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

                        var arr = input.ToCharArray();
                        Array.Reverse(arr);
                        var reversedName = new string(arr);
                        var success = String.Format(
                            "your name reversed is '{0}'",
                            reversedName
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

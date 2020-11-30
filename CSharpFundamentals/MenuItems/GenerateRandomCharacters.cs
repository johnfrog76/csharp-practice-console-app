using System;

namespace CSharpFundamentals {
    class GenerateRandomCharacters : MenuItem {
        public override string Title => "Create a random string of characters";
        public override string Instructions => "Enter a number to generate a random string of " +
            "characters of this length";
        public override bool Execute() {

            Messages.Instruction(Instructions);

            var random = new Random();

            while (true) {
                var input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input)) {
                    try
                    {
                        var pwLength = Convert.ToInt16(input);
                        var buffer = new char[pwLength];

                        for (var i = 0; i < pwLength; i++)
                        {
                            buffer[i] = (char)('a' + random.Next(0, 26));
                        }
                        var password = new String(buffer);

                        var success = String.Format("password: {0}", password);
                        Messages.Success(success);

                        MenuApp.SubMenu();
                        break;

                    } catch (Exception) {
                        Messages.Error();
                        continue;
                    }
                }
            }

            return true;
        }
    }
}
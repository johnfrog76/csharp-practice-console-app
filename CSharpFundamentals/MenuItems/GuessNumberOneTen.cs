using System;

namespace CSharpFundamentals {
    class GuessNumberOneTen : MenuItem {
        public override string Title => "Guess a number";
        public override string Instructions => "Guess a number between 1 and 10";

        public override bool Execute() {

            Messages.Instruction(Instructions);

            var random = new Random();
            var num = random.Next(1, 10);
            var counter = 3;


            while (counter >= 0)
            {
                var input = Console.ReadLine();

                if (counter < 2)
                {
                    // provide hint
                    Messages.Success("hint: " + num);
                }

                try
                {
                    if (!String.IsNullOrWhiteSpace(input))
                    {

                        if (num == Convert.ToInt32(input))
                        {
                            var success = String.Format(
                                "Congratulations! The number is {0}",
                                num
                            );
                            Messages.Success(success);
                            break;
                        }
                        else
                        {
                            var plural = counter == 1 ? "guess" : "guesses";
                            var errorMsg = String.Format(
                                "Wrong! {0} {1} left.",
                                counter,
                                plural
                            );
                            Messages.Error(errorMsg);
                        }

                        counter--;
                        continue;
                    }
                    continue;

                }
                catch (Exception)
                {
                    Messages.Error("Please enter valid number.");
                    continue;
                }

            }

            MenuApp.SubMenu();
            return true;
        }
    }
}
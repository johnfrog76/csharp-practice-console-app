using System;

namespace CSharpFundamentals {
    class RunningTotal : MenuItem
    {
        public override string Title => "Calculate Running Total";
        public override string Instructions => "running total: type a number hit 'enter' and repeat. " +
            "Type 'done' and hit enter to exit.";

        public override bool Execute()
        {
            Console.Clear();
            Messages.Warn(Instructions);
            var input = "";
            var result = 0;
            while (true)
            {
                input = Console.ReadLine();
                try
                {
                    if (!String.IsNullOrWhiteSpace(input))
                    {
                        var calculator = new Math.Calculator();

                        if (result == 0)
                        {
                            result = calculator.Add(0, Convert.ToInt32(input));
                        }
                        else
                        {
                            result = calculator.Add(result, Convert.ToInt32(input));
                        }
                        var success = String.Format(
                            "Your running total is: {0}",
                            result
                        );
                        Messages.Success(success);
                        continue;
                    }
                    break;

                }
                catch (Exception)
                {
                    if (input.ToUpper() == "DONE")
                    {
                        Console.WriteLine("done");
                        Console.Clear();
                        MenuApp.SubMenu();
                        break;
                    }
                    else
                    {
                        Messages.Error("Please enter valid number.");
                        continue;
                    }
                }
            }
            return true;
        }

    }
}
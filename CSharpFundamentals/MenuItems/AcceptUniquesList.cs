using System;
using System.Collections.Generic;

namespace CSharpFundamentals {
    class AcceptUniquesList : MenuItem
    {

        public override string Title => "Accept only unique numbers";
        public override string Instructions => "Please add five unique numbers -- between each number hit 'enter'";

        public override bool Execute()
        {

            Messages.Instruction(Instructions);


            var uniques = new List<int>();
            int MAX = 5;

            while (true)
            {
                var input = Console.ReadLine();

                try
                {
                    if (!String.IsNullOrWhiteSpace(input))
                    {

                        if (uniques.Count < MAX && uniques.IndexOf(Convert.ToInt32(input)) == -1)
                        {
                            uniques.Add(Convert.ToInt32(input));
                            if (uniques.Count == MAX)
                            {
                                var str = "";
                                for (var i = 0; i < MAX; i++)
                                {
                                    var isLast = (i + 1 == MAX) ? "" : ",";
                                    str += Convert.ToInt32(uniques[i]) + isLast;
                                }

                                var success = String.Format("I have five uniques: {0}!", str);
                                Messages.Success(success);

                                MenuApp.SubMenu();
                                break;

                            }
                        }
                        else
                        {
                            var message = String.Format(
                                "Sorry, you already have {0}. Try again.",
                                input
                            );
                            Messages.Error(message);
                        }
                        continue;
                    }

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
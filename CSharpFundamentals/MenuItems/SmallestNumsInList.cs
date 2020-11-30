using System;
using System.Collections.Generic;

namespace CSharpFundamentals {

    class SmallestNumsInList : MenuItem {
        public override string Title => "Three smallest numbers in list";
        public override string Instructions => "Supply comma separated list of numbers and " +
                "then press 'enter' to see three smallest numbers";

        public override bool Execute() {

            Messages.Instruction(Instructions);

            while (true)
            {
                var input = Console.ReadLine();

                try
                {
                    if (String.IsNullOrWhiteSpace(input))
                    {
                        Messages.Error("Invalid List");
                    }
                    else
                    {

                        var nums = input.Split(",");
                        if (nums.Length > 6)
                        {
                            Messages.Error("List nums between one and six numbers in length");
                            continue;
                        }
                        var sorted = new List<int>();
                        var min = "";

                        foreach (var foo in nums)
                        {
                            int item = Convert.ToInt32(foo);
                            sorted.Add(item);
                        }

                        sorted.Sort();
                        int[] minArr = sorted.GetRange(0, 3).ToArray();


                        for (var i = 0; i < minArr.Length; i++)
                        {
                            var isLast = (i == minArr.Length - 1) ? "" : ",";
                            min += Convert.ToString(minArr[i]) + isLast;

                        }

                        var success = String.Format("Three smallest numbers: {0}", min);
                        Messages.Success(success);

                        MenuApp.SubMenu();
                        break;
                    }

                }
                catch (Exception)
                {
                    if (input.ToLower() == "quit")
                    {
                        Console.WriteLine("done");
                        break;
                    }
                    else
                    {

                        Messages.Error();
                        continue;
                    }
                }
            }

        return true;
        }
    }
}
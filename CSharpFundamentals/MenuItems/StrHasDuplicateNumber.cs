using System;
using System.Text;
using System.Collections.Generic;

namespace CSharpFundamentals {
    public class StrHasDuplicateNumber : MenuItem {
        public override string Title => "String has duplicate number";
        public override string Instructions => @"Enter numbers separated by '-', and you will receive warning of duplicates.";

        public override bool Execute()
        {
            Messages.Instruction(Instructions);

            while (true)
            {
                var input = Console.ReadLine();

                try
                {
                    if (!String.IsNullOrWhiteSpace(input))
                    {
                        var builder = new StringBuilder(input);
                        var processed = builder.Replace('-', ',').ToString();

                        var arr = processed.Split(',');

                        static bool HasDuplicateNumber(string[] arr)
                        {
                            var nums = new List<int>();
                            var hasDup = true;

                            for (var i = 0; i < arr.Length; i++)
                            {
                                var myNum = Convert.ToInt32(arr[i]);

                                if (!nums.Contains(myNum))
                                {
                                    nums.Add(myNum);
                                    hasDup = false;
                                }
                                else
                                {
                                    // match
                                    hasDup = true;
                                    break;
                                }

                            }

                            return hasDup;
                        }

                        if (HasDuplicateNumber(arr))
                        {
                            Messages.Error("Duplicate number!");
                        }
                        else
                        {
                            Messages.Success("No duplicates!");
                        }
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
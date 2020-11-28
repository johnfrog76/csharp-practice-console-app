using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace CSharpFundamentals
{
    public class MenuApp
    {
        public MenuApp(){}

        public static void CallMethod (string method)
        {
            try
            {
                var t = new Program();
                t.GetType()
                    .GetMethod(method)
                    .Invoke(t, null);

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                var errorMessage = String.Format(
                    "Sorry could not find method {0}",
                    method
                );
                Program.WriteErrorMessage(errorMessage);
                Console.ReadKey();
            }
        }

        public static void SubMenu()
        {
            var message = new Messages();


            message.Info("\r\nPress Enter to return to Main Menu");

            var user = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(user))
            {
                MainMenu();
            }
        }

        public static bool MainMenu()
        {
            var message = new Messages();

            var menuItems = new List<MenuItem>();
            menuItems.Add(new MenuItem(
                "Enter valid time string 24 hour format",
                true,
                "EnterValidTimeFormat"
            ));
            menuItems.Add(new MenuItem(
                "Make Pascal Case",
                true,
                "MakePascalCase"
            ));
            menuItems.Add(new MenuItem(
                "String has duplicate number",
                true,
                "StrHasDuplicateNumber"
            ));
            menuItems.Add(new MenuItem(
                "Count vowels in a string",
                true,
                "CountVowelsInString"
            ));
            menuItems.Add(new MenuItem(
                "String contains consecutive numbers",
                true,
                "TestStringConsecutiveNumbers"
            ));
            menuItems.Add(new MenuItem(
                "Reverse string",
                true,
                "ReverseString"
            ));
            menuItems.Add(new MenuItem(
                "Truncate some strings",
                true,
                "TruncateSomeTexts"
            ));
            menuItems.Add(new MenuItem(
                "Some DateTime stuff",
                true,
                "StuffWithDateTime"
            ));
            menuItems.Add(new MenuItem(
                "Calculate running total",
                true,
                "CalculateRunningTotal"
            ));
            menuItems.Add(new MenuItem(
                "Create a random string of characters",
                true,
                "GeneratePass"
            ));
            menuItems.Add(new MenuItem(
                "Guess a number",
                true,
                "GuessNumberOneTen"
            ));
            menuItems.Add(new MenuItem(
                "Who gave likes to post",
                true,
                "ShowLikes"
            ));
            menuItems.Add(new MenuItem(
                "Fancy Header",
                true,
                "MakeFancyHeader"
            ));
            menuItems.Add(new MenuItem(
                "Three smallest numbers in list",
                true,
                "SmallestNumsInList"
            ));
            menuItems.Add(new MenuItem(
                "Accept only unique numbers",
                true,
                "AcceptUniquesList"
            ));
            menuItems.Add(new MenuItem(
                "Exit",
                false,
                "MenuExit"
            ));

            var count = 0;
            var menuTitles = new List<string>();

            foreach (var item in menuItems)
            {
                menuTitles.Add(item.Description);
            }

            var menuArr = menuTitles.ToArray();
            var len = menuArr.Length;
            var maxItemLength = 0;

            for (var i = 0; i < len; i++)
            {
                var template = "{0}) {1}";
                if (i < 10)
                {
                    template = " " + template;
                }
                if (menuArr[i].Length > maxItemLength)
                {
                    maxItemLength = menuArr[i].Length + 5;
                }
                menuArr[i] = String.Format(template, count, menuArr[i]);
                count++;
            }

            Console.Clear();
            var builder = new StringBuilder();
            builder
                .AppendLine("Choose an option:")
                .Append('-', maxItemLength)
                .AppendLine()
                .AppendJoin("\r\n", menuArr)
                .AppendLine()
                .Append('-', maxItemLength);

            message.Info(builder.ToString());

            Console.Write("\r\nSelect an option: ");

            while (true)
            {
                var input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {
                    try
                    {
                        var val = Convert.ToInt16(input);
                        CallMethod(menuItems[val].MethodName);
                        return menuItems[val].ShowsMenu;
                    }
                    catch (Exception)
                    {
                        Program.WriteErrorMessage("Sorry, unable to find this menu item.");
                    }

                }
                continue;
            }
        }
    }
}

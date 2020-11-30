using System;
using System.Text;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    public class MenuApp
    {
        public MenuApp(){}

        // public static void CallMethod (string method)
        // {
        //     try
        //     {
        //         var t = new Program();
        //         t.GetType()
        //             .GetMethod(method)
        //             .Invoke(t, null);

        //     }
        //     catch (Exception ex)
        //     {
        //         //Console.WriteLine("Error: " + ex.Message);
        //         var errorMessage = String.Format(
        //             "Error Message: {0}",
        //
        //         );
        //         Program.WriteErrorMessage(errorMessage);
        //         Console.ReadKey();
        //     }
        // }

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
            menuItems.Add(new EnterValidTimeFormat());
            menuItems.Add(new PascalCaseMenuItem());
            menuItems.Add(new StrHasDuplicateNumber());
            menuItems.Add(new CountVowelsString());
            menuItems.Add(new TestStringConsecutiveNumbers());
            menuItems.Add(new ReverseString());
            menuItems.Add(new TruncateSomeStrings());
            menuItems.Add(new PracticeWithDateTime());
            menuItems.Add(new RunningTotal());
            menuItems.Add(new GenerateRandomCharacters());
            menuItems.Add(new GuessNumberOneTen());
            menuItems.Add(new ShowLikes());
            menuItems.Add(new MakeFancyHeader());
            menuItems.Add(new SmallestNumsInList());
            menuItems.Add(new AcceptUniquesList());
            menuItems.Add( new EchoMenuItem() );
            menuItems.Add( new ExitMenuItem() );

            var count = 0;
            var menuTitles = new List<string>();

            foreach (var item in menuItems)
            {
                menuTitles.Add(item.Title);
            }

            var menuArr = menuTitles.ToArray();
            var len = menuArr.Length ;
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
                        return menuItems[val].Execute();
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

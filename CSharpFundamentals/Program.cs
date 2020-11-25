using System;
using System.Text;
using System.Collections.Generic;
using System.IO;


namespace CSharpFundamentals
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }


    class Program
    {
        static void Main(string[] args)
        {
            //var john = new Person();
            //john.FirstName = "John";
            //john.LastName = "Webster";
            //john.Introduce();

            //var calculator = new Calculator();
            //var result = calculator.Add(1, 2);
            //Console.WriteLine(result);
            //var numbers = new int[3] { 1, 2, 3 };

            //Console.WriteLine(numbers[0]);

            //var flags = new bool[3];
            //flags[0] = true;

            //Console.WriteLine(flags[0]);
            //Console.WriteLine(flags[1]);

            //var firstName = "Mosh";
            //var lastName = "Hamedami";

            //var myFullName = string.Format(
            //    "{0} {1}",
            //    firstName,
            //    lastName
            //);
            //Console.WriteLine(myFullName);

            //var names = new string[3] { "John", "Steve", "Bill" };
            //var formattedNames = string.Join(", ", names);
            //Console.WriteLine(formattedNames);

            //var text = @"Hi John -
            //    Look in c:/root/dir1/dir2
            //    AND in c:/root/dir3/dir4:cool";
            //Console.WriteLine(text);

            //var method = ShippingMethod.Express;
            //Console.WriteLine((int)method);

            //var methodId = 3;
            //Console.WriteLine((ShippingMethod)methodId);
            //Console.WriteLine(ShippingMethod.Express);

            //int hour = 14;

            //if (hour > 0 && hour < 12)
            //{
            //    Console.WriteLine("It's morning");
            //}
            //else if (hour >= 12 && hour < 18)
            //{
            //    Console.WriteLine("It's afternoon");
            //}
            //else
            //{
            //    Console.WriteLine("It's evening");
            //}

            //bool isGoldCustomer = true;

            //float price = isGoldCustomer ? 19.95f : 29.95f;
            //Console.WriteLine(price);

            //var season = Season.Autumn;
            //switch (season)
            //{
            //    case Season.Autumn:
            //        Console.WriteLine("it's fall");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("summer!!!");
            //        break;
            //    case Season.Winter:
            //        Console.WriteLine("winter is cold");
            //        break;
            //    default:
            //        Console.WriteLine("why don't you tell me what season it is");
            //        break;
            //}

            //string val;
            //Console.WriteLine("enter number between 1 and 10: ");
            //val = Console.ReadLine();
            //int a = Convert.ToInt32(val);

            //string isValid = (a > 0 && a < 9) ? "valid" : "error"; 

            //// input, valid

            //string response = String.Format(
            //    "Your input {0} is {1}",
            //    val,
            //    isValid
            //);

            //Console.WriteLine(response);

            //var fullName = "John Smith";

            //for (var i = 0; i < fullName.Length; i++)
            //{
            //    Console.WriteLine(fullName[i]);
            //}
            //foreach (var foo in fullName)
            //{
            //    Console.WriteLine(foo);
            //}
            //string foo;

            //var numbers = new int[] { 1, 2, 3, 4 };

            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //while (true)
            //{
            //    Console.Write("Type your name:");
            //    var input = Console.ReadLine();
            //    if (!String.IsNullOrWhiteSpace(input))
            //    {
            //        Console.WriteLine("@Echo: " + input);
            //        continue;
            //    }
            //    break;

            //}

            static void GeneratePass()
            {
                WriteInstructions("Use 'Random' to generate random characters");


                var random = new Random();
                const int pwLength = 15;
                var buffer = new char[pwLength];

                for (var i = 0; i < pwLength; i++)
                {
                    buffer[i] = (char)('a' + random.Next(0, 26));
                }
                var password = new String(buffer);

                Console.WriteLine("password: {0}", password);

                SubMenu();


            }         


            static void CalculateRunningTotal()
            {
                WriteInstructions(@"running total: type a number hit 'enter' and repeat. Type 'done' and hit enter to exit.");
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
                            Console.WriteLine(result);

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
                            SubMenu();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please enter valid number.");
                            continue;
                        }
                    }
                }
            }


            static void GuessNumberOneTen()
            {
                WriteInstructions("Guess a number between 1 and 10");

                var random = new Random();
                var num = random.Next(1, 10);
                var counter = 3;


                while (counter >= 0)
                {
                    var input = Console.ReadLine();

                    if (counter < 2)
                    {
                        // provide hint
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("hint: " + num);
                        Console.ResetColor();

                    }

                    try
                    {
                        if (!String.IsNullOrWhiteSpace(input))
                        {


                            if (num == Convert.ToInt32(input))
                            {
                                Console.WriteLine("Congratulations! The number is {0}", num);
                                break;
                            }
                            else
                            {
                                var plural = counter == 1 ? "guess" : "guesses";

                                Console.WriteLine("Wrong! {0} {1} left.", counter, plural);
                            }

                            counter--;
                            continue;
                        }
                        continue;

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Please enter valid number.");
                        continue;
                    }

                }

                SubMenu();
            }

            //var str = "5,3,8,1,122,114,0";
            //var arr = str.Split(',');

            //var max = 0;

            //for (var i = 0; i < arr.Length; i++)
            //{
            //    var myNum = Convert.ToInt32(arr[i]);
            //    if (myNum > max)
            //    {
            //        max = myNum;
            //    }
            //}

            //Console.WriteLine("The max number is {0}", max);

            //var entry = 3;
            //var num = entry;
            //var counter = num - 1;

            //while (counter > 0)
            //{
            //    num = num * counter;
            //    counter--;
            //}

            //Console.WriteLine($"{entry}! = {num:n0}", entry, num);



            //var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            //Console.WriteLine(numbers.Length);

            //var numbers = new List<int>() { 1, 2, 3, 4 };
            //numbers.Add(1);
            //numbers.AddRange(new int[3] { 5, 6, 7 });
            //foreach (var foo in numbers)
            //{
            //    Console.WriteLine(foo);
            //}

            //Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            //Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));
            //Console.WriteLine("Count: " + numbers.Count);

            //for (var i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] == 1)
            //    {
            //        numbers.Remove(numbers[i]);
            //    }
            //}

            //foreach (var foo in numbers)
            //{
            //    Console.WriteLine("HI" + foo);
            //}

            //numbers.Clear();

            //Console.WriteLine(numbers.Count);

            static void ShowLikes()
            {
                WriteInstructions("Type a name and hit enter, repeat again to see " +
                    "who gave like this post. Type 'exit' when done.");

                var input = "";
                var likes = new List<string>();
                var numLikes = likes.Count;

                while (true)
                {
                    input = Console.ReadLine();
                    try
                    {
                        if (!String.IsNullOrWhiteSpace(input))
                        {
                            if (input.ToUpper() == "EXIT")
                            {
                                SubMenu();
                                break;
                            }

                            likes.Add(input);
                            numLikes = likes.Count;

                            if (numLikes == 0)
                            {
                                Console.WriteLine("Your post has zero likes");
                            }
                            else if (numLikes == 1)
                            {
                                var friend1 = likes[0];
                                Console.WriteLine("{0} likes your post", friend1);
                            }
                            else if (numLikes == 2)
                            {
                                var friend1 = likes[0];
                                var friend2 = likes[1];
                                Console.WriteLine("{0} and {1} like your post", friend1, friend2);
                            }
                            else if (numLikes > 2)
                            {
                                var friend1 = likes[0];
                                var friend2 = likes[1];
                                Console.WriteLine(
                                    "{0}, {1}, and {2} others like your post",
                                    friend1,
                                    friend2,
                                    (numLikes - 2)
                                );

                            }
                            continue;
                        }
                        break;

                    }
                    catch (Exception)
                    {
                        
                        Console.WriteLine("there was an error.");
                        continue;
                    }

                }

            }

            static void ReverseString()
            {

                WriteInstructions("Please type your name and press 'enter'");

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
                            Console.WriteLine(
                                "your name reversed is '{0}'",
                                reversedName
                            );

                            SubMenu();
                            break;
                        }
                        continue;

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("there was an error");
                        continue;
                    }

                }
            }


            static void AcceptUniquesList()
            {
                WriteInstructions("Please add five unique numbers -- between each number hit 'enter'");


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
                                    Console.WriteLine("I have five uniques: {0}!", str);


                                    SubMenu();
                                    break;
                                    
                                }
                            }
                            else
                            {
                                Console.WriteLine("Sorry, you already have {0}. Try again.", input);
                            }
                            continue;
                        }

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("there was an error");
                        continue;
                    }

                }

            }


            static void SmallestNumsInList()
            {
                WriteInstructions("Supply comma separated list of numbers and " +
                    "then press 'enter' to see three smallest numbers");

                while (true)
                {
                    var input = Console.ReadLine();

                    try
                    {
                        if (String.IsNullOrWhiteSpace(input))
                        {
                            Console.WriteLine("Invalid List");
                        }
                        else
                        {

                            var nums = input.Split(",");
                            if (nums.Length > 6)
                            {
                                Console.WriteLine("List nums between one and six numbers in length");
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

                            Console.WriteLine("Three smallest numbers: {0}", min);
                            

                            SubMenu();
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

                            Console.WriteLine("there was an error");
                            continue;
                        }
                    }
                }
            }

            static void StuffWithDateTime()
            {
                WriteInstructions("DateTime Stuff Here");

                // create
                var dateTime = new DateTime(2015, 1, 1);
                var now = DateTime.Now;
                var today = DateTime.Today;
                var tomorrow = now.AddDays(1);
                var yesterday = now.AddDays(-1);

                Console.WriteLine(now.ToLongDateString());
                Console.WriteLine(now.ToShortDateString());
                Console.WriteLine(now.ToLongTimeString());
                Console.WriteLine(now.ToShortTimeString());
                Console.WriteLine(now.ToString("MM-dd-yyyy HH:mm"));

                var timeSpan = TimeSpan.FromHours(1);
                var start = DateTime.Now;
                var end = DateTime.Now.AddMinutes(2);

                var duration = end - start;
                Console.WriteLine("Duration: " + duration);

                // properties
                Console.WriteLine("minutes: " + timeSpan.Minutes);
                Console.WriteLine("total minutes: " + timeSpan.TotalMinutes);

                // add
                Console.WriteLine("add example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
                Console.WriteLine("subtract example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

                // parse
                Console.WriteLine(DateTime.Parse("23:00"));

                SubMenu();
            }


            static void TruncateSomeTexts()
            {
                static string SummarizeText(string sentense, int maxLength = 20)
                {

                    if (sentense.Length < maxLength)
                    {
                        return sentense;
                    }

                    var words = sentense.Split(' ');
                    var totalCharacters = 0;
                    var summaryWords = new List<string>();

                    foreach (var word in words)
                    {
                        summaryWords.Add(word);
                        totalCharacters += word.Length + 1;
                        if (totalCharacters > maxLength)
                            break;
                    }

                    return String.Join(" ", summaryWords) + " ...";
                }

                var longStr = "This is a really really long lorem ipsum dolor sit " +
                    "amet string that should really be truncated.";

                var loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                    "In egestas est quis velit auctor, sed hendrerit ipsum porta. Aenean " +
                    "suscipit et eros sed viverra. Vestibulum eu nunc at lectus sagittis " +
                    "tempus id at nulla. Quisque eget nisl lorem. Fusce lorem tortor, " +
                    "mattis et pharetra vel, congue sit amet quam. Nulla facilisi. " +
                    "Donec hendrerit, nulla id scelerisque facilisis, justo nulla " +
                    "consequat leo, at euismod eros dolor vel leo.";

                var sentense = longStr;

                WriteInstructions("class and method to truncate texts");

                // these use class
                var smartTruncate = new SmartTruncate();
                Console.WriteLine(smartTruncate.Truncate(longStr, 60));
                Console.WriteLine(smartTruncate.Truncate(loremIpsum, 30));

                // these use method
                Console.WriteLine(SummarizeText(loremIpsum, 120));
                Console.WriteLine(SummarizeText(sentense));
                Console.WriteLine(SummarizeText("wassup short string"));

                SubMenu();

            }


            static void MakeFancyHeader()
            {
                var builder = new StringBuilder();
                builder
                    .Append('-', 10)
                    .AppendLine()
                    .Append("Fancy Heading")
                    .AppendLine()
                    .Append('-', 10);

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(builder);
                Console.ResetColor();
                SubMenu();

            }


            static void TestStringConsecutiveNumbers()
            {
                WriteInstructions("Please type string of consecutive numbers separated by hyphen");

                while (true)
                {
                    var input = Console.ReadLine();

                    try
                    {
                        if (!String.IsNullOrWhiteSpace(input))
                        {

                            var builder = new StringBuilder(input);
                            var commaStr = builder.Replace('-', ',').ToString();
                            var arr = commaStr.Split(',');
                            var template = "Numbers {0} consecutive";

                            var isConsecutive = true;
                            var notStr = "";


                            for (var i = 0; i < arr.Length; i++)
                            {
                                var curr = Convert.ToInt32(arr[i]);
                                if (i + 1 < arr.Length)
                                {
                                    var next = Convert.ToInt32(arr[i + 1]);
                                    var diff = curr - next;
                                    diff = diff < 0 ? diff * -1 : diff;

                                    if (diff != 1)
                                    {
                                        isConsecutive = false;
                                        break;
                                    }
                                }
                            }

                            notStr = isConsecutive ? "are" : "not";

                            Console.WriteLine(template, notStr);
                            SubMenu();
                            break;
                        }
                        break;

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("there was an error");
                        continue;
                    }

                }
            }


            static void StrHasDuplicateNumber ()
            {
                WriteInstructions("Please type string of numbers separated by hyphen");

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
                                Console.WriteLine("Duplicate number!");
                            }
                            SubMenu();
                            break;
                        }
                        continue;

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("there was an error");
                        continue;
                    }

                }
            }

            static void WriteInstructions(string msg="instructions")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine(msg);
                Console.ResetColor();
            }


            static void SubMenu()
            {
                Console.Write("\r\nPress Enter to return to Main Menu");
                var user = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(user))
                {
                    MainMenu();
                }

            }

            static void EnterValidTimeFormat()
            {
                WriteInstructions("Enter a time valid value in 24hr format");

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

                                SubMenu();
                                break;

                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid time!");
                            }
                        }
                        continue;

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("there was an error");
                        continue;
                    }

                }


            }


            static void MakePascalCase()
            {
                static string MakePascalString(string str)
                {
                    var arr = str.Split(" ");

                    var temp = "";

                    for (var i = 0; i < arr.Length; i++)
                    {

                        for (var c = 0; c < arr[i].Length; c++)
                        {

                            string myChar = Convert.ToString(arr[i][c]);

                            if (c == 0)
                            {
                                temp += myChar.ToUpper();

                            }
                            else
                            {
                                temp += myChar.ToLower();
                            }
                        }

                    }
                    return temp;
                }

                WriteInstructions("MakePascalCase: type a few words separated by space");

                while (true)
                {
                    var input = Console.ReadLine();

                    try
                    {
                        if (!String.IsNullOrWhiteSpace(input))
                        {
                            Console.WriteLine(MakePascalString(input));

                            SubMenu();
                            break;

                        }


                    }
                    catch (Exception)
                    {
                        Console.WriteLine("there was an error");
                        continue;
                    }

                }
            }

            static void CountVowelsInString()
            {
                WriteInstructions("VowelCounter: type a word with lots of vowels!");

                static int VowelCount(string str)
                {
                    var count = 0;
                    var low = str.ToLower();
                    var len = low.Length;

                    for (var i = 0; i < len; i++)
                    {
                        if (low[i] == 'a' || low[i] == 'e' || low[i] == 'i' || low[i] == 'o' || low[i] == 'u')
                        {
                            count++;
                        }
                    }

                    return count;
                }

                while (true)
                {
                    var input = Console.ReadLine();

                    try
                    {
                        if (!String.IsNullOrWhiteSpace(input))
                        {
                            Console.WriteLine(
                                "Number of vowels in {0} is {1}",
                                input,
                                VowelCount(input)
                            );

                            SubMenu();
                            break;
                        }
                        continue;

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("there was an error");
                        continue;
                    }

                }

            }



            // use either File (static) or fileInfo (class member)
            //var basePath = @"/Users/jwebster/Desktop/filetest/";
            //var path = basePath + @"one/test.txt";
            //var path2 = basePath + @"two/test.txt";

            //try
            //{
            //    File.Copy(
            //       path,
            //       path2,
            //       true
            //    );
            //} catch (Exception)
            //{
            //    Console.WriteLine("file copy failed");
            //}

            //if (File.Exists(path2))
            //{
            //    Console.WriteLine("exists");
            //    File.Delete(path2);

            //    if (!File.Exists(path2))
            //    {
            //        Console.WriteLine("deleted file");
            //    }
            //}

            //var path3 = basePath + @"three/";
            //var files = new string[3] { "test2.txt", "test3.txt", "test4.txt" };
            //Directory.CreateDirectory(path3);

            //foreach (var file in files)
            //{
            //    File.Create(path3 + file);
            //}

            //var readFiles = Directory.GetFiles(path3, "*.*");

            //foreach (var foo in readFiles)
            //{
            //    Console.WriteLine(foo);
            //}

            //var myFileContents = File.ReadAllText(path3 + "test3.txt");
            //Console.WriteLine(myFileContents);
            //Console.WriteLine("Number of words: " + countWords(myFileContents));
            //Console.WriteLine("Longest word: " + getLongestWord(myFileContents));

            //static int countWords(string str)
            //{

            //    var arr = str.Split(" ");

            //    return arr.Length;
            //}

            //static string getLongestWord(string str)
            //{
            //    var arr = str.Split(" ");
            //    var longestStr = "";
            //    var longestStrLength = 0;

            //    foreach (var foo in arr)
            //    {
            //        if (foo.Length > longestStrLength)
            //        {
            //            longestStr = foo;
            //            longestStrLength = foo.Length;
            //        }
            //    }

            //    return longestStr;
            //}



            //Console.WriteLine("Extension: " + Path.GetExtension(path2));
            //Console.WriteLine("File: " + Path.GetFileName(path2));
            //Console.WriteLine("File without extension: " + Path.GetFileNameWithoutExtension(path2));
            //Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path2));
            static bool MainMenu()
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine(" 1) Enter valid time string 24 hour format");
                Console.WriteLine(" 2) Make Pascal Case");
                Console.WriteLine(" 3) String has duplicate number");
                Console.WriteLine(" 4) Count vowels in a string");
                Console.WriteLine(" 5) String contains consecutive numbers");
                Console.WriteLine(" 6) Reverse string");
                Console.WriteLine(" 7) Truncate some strings");
                Console.WriteLine(" 8) Some DateTime stuff");
                Console.WriteLine(" 9) Calculate running total");
                Console.WriteLine("10) Create a random string of characters");
                Console.WriteLine("11) Guess a number");
                Console.WriteLine("12) Who gave likes to post");
                Console.WriteLine("13) Fancy Header");
                Console.WriteLine("14) Three smallest numbers in list");
                Console.WriteLine("15) Accept only unique numbers");

                Console.WriteLine("20) Exit");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        EnterValidTimeFormat();
                        return true;
                    case "2":
                        MakePascalCase();
                        return true;
                    case "3":
                        StrHasDuplicateNumber();
                        return true;
                    case "4":
                        CountVowelsInString();
                        return true;
                    case "5":
                        TestStringConsecutiveNumbers();
                        return true;
                    case "6":
                        ReverseString();
                        return true;
                    case "7":
                        TruncateSomeTexts();
                        return true;
                    case "8":
                        StuffWithDateTime();
                        return true;
                    case "9":
                        CalculateRunningTotal();
                        return true;
                    case "10":
                        GeneratePass();
                        return true;
                    case "11":
                        GuessNumberOneTen();
                        return true;
                    case "12":
                        ShowLikes();
                        return true;
                    case "13":
                        MakeFancyHeader();
                        return true;
                    case "14":
                        SmallestNumsInList();
                        return true;
                    case "15":
                        AcceptUniquesList();
                        return true;
                    case "20":
                        return false;
                    default:
                        return true;
                }
            }

            {
                bool showMenu = true;
                while (showMenu)
                {
                    showMenu = MainMenu();
                }
            }

        }
    }
}

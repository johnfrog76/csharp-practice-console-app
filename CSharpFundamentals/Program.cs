using System;
using System.Text;
using System.Collections.Generic;
using System.IO;
using System.Reflection;


namespace CSharpFundamentals
{

    class Program
    {
        public static void MenuExit()
        {
            WriteSuccessMessage("done!");
        }

        public static void WriteErrorMessage(string msg = "an unknown error occured")
        {
            var message = new Messages();
            message.Error(msg);
        }

        public static void WriteSuccessMessage(string msg)
        {
            var message = new Messages();
            message.Success(msg);
        }

        public static void WriteInstructions(string msg)
        {
            var message = new Messages();
            Console.Clear();
            message.Warn(msg);
        }

        static void Main(string[] args)
        {

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MenuApp.MainMenu();
            }

            // all this stuff is practice from tutorial
            // any new content belongs in menuItems folder

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

        }
    }
}

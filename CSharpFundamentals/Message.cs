using System;

namespace CSharpFundamentals
{
    public class Messages
    {
        private static void All(string msgType, string msg)
        {
            var myColor = ConsoleColor.DarkCyan;

            switch (msgType)
            {
                case "success":
                    myColor = ConsoleColor.Green;
                    break;
                case "error":
                    myColor = ConsoleColor.Red;
                    break;
                case "warn":
                    myColor = ConsoleColor.DarkYellow;
                    break;
                default:
                    break;
            }

            Console.ForegroundColor = myColor;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
        public void Error(string msg = "an unknown error occured")
        {
            All("error", msg);
        }

        public void Success(string msg)
        {
            All("success", msg);
        }

        public void Info(string msg)
        {
            All("info", msg);
        }
        public void Warn(string msg)
        {
            All("warn", msg);
        }
    }
}

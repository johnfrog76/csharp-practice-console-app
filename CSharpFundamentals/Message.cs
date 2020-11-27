using System;

namespace CSharpFundamentals
{

    public enum MessageType
    {
        Info,
        Error,
        Success,
        Warn,
    }
    public class Messages
    {
        private static void All(MessageType msgType, string msg)
        {
            var myColor = ConsoleColor.DarkCyan;

            switch (msgType)
            {
                case MessageType.Success:
                    myColor = ConsoleColor.Green;
                    break;
                case MessageType.Error:
                    myColor = ConsoleColor.Red;
                    break;
                case MessageType.Warn:
                    myColor = ConsoleColor.DarkYellow;
                    break;
                case MessageType.Info:
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
            All(MessageType.Error, msg);
        }

        public void Success(string msg)
        {
            All(MessageType.Success, msg);
        }

        public void Info(string msg)
        {
            All(MessageType.Info, msg);
        }
        public void Warn(string msg)
        {
            All(MessageType.Warn, msg);
        }
    }
}

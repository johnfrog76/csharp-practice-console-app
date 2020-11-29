using System;


namespace CSharpFundamentals
{
    public class OldMenuItem : MenuItem
    {
        public override string Title {get;}
        public override string Instructions => Title;

        public bool ShowsMenu { get; private set;}

        public string MethodName {get; private set;}

        // constructor
        public OldMenuItem(string description, bool showsMenu, string methodName)
        {
            Title = description;
            ShowsMenu = showsMenu;
            MethodName = methodName;
        }


        public override bool Execute()
        {
            try
            {
                var t = new Program();
                t.GetType()
                    .GetMethod(MethodName)
                    .Invoke(t, null);
                return true;
            }
            catch (Exception)
            {
                //Console.WriteLine("Error: " + ex.Message);
                var errorMessage = String.Format(
                    "Sorry could not find method {0}",
                    MethodName
                );
                Program.WriteErrorMessage(errorMessage);
                Console.ReadKey();
                return true;
            }
        }
    }
}

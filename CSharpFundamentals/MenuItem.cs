namespace CSharpFundamentals
{
    public class MenuItem
    {
        public string Description {get; private set;}

        public bool ShowsMenu { get; private set;}

        public string MethodName {get; private set;}

        // constructor
        public MenuItem(string description, bool showsMenu, string methodName)
        {
            Description = description;
            ShowsMenu = showsMenu;
            MethodName = methodName;
        }
    }
}

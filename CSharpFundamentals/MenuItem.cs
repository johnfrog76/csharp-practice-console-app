namespace CSharpFundamentals
{
    public class MenuItem
    {
        public string description;
        public bool showsMenu;
        public string methodName;

        // constructor
        public MenuItem(string description, bool showsMenu, string methodName)
        {
            this.description = description;
            this.showsMenu = showsMenu;
            this.methodName = methodName;
        }
    }
}

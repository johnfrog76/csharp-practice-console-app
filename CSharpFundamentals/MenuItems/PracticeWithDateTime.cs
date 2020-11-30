using System;

namespace CSharpFundamentals {
    class PracticeWithDateTime : MenuItem {
        public override string Title => "Some DateTime practice";
        public override string Instructions => "DateTime Practice";
        public override bool Execute() {

            Messages.Instruction(Instructions);

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

            MenuApp.SubMenu();

            return true;
        }
    }
}
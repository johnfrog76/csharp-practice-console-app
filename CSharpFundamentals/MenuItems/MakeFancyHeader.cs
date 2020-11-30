using System;
using System.Text;

namespace CSharpFundamentals {
    class MakeFancyHeader : MenuItem {

        public override string Title => "Make Fancy Heading";
        public override string Instructions => "Using String Builder to make fancy header";

        public override bool Execute() 
        {
            var builder = new StringBuilder();
            var heading = "Super Fancy Heading";
            var drawLen = heading.Length;

            Messages.Instruction(Instructions);

            builder
                .Append('-', drawLen)
                .AppendLine()
                .Append(heading)
                .AppendLine()
                .Append('-', drawLen);

            Messages.Success(builder.ToString());
            MenuApp.SubMenu();
            return true;
        }
    }
}
using System;

namespace CSharpFundamentals
{

    public abstract class MenuItem
    {
        public abstract string Title {get;}
        public abstract string Instructions {get;}
        public virtual string LoopInstructions
            => "Type something else, or press enter to return to menu.";

        protected static Messages Messages = new Messages();

        public abstract bool Execute();
    }


    public abstract class RepeatingStatelessMenuItem : MenuItem
    {
        protected abstract void LineHandler( string text );

        public override bool Execute() {
            Messages.Instruction( Instructions );
            var line = Console.ReadLine();

            while ( line.Length >= 1 ) {
                LineHandler( line );
                Messages.Info( LoopInstructions );
                line = Console.ReadLine();
            }
            return true;
        }
    }
}




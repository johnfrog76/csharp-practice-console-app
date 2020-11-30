namespace CSharpFundamentals
{
    public class EchoMenuItem : RepeatingStatelessMenuItem
    {
        public override string Title => "Echo";
        public override string Instructions => "Enter something to be repeated:";

        protected override void LineHandler(string text)
        {
            Messages.Instruction( text );
        }
    }
}
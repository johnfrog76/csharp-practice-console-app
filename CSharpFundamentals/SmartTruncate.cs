namespace CSharpFundamentals
{
    public class SmartTruncate
    {

        public string Truncate(string longText, int MaxLength = 20, string SummaryCharacter = "...")
        {
            if (longText.Length > MaxLength)
            {
                var split = longText.Substring(0, MaxLength);
                var trimmedWord = split.Substring(0, split.LastIndexOf(' '));
                return trimmedWord + " " + SummaryCharacter;
            }
            else
            {
                return longText;
            }
            // SmartTruncate
        }
    }
}

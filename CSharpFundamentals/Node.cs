namespace CSharpFundamentals
{
    public class Node {

        public string Data {get; set;}
        public Node Next {get; set;}

        public Node (string data, Node next = null) {
            Data = data;
            Next = next;
        }
    }
}
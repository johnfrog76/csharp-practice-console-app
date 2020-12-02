using System;

namespace CSharpFundamentals
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public Node Node { get; set; }

        protected static Messages Messages = new Messages();

        public LinkedList(Node head = null)
        {
            Head = head;
        }

        public void AddNodeHead(string data)
        {
            // var temp = this.Head;
            // this.Head = new Node(data, temp);
            AddAtIndex(data, 0);
        }

        public void RemoveAtIndex(int index)
        {
            var myNode = this.Head;


            if (index == 0)
            {

                if (myNode == null || myNode.Next == null)
                {
                    Head = null;
                    return;
                }
                else
                {
                    Head = myNode.Next;
                    return;
                }
            }

            var nextNode = myNode.Next;
            var counter = 1;

            while (myNode != null)
            {
                if (index == counter)
                {
                    myNode.Next = nextNode.Next;
                    return;
                }

                if (myNode.Next != null)
                {
                    myNode = myNode.Next;
                    nextNode = myNode.Next;
                    counter++;
                }
                else
                {
                    myNode = myNode.Next;

                }

            }

            return;

        }


        public void AddAtIndex(string data, int index)
        {
            var myNode = this.Head;
            var counter = 0;


            if (index == 0)
            {
                var temp = this.Head;
                this.Head = new Node(data, temp);
                return;
            }

            var nextNode = myNode.Next;
            counter++;

            while (myNode != null)
            {
                if (index == counter)
                {
                    myNode.Next = new Node(data, nextNode);
                    return;
                }

                if (myNode.Next != null)
                {
                    myNode = myNode.Next;
                    nextNode = myNode.Next;
                    counter++;
                }
                else
                {
                    myNode = myNode.Next;

                }

            }

            return;
        }

        public void AddNodeTail(string data)
        {
            var myNode = this.Head;


            if (myNode == null)
            {
                // case of no list
                this.Head = new Node(data, null);
                return;
            }

            var nextNode = myNode.Next;

            if (myNode.Next == null)
            {
                // case of one
                myNode.Next = new Node(data, null);
                return;
            }


            while (myNode != null)
            {
                if (nextNode == null)
                {
                    myNode.Next = new Node(data, null);
                    return;
                }
                myNode = myNode.Next;
                nextNode = myNode.Next;
            }
        }

        public void ListNodes()
        {
            if (this.Head == null)
            {
                return;
            }

            var myNode = this.Head;
            var myStr = "";

            while (myNode != null)
            {
                var isLast = (myNode.Next == null) ? "" : ",";
                myStr += String.Format("{0}{1} ", myNode.Data, isLast);

                myNode = myNode.Next;
            }

            Messages.Warn(myStr);
        }
    }
}
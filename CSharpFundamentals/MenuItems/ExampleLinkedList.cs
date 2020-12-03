using System;

namespace CSharpFundamentals {
    class ExampleLinkedList : MenuItem {
        public override string Title => "Link List";
        public override string Instructions => "Make a link list";
        public override bool Execute() {

            Messages.Instruction(Instructions);


            var linkedList = new LinkedList();

            // add to head

            linkedList.AddNodeHead("apple");
            linkedList.AddNodeHead("pear");
            linkedList.AddNodeHead("orange");
            linkedList.AddNodeHead("strawberry");
            linkedList.AddNodeHead("grape");
            linkedList.ListNodes();

            // add at index
            linkedList.AddAtIndex("kiwi", 2);
            Messages.Success("\r\nadd 'kiwi' at index 2\r\n");
            linkedList.ListNodes();

            // add to tail
            Messages.Success("\r\nadd links at tail\r\n");
            linkedList.AddNodeTail("banana");
            linkedList.AddNodeTail("watermellon");
            linkedList.ListNodes();


            // remove at index
            Messages.Success("\r\nremoving 'grape' first node\r\n");

            linkedList.RemoveAtIndex(0);
            linkedList.ListNodes();
            linkedList.RemoveAtIndex(3);
            Messages.Success("\r\nremoving 'pear' at index 3\r\n");
            linkedList.ListNodes();


            MenuApp.SubMenu();

            return true;
        }
    }
}
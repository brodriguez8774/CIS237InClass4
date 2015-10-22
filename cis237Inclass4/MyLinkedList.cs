using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass4
{
    class MyLinkedList
    {
        #region Variables

        // Holds position of where were we are in linked list by pointing directly to a specific node.
        private Node current;

        #endregion



        #region Constructor

        /// <summary>
        /// Constructor which sets head to null due to nothing in list on create.
        /// </summary>
        public MyLinkedList()
        {
            Head = null;
        }

        #endregion



        #region Properties

        // Public property that points to head node (first node in list).
        public Node Head
        {
            set;
            get;
        }

        #endregion



        #region Methods
        
        /// <summary>
        /// Adds a new node to the linked list. Then specifies current node as newly created node.
        /// </summary>
        /// <param name="content">Content to add to new node.</param>
        public void Add(string content)
        {
            // Make a new node for linked list. Current node stays the same until later specified.
            Node node = new Node();
            // Adds passed in content to data field of node.
            node.Data = content;

            // Adds the first element to our list.
            if (Head == null)
            {
                Head = node;
            }
            // Not the first node so set the new node to current node's "next" variable.
            else
            {
                current.Next = node;
            }

            // Move down on list. Set current to node just added.
            current = node;
        }

        public bool Delete(int position)
        {
            // Sets current to start of linkedlist.
            current = Head;
            // If position to delete is on the very first node.
            if (position == 1)
            {
                // Set head to next node in list and remove this node's pointer so it will be put in garbage collection.
                Head = current.Next;
                // The next two statements remove all pointers to and from node so that it gauranteed will be picked up by garbage collection.
                current.Next = null;
                current = null;
                return true;
            }

            // Checks to make sure positive number was entered.
            // Should also check to make sure the position is less than the size of linkedlist.
            if (position > 1)
            {
                // Make a temp node that starts at the head.
                Node tempCurrentNode = Head;
                Node tempPreviousNode = null;
                // Starts a counter to  know if we reached the position
                int index = 0;

                // While current is not null, walk through list. If it is null, we reached the end.
                while (tempCurrentNode != null)
                {
                    // If index equals position - 1, then we have found the one to delete.
                    if (index == position - 1)
                    {
                        // Remove all pointers to and from found node to remove.
                        tempPreviousNode.Next = tempCurrentNode.Next;
                        tempCurrentNode.Next = null;
                        return true;
                    }
                    index++;

                    // Set both tempNodes to point to the same node. Then point tempNode to the next node.
                    tempPreviousNode = tempCurrentNode;
                    tempCurrentNode = tempCurrentNode.Next;
                }
            }
            return false;
        }

        #endregion

    }
}

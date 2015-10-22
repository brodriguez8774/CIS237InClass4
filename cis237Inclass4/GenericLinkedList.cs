using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass4
{
    class GenericLinkedList<T>
    {
        #region Variables

        private GenericNode<T> current; // Holds current position in linked list.
        private GenericNode<T> last;    // Holds last position in linked list.

        #endregion



        #region Constructor

        public GenericLinkedList()
        {
            Head = null;
        }

        #endregion



        #region Properties

        public GenericNode<T> Head
        {
            set;
            get;
        }

        #endregion



        #region Methods

        public void Add(T content)
        {
            GenericNode<T> node = new GenericNode<T>();

            node.Data = content;

            if (Head == null)
            {
                Head = node;
            }
            else
            {
                last.Next = node;
            }
            last = node;
        }

        public bool Delete(int Position)
        {
            current = Head;

            if (Position == 1)
            {
                Head = current.Next;
                current.Next = null;
                current = null;
                return true;
            }
            else
            {
                if (Position > 1)
                {
                    GenericNode<T> tempNode = Head;
                    GenericNode<T> previousTempNode = null;

                    int count = 0;
                    while (tempNode != null)
                    {
                        if (count == Position - 1)
                        {
                            previousTempNode.Next = tempNode.Next;

                            if (tempNode.Next == null)
                            {
                                last = previousTempNode;
                            }

                            tempNode.Next = null;
                            return true;
                        }
                        count++;
                        previousTempNode = tempNode;
                        tempNode = tempNode.Next;
                    }
                }
            }
            return false;
        }

        public GenericNode<T> Retrieve(int Position)
        {
            GenericNode<T> tempNode = Head;
            GenericNode<T> returnNode = null;

            int count = 0;
            while (tempNode != null)
            {
                if (count == Position - 1)
                {
                    return tempNode;
                    break;  // Force break out of loop. No need to keep looking.
                }
                count++;
                tempNode = tempNode.Next;
            }
            return returnNode;
        }

        #endregion

    }
}

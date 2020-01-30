using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T : IComparable
    { 
        Node<T> root;

        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if(root is null)
            {
                root = node;
            }
            else
            {
                Node<T> current = root;
                while(current != null)
                {
                    if (data.CompareTo(current.data) <= 0)
                    {
                        current = current.leftChild;
                    }
                    else
                    {
                        current = current.rightChild;
                    }
                }
                current = node;               
            }           
        }
        public Node<T> Search(T data)
        {
            Node<T> current = root;
            
            while(current != null)
            {
                if (current.data.Equals(data))
                {
                    return current;
                }
                else if(data.CompareTo(current.data) < 0)
                {
                    current = current.leftChild;
                }
                else
                {
                    current = current.rightChild;
                }
            }
            return null;
        }

        
      

    }
}

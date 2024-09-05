using Data_structures_exercise.Model;
using Data_structures_exercise.servis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures_exercise
{
    internal class BST
    {
        private Node root;

        public BST()
        {
            root = null;
        }

        public void Insert(Node newNode)
        {
            root = InsertRecursive(root, newNode);
        }

        private Node InsertRecursive(Node node, Node newNode)
        {
            if (node == null)
            {
                return newNode;
            }
            if (newNode.MaxSeverity < node.MinSeverity)
                node.Left = InsertRecursive(node.Left, newNode);
            else
                node.Right = InsertRecursive(node.Right, newNode);
            return node;
        }

        public void PrintPreOrder()
        {
            Console.WriteLine("Tree structure with left/right child distinctions:");
            PrintPreOrderRecursive(root);
        }

        private void PrintPreOrderRecursive(Node root)
        {
            Console.WriteLine(PrintServis.PrintNode(root));
            if (root.Left != null) 
            {
                PrintPreOrderRecursive(root.Left);
            }
            if (root.Right != null)
            {
                PrintPreOrderRecursive(root.Right);
            }


        }
    }

    
}

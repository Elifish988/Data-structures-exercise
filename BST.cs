using Data_structures_exercise.Model;
using Data_structures_exercise.servis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Data_structures_exercise
{
    internal class BST
    {
        private Node root;

        public BST()
        {
            root = null;
        }

        //O(log n)
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


        //הדפסה של העץ בצורת עץ
        //O(n)
        public void PrintPreOrder()
        {
            Console.WriteLine("Tree structure with left/right child distinctions:");
            PrintTree(root , "", true);
        }
        
        private void PrintTree(Node node, string indent, bool last)
        {
            if (node != null)
            {
                Console.Write(indent);
                if (last)
                {
                    Console.Write("R----");
                    indent += "   ";
                }
                else
                {
                    Console.Write("L----");
                    indent += "|  ";
                }
                Console.WriteLine(PrintServis.PrintNode(node));
                PrintTree(node.Left, indent, false);
                PrintTree(node.Right, indent, true);
            }
        }


        //החזרת ערך המינימום של העץ
        // O(log n)
        public int? GetMin()
        {
            return GetMin(root);
        }

        private int? GetMin(Node tmp)
        {

            if (tmp == null)
            {
                return null;
            }
            while (tmp.Left != null)
            {
                tmp = tmp.Left;
            }
            return tmp.MinSeverity;
        }


        //מציאת הגנה על פי רמת חומרה
        // O(log n)
        public Node Find(int severity)
        {
            
            return FindRecursive(root, severity); ;
        }


        public Node FindRecursive(Node root, int severity)
        {
            if (root == null)
                return null;
;
            if (severity < root.MinSeverity)
            {
                return FindRecursive(root.Left, severity);
            }
            else if (severity > root.MaxSeverity)
            {
                return FindRecursive(root.Right, severity);
            }
            return root;

        }

    }


}

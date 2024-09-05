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


        //מציאת הגנה על פי רמת חומרה
        //        public string Find(int severity)
        //        {
        //            // החזרת סטרינג במידה והאיום קטן מהטווח
        //            if (severity < GetMin())
        //                return "Attack severity is below the threshold.Attack is ignored";
        //            return FindRecursive(root, severity); ;
        //        }


        //        public string FindRecursive(Node root, int severity)
        //        {
        //            if (root == null)
        //                return "No suitable defence was found.Brace for impact"!
        //;
        //            if (severity < root.MinSeverity)
        //            {
        //                return FindRecursive(root.Left, severity);
        //            }
        //            else if(severity > root.MaxSeverity)
        //            {
        //                return FindRecursive(root.Right, severity);
        //            }
        //            return root.Defenses.ToString();

        //        }


    }


}

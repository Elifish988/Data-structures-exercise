using Data_structures_exercise.Model;
using Data_structures_exercise.servis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures_exercise
{
    internal class RunFunctions
    {
        public static async Task RanDefence()
        {
            Console.WriteLine("File reader:");
            Task.Delay(4000);
            string data = File.ReadAllText("D:\\KodcodData\\Data structures exercise\\Jsons\\defenceStrategiesBalanced.json"); 
            var nods = ReadJson<Node>.readJson(data);
            Task.Delay(4000);
            Console.WriteLine("Puts in the tree:");
            Task.Delay(4000);
            BST bST = new BST();
            foreach (Node node in nods)
            {
                
                bST.Insert(node);
            }
            Task.Delay(4000);
            Console.WriteLine("Print protections;");
            Task.Delay(4000);
            bST.PrintPreOrder();
        }
    }
}

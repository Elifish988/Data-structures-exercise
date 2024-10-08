﻿using Data_structures_exercise.Model;
using Data_structures_exercise.servis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Data_structures_exercise
{
    // מריצה את הפעילויות הרשיות בשביל הרצת התכנה
    internal class RunFunctions
    {
        internal static List<Node> nods {  get; set; }
        internal static List<Threat> Threats { get; set; }

        //מריץ את מערך ההגנה
        //o(n log n)
        internal static async Task<BST> RanDefence()
        {
            Console.WriteLine("File reader:");
            await Task.Delay(1000);
            string data = File.ReadAllText("D:\\KodcodData\\Data structures exercise\\Jsons\\defenceStrategiesBalanced.json"); 
            nods = await ReadJson<Node>.readJson(data);
            await Task.Delay(1000);
            Console.WriteLine("Puts in the tree:");
            await Task.Delay(1000);
            BST bST = new BST();
            foreach (Node node in nods)
            {
                
                bST.Insert(node);
            }
            await Task.Delay(1000);
            Console.WriteLine("Print protections;");
            await Task.Delay(1000);
            bST.PrintPreOrder();
            return bST;

        }


        // קורא את ההתקפות
        ////o(n log n)
        public static async Task RanThreats(BST bST)
        {
            Console.WriteLine("File reader:");
            await Task.Delay(1000);
            string data = File.ReadAllText("D:\\KodcodData\\Data structures exercise\\Jsons\\threats.json");
            Threats = await ReadJson<Threat>.readJson(data);
            Console.WriteLine("Runs attacks:");
            int AttackNum = 1;
            foreach (Threat thread in Threats)
            {
                Console.WriteLine($"attack number  {AttackNum}");
                Console.WriteLine("Defines a severity level:");
                await Task.Delay(1000);
                int severity = ThreastServer.Severity(thread);
                Console.WriteLine("running defenses:");
                await Task.Delay(1000);
                Node node = bST.Find(severity);
                //החזרת סטרינג במידה והאיום קטן מהטווח
                if (severity < bST.GetMin())
                    Console.WriteLine("Attack severity is below the threshold.Attack is ignored");
                else if (node == null)
                     Console.WriteLine("No suitable defence was found.Brace for impact");
                else
                {
                    foreach(string protection in node.Defenses)
                    {
                        await Task.Delay(1000);
                        Console.WriteLine(protection);
                    }
                }
                AttackNum++;
            };

        }


    }
}

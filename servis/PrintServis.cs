using Data_structures_exercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures_exercise.servis
{
    //עוזרת בהדפסה יפה של הקוד
    internal class PrintServis
    {
        // מחזירה סטרינג להדפסה
        // O(n)
        public static string PrintNode(Node node)
        {
            string striNode = $" Server range: {node.MinSeverity} - {node.MaxSeverity} Defenses: ";
            foreach (string Defenses in node.Defenses)
            {
                striNode += Defenses;
            }
            return striNode;

        }
    }
}

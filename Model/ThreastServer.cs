using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures_exercise.Model
{
    internal class ThreastServer
    {
        // מילון להמרת חומרת ההתקפה
        //o(1)
        public static Dictionary<string, int> TargetValue = new Dictionary<string, int>
        {
            {"Web Server", 10 },
            {"Database", 15 },
            {"User Credentials", 20 }
        };


        // מגדירה חומרה על פי יעוד ההתקפה
        //o(1)
        public static int GetTargetValue(string key)
        {
            if (TargetValue.TryGetValue(key, out int value))
            {
                return value;
            }
            return 5;
        }


        // מגדירה רמת חומרה כללית
        //o(1)
        public  static int Severity(Threat thread)
        {
            int Severity = 
                (thread.Volume
                * thread.Sophistication)
                + GetTargetValue(thread.Target);
            return Severity;


        }

    }
}

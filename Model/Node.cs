﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Data_structures_exercise.Model
{
    internal class Node
    {
        public int MinSeverity { get; set; }
        public int MaxSeverity { get; set; }
        public List<string> Defenses { get; set; }

        public Node Right { get; set; }

        public Node Left { get; set; }

        public Node(int minSeverity, int maxSeverity, List<string> defenses)
        {
            this.MinSeverity = minSeverity;
            this.MaxSeverity = maxSeverity;
            this.Defenses = defenses;
            this.Left = null;
            this.Right = null;
        }
    }
}

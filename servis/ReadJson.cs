﻿using Data_structures_exercise.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Data_structures_exercise.servis
{
    internal class ReadJson<T>
    {
        public async static Task<List<T>> readJson(string data)
        {
            
            List<T> a = JsonSerializer.Deserialize<List<T>>(data)!;
            return a;
            
        }
    }
}

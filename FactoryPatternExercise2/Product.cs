using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class Product
    {
        public int Price { get; set; }

        // Fix for CS8618: Initialize 'Name' with a default value to ensure it is not null.
        public string Name { get; set; } = string.Empty;
    }
}
    
using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            IsColdBlooded = true;
            MakesNoise = true;
            IsScaley = true;
            Habitat = "swamp";
        }

        public bool IsColdBlooded { get; set; }
        public bool MakesNoise { get; set; }
        public bool IsScaley { get; set; }
        public string Habitat { get; set; }
    }
}

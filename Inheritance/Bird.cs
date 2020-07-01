using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            IsAlive = true;
            LegCount = 2;
            LandSeaAir = "Air";
            Age = 0;
        }
        public bool IsAlive { get; set; }
        public bool CanFly { get; set; }
        public string FeatherColor { get; set; }
        public bool DoMigrate { get; set; }


    }




}

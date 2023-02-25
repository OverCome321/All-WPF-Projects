using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary5Unit
{
    public class Unit
    {
        int HpUnit;
        int DamageUnit;
        public int hpUnit
        {
            get { return HpUnit; }
            set { HpUnit = value; }
        }
        public int damageUnit
        {
            get { return DamageUnit; }
            set { DamageUnit = value; }
        }
    }
    public class Mag : Unit
    {
        int Mana;
        public int mana
        {
            get { return Mana; }
            set { Mana = value; }
        }
    }
    public class Shooter : Unit
    {
        int Arrow;
        public int arrow
        {
            get { return Arrow; }
            set { Arrow = value; }
        }
    }
}

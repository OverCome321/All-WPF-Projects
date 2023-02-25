using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class KnightStats
    {
        int damageFirstKnight;
        int damageSecondKnight;
        double goldenFirstKnight;
        double goldenSecondKnight;
        int healsFirstKnight;
        int healsSecondKnight;
        int livesOfFirstKnights;
        int livesOfSecondKnights;
        public int DamageFirstKnight
        {
            get { return damageFirstKnight; }
            set { damageFirstKnight = value; }
        }
        public int DamageSecondKnight
        {
            get { return damageSecondKnight; }
            set { damageSecondKnight = value; }
        }
        public double GoldenFirstKnight
        {
            get { return goldenFirstKnight; }
            set { goldenFirstKnight = value; }
        }
        public double GoldenSecondKnight
        {
            get { return goldenSecondKnight; }
            set { goldenSecondKnight = value; }
        }
        public int HealsFirstKnight
        {
            get { return healsFirstKnight; }
            set { healsFirstKnight = value; }
        }
        public int HealsSecondKnight
        {
            get { return healsSecondKnight; }
            set { healsSecondKnight = value; }
        }
        public int LivesOfFirstKnights
        {
            get { return livesOfFirstKnights; }
            set { livesOfFirstKnights = value; }
        }
        public int LivesOfSecondKnights
        {
            get { return livesOfSecondKnights; }
            set { livesOfSecondKnights = value; }
        }


    }
}

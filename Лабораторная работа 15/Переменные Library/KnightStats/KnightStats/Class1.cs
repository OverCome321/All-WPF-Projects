using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightStats
{
    public class KnightStatsAndMethods
    {
        int damageFirstKnight;
        int damageSecondKnight;
        double goldenFirstKnight;
        double goldenSecondKnight;
        double goldCostFirst;
        double goldCostSecond;
        int healsFirstKnight;
        int healsSecondKnight;
        int livesOfFirstKnights;
        int livesOfSecondKnights;
        int HpOfFirstKnight;
        int HpOfSecondKnight;
        int PbFirstKnight;
        int PbSecondKnight;
        public double GoldCostFirst
        {
            get { return goldCostFirst; }
            set { goldCostFirst = value; }
        }
        public double GoldCostSecond
        {
            get { return goldCostSecond; }
            set { goldCostSecond = value; }
        }
        public int hpOfFirstKnight
        {
            get { return HpOfFirstKnight; }
            set { HpOfFirstKnight = value; }
        }
        public int hpOfSecondKnight
        {
            get { return HpOfSecondKnight; }
            set { HpOfSecondKnight = value; }
        }
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
        public int pbFirstKnight
        {
            get { return PbFirstKnight; }
            set { PbFirstKnight = value; }
        }
        public int pbSecondKnight
        {
            get { return PbSecondKnight; }
            set { PbSecondKnight = value; }
        }
        //Нанести урон по второму рыцарю
        public int FirstHeroDamage()
        {
            HpOfSecondKnight -= damageFirstKnight;
            return HpOfSecondKnight;
        }
        //Нанести урон по первому рыцарю
        public int SecondHeroDamage()
        {
            HpOfFirstKnight -= damageSecondKnight;
            return HpOfFirstKnight;
        }
        //Минус 1 зелье лечения первого рыцаря
        public int UseFirstHeroHeal()
        {
            healsFirstKnight--;
            return healsFirstKnight;
        }
        //Минус 1 зелье лечения второго рыцаря
        public int UseSecondHeroHeal()
        {
            healsSecondKnight--;
            return healsSecondKnight;
        }
        //Исцелить зельем лечения первого рыцаря
        public int FirstHpKnight()
        {
            hpOfFirstKnight += PbFirstKnight;
            return hpOfFirstKnight;
        }
        //Исцелить зельем лечения второго рыцаря
        public int SecondHpKnight()
        {
            hpOfSecondKnight += PbSecondKnight;
            return hpOfSecondKnight;
        }
        // Потратить жизнь первого рыцаря
        public string ResetHpFirst()
        {
            if (LivesOfFirstKnights == 0 && hpOfFirstKnight <= 0)
                return "Жизней больше нет, вы проиграли!";
            else
            {
                hpOfFirstKnight += PbFirstKnight;
                return "Вы потратили 1 жизнь!";
            }
        }
        // Потратить жизнь второго рыцаря
        public string ResetHpSecond()
        {
            if (LivesOfSecondKnights == 0 && hpOfSecondKnight <= 0)
                return "Жизней больше нет, вы проиграли!";
            else
            {
                hpOfSecondKnight += PbSecondKnight;
                return "Вы потратили 1 жизнь!";
            }
        }
        // Заплатить золото первого рыцаря
        public double CostGoldFirstKnight()
        {
            goldenFirstKnight -= goldCostFirst;
            return goldenFirstKnight;
        }
        // Заплатить золото второго рыцаря
        public double CostGoldSecondKnight()
        {
            goldenSecondKnight -= goldCostSecond;
            return goldenSecondKnight;
        }
    }
}

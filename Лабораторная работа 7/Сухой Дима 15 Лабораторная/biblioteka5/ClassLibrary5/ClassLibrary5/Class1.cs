using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary5
{
    public class Unit
    {
        protected int HpFirstArmy;  //уровень здоровья
        protected int HpSecondArmy; //уровень здоровья
        protected int maxHP;    //максимальный уровень здоровья
        protected int attackFirstArmy;   // уровень атаки
        protected int attackSecondArmy;   // уровень атаки
        protected int defence;  //уровень защиты
        public int hpOfFirstArmy
        {
            get {return HpFirstArmy; }
            set { HpFirstArmy = value; }
        }
        public int hpOfSecondArmy
        {
            get { return HpSecondArmy; }
            set { HpSecondArmy = value; }
        }
        public int MaxHp
        {
            get { return maxHP; }
            set { maxHP = value; }
        }

        public int AttackFirstArmy
        {
            get { return attackFirstArmy; }
            set { attackFirstArmy = value; }
        }
        public int AttackSecondArmy
        {
            get { return attackSecondArmy; }
            set { attackSecondArmy = value; }
        }

        public int Defence
        {
            get { return defence; }
            set { defence = value; }
        }   

        public int DoAttackFirstArmy()
        {
            if (hpOfSecondArmy <= 0)
            {
                return 0;
            }
            else
            {
                return hpOfSecondArmy -= attackFirstArmy;
            }    
        }
        public int DoAttackSecondArmy()
        {
            if (hpOfFirstArmy <= 0)
            {
                return 0;
            }
            else
            {
                return hpOfFirstArmy -= attackSecondArmy;
            }
        }
    }
      
    public class Shooter : Unit
    {
        static int arrowFirst;
        static int arrowSecond;    // число стрел

        public  int ArrowFirst
        {
            get { return arrowFirst; }
            set { arrowFirst = value; }
        }

        public int ArrowSecond
        {
            get { return arrowSecond; }
            set { arrowSecond = value; }
        }
        public  int ArrCheckFirst()
        {
            if (arrowFirst > 0)
                return arrowFirst -= 1;
            else
                return 0;
        }
        public int ArrCheckSecond()
        {
            if (arrowSecond > 0)
                return arrowSecond -= 1;
            else
                return 0;
        }
    }
    public class Mag : Unit
    {

        static int manaFirst; // число маны
        static int manaSecond;

        public  int ManaFirst
        {
            get { return manaFirst; }
            set { manaFirst = value; }
        }
        public int ManaSecond
        {
            get { return manaSecond; }
            set { manaSecond = value; }
        }
        public  int ManaCheckFirst()
        {
            if (manaFirst > 0)
            {
                Random r = new Random();
                manaFirst -= r.Next(1, 15);
                return manaFirst;
            }
            else
            {
                return 0;
            }

        }
        public int ManaCheckSecond()
        {
            if (manaSecond > 0)
            {
                Random r = new Random();
                manaSecond -= r.Next(1, 15);
                return manaSecond;
            }
            else
            {
                return 0;
            }

        }
    }
}

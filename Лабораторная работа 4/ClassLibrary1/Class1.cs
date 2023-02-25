using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class SourseOfStrengh
    {
        private int Damage; // число единиц атаки, на которое поднимется уровень атаки за одно использование
        private int MaxUss; // максимально возможное число использований
        private int NowUss; // текущее число использований
        private int Power; // сила источника
        public int damage
        {
            get { return Damage; }
            set { Damage = value; }
        }
        public int maxUss
        {
            get { return MaxUss; }
            set { MaxUss = value; }
        }
        public int nowUss
        {
            get { return NowUss; }
            set { NowUss = value; }
        }
	public int power
	{
	    get {return Power;}
        set {Power = value;}
	}
        Random rnd = new Random();
        /// <summary>
        /// Метод увеличивает силу героя после 1 использования источника 
        /// </summary>
        /// <returns></returns>
        public int SoursOfStrengh()
        {
            return Damage + Power;

        }
        /// <summary>
        /// Метод наполняет источник 
        /// </summary>
        /// <returns></returns>
        public int Return()
        {
            return power;
        }
    }


    public class EverOfSource : SourseOfStrengh
    {
        private int s; // Сила источника
        public int S
        {
            get { return s; }
            set { s = value; }
        }
        public int Источник_всегда_полон()
        {
            return s = 100;
        }
    }

    public class CursedOfSource : SourseOfStrengh
    {
        private int k; // Степень проклятия 
        public int K
        {
            get { return k; }
            set { k = value; }
        }
        public int Cursed(int k)
        {
            for (int i = 0; k > 1; i++)
            {
                k--;
            }
            return k;
                    

        }
    }
}

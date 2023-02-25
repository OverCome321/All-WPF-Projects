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
	

        /// <summary>
        /// Метод увеличивает силу героя после 1 использования источника 
        /// </summary>
        /// <returns></returns>
        public int SoursOfStrengh(int MaxUss, int NowUss)
        {
            MaxUss -= 1;
            return NowUss += 1;

        }
        /// <summary>
        /// Метод наполняет источник    
        /// </summary>
        /// <returns></returns>
        public int Return(int MaxUss, int NowUss)
        {
            return NowUss = MaxUss;
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
            return k = 1;
        }
    }
}

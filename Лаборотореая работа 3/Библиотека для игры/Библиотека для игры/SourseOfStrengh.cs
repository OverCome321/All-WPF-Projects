using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Библиотека_для_игры
{
    public class SourseOfStrengh 
    {
        public int Damage; // число единиц атаки, на которое поднимется уровень атаки за одно использование
        public int MaxUss; // максимально возможное число использований
        public int NowUss; // текущее число использований
        public int Power; // сила источника
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
        Random rnd = new Random();
        /// <summary>
        /// Метод увеличивает силу героя после 1 использования источника 
        /// </summary>
        /// <returns></returns>
        public int SoursOfStrengh()
        {
            Power = rnd.Next(1, 100);
            return Damage + Power;
            
        }
    }
}

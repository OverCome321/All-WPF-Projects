using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    public class Tower
    {

        int levelOfAttack;  //уровень атаки
        bool princess = false;    //признак наличия
        string nameTower;  //имя башни
        int maxHP;       //макс хп
        int currentHP;     //текущее хп
        int TowerDamage; // Атака башни
        int CountOfPrincess; //Число принцесс
        public int countOfPrincess
        {
            get { return CountOfPrincess; }
            set { CountOfPrincess = value; }
        }
        public int towerDamage
        {
            get { return TowerDamage; }
            set { TowerDamage = value; }
        }
        public string NameTower
        {
            get { return nameTower; }
            set { nameTower = value; }
        }
     
        public bool Princess
        {
            get { return princess; }
            set { princess = value; }
        }

        public int MaxHP
        {
            get
            {
                return maxHP;
            }
            set
            {
                if (value > 1000)
                    maxHP = 1000;
                else maxHP = value;
            }
        }


        public int CurrentHP
        {
            get
            {
                return currentHP;
            }
            set { currentHP = value; }
        }

        public int LevelOfAttack
        {

            get { return levelOfAttack; }
            set { levelOfAttack = value; }
        }
        public string Princess_set()
        {
            princess = true;
            return "Принцесса в башне";
        }
        public string Princess_delete()
        {
            princess = false;
            return "Принцессы нет в башне";
        }

        public virtual int Attack()
        {
            if (currentHP - levelOfAttack <= 0)
                return currentHP -= Math.Min(levelOfAttack, currentHP);
            else
                return currentHP -= levelOfAttack;
        }

        public class TowerwClock : Tower 
        {
            int Clock;    // число циферблатов


            public int clock
            {
                get { return Clock; }
                set { Clock = value; }
            }


            
        }
        public class TowerMayak : Tower
        {
            bool Mayak;  //включен или выключен маяк


            public bool mayak
            {
                get { return mayak; }
                set { mayak = value; }
            }
            public string MayakOn()
            {
                mayak = true;
                return "Маяк включен!";
            }
            public string MayakOff()
            {
                mayak = false;
                return "Маяк выключен!";

            }
            public override int Attack()
            {
                if (mayak == true)
                {
                    levelOfAttack = levelOfAttack * 2;
                    return levelOfAttack;
                }
                else
                    return 0;
                
            }

        }
        public class TowerOfClock : Tower
        {
            int NumOfClock; //Число циферблатов 
            public int numOfclock
            {
                get { return numOfclock; }
                set { numOfclock = value; }
            }
            public override int Attack()
            {
                if (numOfclock > 0)
                {


                    for (int i = 0; i < numOfclock; i++)
                    {
                        levelOfAttack = levelOfAttack - i;
                        maxHP = maxHP - levelOfAttack;
                        
                    }
                    return maxHP;
                }
                else
                {
                    maxHP = maxHP - levelOfAttack;
                    return maxHP;
                }
            }
        }
    }
}
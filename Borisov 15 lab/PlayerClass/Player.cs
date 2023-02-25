using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerClass
{
    public class Knight
    {
        protected int maxHP; //Максимальное количество здоровья персонажа
        protected int HP; //Настоящее количетсво здоровья персонажа
        protected int maxAtack; //Максимальная атака персонажа
        public int MaxHP
        {
            get { return maxHP; }
            set { maxHP = value; }
        }
        public int HPNow
        {
            get { return HP; }
            set { HP = value; }
        }
        public int MaxAtack
        {
            get { return maxAtack; }
            set { maxAtack = value; }
        }

        /// <summary>
        /// Метод для удара врага
        /// </summary>
        /// <returns> Возвращает величину атаки </returns>
        public int GiveAtack()
        {
            Random rand = new Random(); // Объявление экземпляра рандом
            int atack = rand.Next(maxAtack);
            return atack;
        }

        /// <summary>
        /// Метод для получения урона
        /// </summary>
        public void TakeDamage()
        {
            HP -= GiveAtack();
        }

        /// <summary>
        /// Метод для вычисления процента, который будет добавлен к числу жизней игрока
        /// </summary>
        /// <returns>Возвращает процент</returns>
        public int takePercent()
        {
            Random rand = new Random(); // Объявление экземпляра рандом
            try
            {
                return (rand.Next(1, HP) * 100) / 100;
            }
            catch (ArgumentOutOfRangeException)
            {
                return 0;
            }
        }

        /// <summary>
        /// Метод для надевания артефакта
        /// </summary>
        public virtual void PutOn()
        {
            HP += takePercent();
        }

        /// <summary>
        /// Метод для снятия артефакта
        /// </summary>
        public void TakeOff()
        {
            HP -= 1;
        }
    }

    public class Crusader: Knight
    {
        int age; //Возраст крестоносца
        int requiredAge;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int ReguiredAge
        {
            get { return requiredAge; }
            set { requiredAge = value; }
        }

        public void IncreaseAge()
        {
            age++;
        }

        public override void PutOn()
        {
            if (age >= requiredAge)
            {
                HP += takePercent();
            }
        }
    }

    public class KnightOfTheRoundTable : Knight
    {
        int countOfHikes; //Число походов
        public int CountOfHikes
        {
            get { return countOfHikes; }
            set { countOfHikes = value; }
        }

        public override void PutOn()
        {
            HP += takePercent() * 2;
        }

        public int status()
        {
            if (countOfHikes < 3)
            {
                return 10;
            }
            else if (countOfHikes < 10)
            {
                return 20;
            }
            else if (countOfHikes < 25)
            {
                return 30;
            }
            else
            {
                return 40;
            }
        }
    }
}

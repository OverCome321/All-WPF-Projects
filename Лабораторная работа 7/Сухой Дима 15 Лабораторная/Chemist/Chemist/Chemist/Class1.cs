using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chemist
{
    public class ChemistClass
    {
        private int countOfChemistFirst; // Количество аптечек
        private double hpOfChemistFirst; //На сколько восстановит здоровье аптечка
        private int countOfChemistSecond; // Количество аптечек
        private double hpOfChemistSecond; //На сколько восстановит здоровье аптечка
        public int CountOfChemistFirst
        {
            get { return countOfChemistFirst; }
            set { countOfChemistFirst = value; }
        }
        public double HpOfChemistsFirst
        {
            get { return hpOfChemistFirst; }
            set { hpOfChemistFirst = value; }
        }
        public int CountOfChemistSecond
        {
            get { return countOfChemistSecond; }
            set { countOfChemistSecond = value; }
        }
        public double HPOfChemistsSecond
        {
            get {  return hpOfChemistSecond; }
            set { hpOfChemistSecond = value; }
        }
        public int CountOfChemistsFirstMethod()
        {
            if (countOfChemistFirst == 0)
            {
                return countOfChemistFirst = 0;
            }
            else
            {
                return countOfChemistFirst--;
            }
        }
        public double HpOfChemistFirstMethod(double hpArmyFirst)
        {
            return hpArmyFirst += hpOfChemistFirst;
        }
        public int CountOfChemistsSecondMethod()
        {
            if (countOfChemistSecond == 0)
            {
                return countOfChemistSecond = 0;
            }
            else
            {
                return countOfChemistSecond--;
            }
        }
        public double HpOfChemistsSecondMethod(double hpArmySecond)
        {
            return hpArmySecond += hpOfChemistSecond;
        }

    }
}

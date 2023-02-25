using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
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
        public virtual int SoursOfStrengh()
        {
            return NowUss - 1;

        }
        /// <summary>
        /// Метод наполняет источник    
        /// </summary>
        /// <returns></returns>
        public int Return()
        {
            return NowUss = MaxUss;
        }
        /// <summary>
        /// Метод возобновляет выполнение программы
        /// </summary>
        /// <returns></returns>
        public int Date()
        {
            return NowUss = 0;
        }
    }
    // 4 Лабораторная работа
    // Бесконечный источник
    public class EverOfSource : SourseOfStrengh
    {
        private int s; // Сила источника
        public int S
        {
            get { return s; }
            set { s = value; }
        }
    }
    // Проклятый источник
    public class CursedOfSource : SourseOfStrengh
    {
        private int k; // Степень проклятия 
        public int K
        {
            get { return k; }
            set { k = value; }
        }
        /// <summary>
        /// С каждым использованием этот метод уменьшает степень проклятия на 1
        /// </summary>
        /// <returns></returns>
        public int Cursed()
        {
            return k = 1;
        }
        /// <summary>
        /// Возвращает степень проклятия
        /// </summary>
        /// <returns></returns>
        public override int SoursOfStrengh()
        {
            return k;
        }
    }
    // 8 Лабораторная работа
    public class Massiv
    {
        private int NumberOfTextBox; // Число TexBox
        public int numberOfTextBox
        {
            get { return NumberOfTextBox; }
            set { NumberOfTextBox = value; }
        }       
    }
    // 9 Лабораторная работа
    public class Project9
    {
        Random random = new Random();

        private string SomeString; // Строка которая будет дублироваться

        public string somestring
        {
            get { return SomeString; }
            set { SomeString = value; }
        }
        // Форматирование строки (бесконечный источник)
        public string EverSource()
        {
            int num2 = random.Next(SomeString.Length);
            SomeString = SomeString.Insert(num2 + 1, SomeString[num2].ToString());
            return SomeString;
        }
        // Форматирование строки (проклятый источник)
        public string CursedSource()
        {
            int cout = 0;
            int n = 0;
            for (int i = 0; i < SomeString.Length; i++)
            {
                cout++;
            }
            int num = random.Next(n, cout);
            SomeString = SomeString.Remove(num);
            return SomeString;
        }
        //Изменить строку убрав лишние пробелы и поставить первую букву с заглавной буквы 
        public string FormatSomeString()
        {
            while (SomeString.Contains(" "))
            {
                SomeString = SomeString.Replace(" ", "");
            }
            SomeString = SomeString.Substring(0, 1).ToUpper() + (SomeString.Length > 1 ? SomeString.Substring(1) : "");
            return SomeString;
        }
    }
    // 11 Лабораторная работа 
    public class FileReader : Project9
    {
        //Читает файл не меняя его
        public string JustReadFile()
        {
            string path1 = @"C:\Users\fanel\OneDrive\Рабочий стол\Лабораторная работа 11\File.txt";
            StreamReader sr1 = new StreamReader(path1);
            somestring = sr1.ReadToEnd();
            return somestring;
        }
        //Обычное форматирование слова
        public string DefoltReader()
        {           
            string pathToFile = @"C:\Users\fanel\OneDrive\Рабочий стол\Лабораторная работа 11\File.txt";
            somestring = File.ReadAllText(pathToFile);
            somestring = FormatSomeString();
            List<string> stroki = new List<string>();
            string[] readEveryLine = somestring.Split('\n');
            for (int i = 0; i < readEveryLine.Length; i++)
            {
                somestring = readEveryLine[i];
                stroki.Add(FormatSomeString() + "\n");
            }
            somestring = String.Concat<string>(stroki);
            return somestring;      
        }
        //Проклятое форматирование слова
        public string CursedReader()
        {
            string pathToFile = @"C:\Users\fanel\OneDrive\Рабочий стол\Лабораторная работа 11\File.txt";
            somestring = File.ReadAllText(pathToFile);
            somestring = FormatSomeString();
            List<string> stroki = new List<string>();
            string[] readEveryLine = somestring.Split('\n');
            for (int i = 0; i < readEveryLine.Length; i++)
            {
                somestring = readEveryLine[i];
                somestring = FormatSomeString();
                stroki.Add(CursedSource() + "\n");
            }
            somestring = String.Concat<string>(stroki);
            return somestring;
        }
        //Вечное форматирование слова
        public string EverReader()
        {
            string pathToFile = @"C:\Users\fanel\OneDrive\Рабочий стол\Лабораторная работа 11\File.txt";
            somestring = File.ReadAllText(pathToFile);
            somestring = FormatSomeString();
            List<string> stroki = new List<string>();
            string[] readEveryLine = somestring.Split('\n');
            for (int i = 0; i < readEveryLine.Length; i++)
            {
                somestring = readEveryLine[i];
                somestring = FormatSomeString();
                stroki.Add(EverSource() + "\n");
            }
            somestring = String.Concat<string>(stroki);
            return somestring;
        }
        public void WriteInFile(string stroka)
        {
            File.WriteAllText(@"C:\Users\fanel\OneDrive\Рабочий стол\Лабораторная работа 11\File.txt", stroka);
            
        }
    }
}

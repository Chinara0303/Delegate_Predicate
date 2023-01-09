using Delegate_Predicate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Predicate
{
    internal class PracticeDelegate
    {
        #region Predicate
        //public delegate bool CheckNums(int number);
        //public bool CheckNumByOdd(int num) => num % 2 == 0;
        //public bool CheckNumByEven(int num) => num % 2 == 1;
        //public bool CheckNumThanFive(int num) => num > 5;
        public void ShowNumbers()
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var res = SumOfNumbers(CheckNumByEven, numbers);
            //var res = SumOfNumbers(CheckNumByOdd, numbers);
            //var res = SumOfNumbers(CheckNumThanFive, numbers);
            //var res = numbers.FindAll(CheckNumByOdd).Sum();
            //var res = SumOfNumbers(n => n % 2 == 0, numbers);
            //var res = SumOfNumbers(n => n % 2 == 1, numbers);
            //var res = SumOfNumbers(n => n > 5, numbers);
            //Console.WriteLine(res);
        }
        //public int SumOfNumbers(CheckNums func,List<int> numbers)
        //{
        //    int sum = 0;
        //    foreach (int number in numbers)
        //    {
        //        if (func(number))
        //        {
        //            sum += number;
        //        }
        //    }
        //    return sum; 
        //}
        //public int SumOfNumbers(Predicate<int> func, List<int> numbers)
        //{
        //    int sum = 0;
        //    foreach (int number in numbers)
        //    {
        //        if (func(number))
        //        {
        //            sum += number;
        //        }
        //    }
        //    return sum;
        //}
        #endregion

        #region Action
        //public delegate void CheckString(string str);

        //public void StringToUpper(string word)
        //{
        //    Console.WriteLine(word.ToUpper());
        //}
        //public void StringToLower(string word)
        //{
        //    Console.WriteLine(word.ToLower());
        //}
        //public void CheckDelegate()
        //{
        //ShowWord(StringToUpper, "Chinara");
        //ShowWord(StringToLower, "Chinara");
        //CheckString checkString = new CheckString(StringToLower);
        //checkString.Invoke("Chinara");
        //CheckString checkString = delegate (string str)
        //{
        //    Console.WriteLine(str.ToUpper());
        //};
        //checkString("Chinara");
        //Action<string> action = new Action<string>(StringToUpper);
        //Action<string> action = StringToLower;
        //action("Chinara");
        //}
        //public void ShowWord(CheckString func,string word)
        //{
        //   func(word);
        //}
        #endregion

        #region Func
        //public delegate int CheckString(string word, int num);
        //public int GetStringLength(string word, int num)
        //{
        //    return word.Length + num;
        //}

        //public void CheckDelegate()
        //{
        //ShowStringLength(GetStringLength, "Chinara",6);
        //Func<string, int, int> func = GetStringLength;
        //var res = func.Invoke("Chinara", 6);
        //Console.WriteLine(res);
        //}
        //public void ShowStringLength(Func<string, int, int> func, string word, int num)
        //{
        //    Console.WriteLine(func(word, num));
        //}
        #endregion

        public List<Person> GetPeople()
        {

            List<Person> people = new List<Person>();
            people.Add(new Person()
            {
                Name = "Chinara",
                Surname = "Ibadova",
                Salary = 2000,
                Adress = "Goychay"
            });
            people.Add(new Person()
            {
                Name = "Konul",
                Surname = "Ibrahimova",
                Salary = 1500,
                Adress = "Nesimi"
            });
            people.Add(new Person()
            {
                Name = "Cavid",
                Surname = "Ismayilzade",
                Salary = 1850,
                Adress = "Sulutepe"
            });

            return people;
        }

        public List<Person> GetPeopleByFiLteredSalary(Predicate<Person> func,List<Person> people)
        {
            var people1 = GetPeople();
            List<Person> people2 = new();
            foreach (var item in people1)
            {
                if (func(item))
                {
                    people2.Add(item);
                }
            }
            return people2;
        }

        public void ShowPeopleByFiltered()
        {

            var people1 = GetPeople();
            var res = GetPeopleByFiLteredSalary(p => p.Salary > 1000,people1);
            foreach (var item in res)
            {
                Console.WriteLine($"{item.Name} {item.Surname} {item.Adress}");
            }
        }
    }
}

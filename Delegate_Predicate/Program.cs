using Delegate_Predicate;
using Delegate_Predicate.Constants;
using Delegate_Predicate.Models;
using ServicesLayer.Exceptions;

#region Nullable
//string name = null;
//if (name == null)
//{
//    Console.WriteLine("Name is null");
//}
//int? num = null;
//int? n = 10;

//GetPersonById(n);
//static void GetPersonById(int? id)
//{
//    if (id == null)
//    {
//        Console.WriteLine("Notfound");
//    }
//}
#endregion

#region Delegate
PracticeDelegate practiceDelegate = new();
//practiceDelegate.ShowNumbers();
//practiceDelegate.CheckDelegate();
#endregion

#region tryCatch
//try
//{
//    //GetArr();
//    //int n = 10;
//    //int m = 0;
//    //var res = n / m;
//}
////catch (IndexOutOfRangeException ex)
////{
////    Console.WriteLine(ex.Message);
////}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//GetArr();
//static void GetArr()
//{
//    bool isSuccess = false;
//    try
//    {
//        int[] nums = { 1, 2, 3 };
//        nums[1] = 20;
//        isSuccess = true;
//    }
//    catch (IndexOutOfRangeException ex)
//    {
//        Console.WriteLine(ex.Message);
//        isSuccess= false;
//    }
//    finally 
//    {
//        //Console.WriteLine("You can continue");
//        //Console.WriteLine(isSuccess);
//        if (isSuccess)
//        {
//            Console.WriteLine("Success");
//        }
//        else
//        {
//            Console.WriteLine("Wrong");
//        }
//    }
//}
#endregion

#region Factorial

//ededin faktorilalini tapan method yazmaq. Eger menfi eded daxil edilibse custom exception cixarsin. 
//GetFactorial(5);
//static void GetFactorial(int num)
//{
//    try
//    {
//        int multiple = 1;

//        if (num > 0)
//        {
//            for (int i = 1; i <= num; i++)
//            {
//                multiple *= i;
//            }
//            Console.WriteLine(multiple);
//        }
//        else
//        {
//            throw new InvalidNumException(FactorialExceptionMessage.FactMessage);
//        }
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//}
#endregion

//Person
practiceDelegate.ShowPeopleByFiltered();
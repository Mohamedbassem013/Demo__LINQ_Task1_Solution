using Demo__LINQ_Task1;
using System.Text;

internal class Program
{
    //static var print(var x)
    //{
    //    return x;
    //}
    static dynamic print(dynamic x)
    {
        return x;
    }
    private static void Main(string[] args)
    {
        #region C# Keywords Implicitly Type Local Variable [ Var - dynamic ]

        #region Var

        //var Data01 = "Ahmed";
        //Name = 5;

        // compilar will detect Datatype of local variable based on initial value , At Compilation Time
        // must Be initialized
        // Can't initialized Local Variable With Will
        // Can't Change Datatype of the Local Variable After initialized
        // Can't Use Var as Parameter Or ReturnType 

        //var x = 12 ; 

        // var x ; //invalid

        // var x = null;

        //Data01 = 12;

        /*
         var x = 12 ;
         x = "Ahmed";
         x = new object();
         */
        #endregion

        #region Dynamic

       // dynamic Data02 = "Ahmed"; // Like Var in Js

        // CLR detect variable datatype of Local Variable Based On Last Value , At Runtime
        // Don't Need To Be Initialized
        // Can Initialized Local Variable With Null
        // Can Change Datatype of local variable After Initialized
        // Can Use dynamic as parameter or Returntype
        // Be Careful When Using dynamic KeyWord

        //Data02 = 12;
        //Data02 = 'a';
        //Data02 = 1.9;

        //Console.WriteLine(Data02.Gettype.Name());
        //
        //Data02 = 12;
        //
        //Console.WriteLine(Data02.Gettype.Name());

        //dynamic x = null;

        //Console.WriteLine(x);

        #endregion


        #endregion

        #region Extension Method

        //Extension Method

        // int Number = 12345; // 12345
        // 
        // var Result = IntExtension.Reverse(Number);
        // Console.WriteLine(Result);
        // 
        // Number.Reverse();
        // 
        // var x = 12 % 10;

        // Console.WriteLine(x); 
        #endregion

        #region Anonymous Type

        // Anonymous Type

        //Employee Emp01 = new Employee () { Id = 1, Name = "Ahmed", Salary = 12_000 };

         //var Emp01 = new { Id = 1, Name = "Ahmed", Salary = 12_000.0 }; //Anonymous Type
         //var Emp02 = new { Id = 1, Name = 123 , Salary = 12_000.0 }; //Anonymous Type

        //Emp01.Id = 12; // Invalid -- Immutable Type - Can't Change Its Value After Creation

        // var Emp02 = Emp01 with { Id = 12 }; // New feature C# 10.0 --> syntax sugar

        //Console.WriteLine (Emp01.GetType().Name);  //<>__AnonymousType0'3 
        //Console.WriteLine (Emp02.GetType().Name);  //<>__AnonymousType0'3 
        //
        // Console.WriteLine(Emp01);
        // Console.WriteLine(Emp02);

        // The Same Anonymous As Long as :
        // 1. The Property Naming [ Case Sensitive ] 
        // 2. The Property Order
        // 2. The Property Datatype

        //if (Emp01.Equals(Emp02))
        //{
        //    Console.WriteLine("EQUALS");
        //}
        //else
        //{
        //    Console.WriteLine("!EQUALS");
        //}
        //
        #endregion

        #region LINQ Overview

        // LINQ: Language integrated Query 
        //     : +40 Extension Method (LINQ Operators) Using Any Data [ Data in Sequnce ] , Reradless Data store
        //     : 13 Category
        //     : LINQ Operators Exits Class "IEnumerable"

        // sequance : Object From Class Implement Interface "IEnumerable"
        // 1. Local  Sequance : L2O , L2XML
        // 2. Remote Sequance : L2EF

        // Input sequance -->  LINQ operators --> output sequance
        // Input sequance -->  LINQ operators --> one value
        //                -->  LINQ operators --> output sequance

        //List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
        // var Result = Enumerable.Where(Numbers, n => n % 2 == 0);
        //
        //foreach (int item in Result)
        //{
        //    Console.WriteLine(item + " ");
        //}


        #endregion

        #region LINQ Syntax

        // LINQ Syntax

        // 1. Fluent Syntax
        // Use LINQ Method
        // 1.1 LINQ operators As => Class Member method through Class "Enumerable"


        // 1.2 use LINQ operators as => Extension method

        // List<int> Numbers = new List<int> { 9, 8,7, 6, 5, 1 , 2, 3,4 };

        // where

        // LINQ operators As =>  Extension Method through Sequance [Recommended]

        // var Result = Enumerable.Where(Numbers, n => n % 2 == 0);

        //foreach (int item in Result)
        //{
        //    Console.WriteLine(item + " " );
        //}


        // 2. Query Syntax : [Query Expression] Like SQL Style
        // Start With From
        // end With Select or Group by 
        // Query Syntax Easier Than Fluent [ Join , Qroup by , Let , into]

        //ist<int> Numbers = new List<int> { 9, 8, 7, 6, 5, 1, 2, 3, 4 };
        //var Result = from N in Numbers
        //             where N % 2 == 0 
        //             select N;
        //
        //  foreach (int item in Result)
        //  {
        //      Console.WriteLine(item + " " );
        //  }

        /*
         * select N
         * from Numbers N
         * where N % 2 ==1
         */

        #endregion

        #region LINQ Execution Ways

        // LINQ Execution Ways
        // 1. defierd Execution Ways : 10 category
        // 2. Immediate Execution Ways : 3 category [Element Operators - Casting Operators - Aggregate Operators]

        //ist<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //ar Result = numbers.Where(N => N % 2 == 1); // Where is Differed
        //
        //umbers.AddRange(new int[] { 10 , 11, 12 });
        //
        //foreach (int item in Result) // here
        //{
        //    Console.WriteLine(item);
        //
        //}


        //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //var Result = numbers.Where(N => N % 2 == 1).ToList(); // Where is Differed // here
        //
        //numbers.AddRange(new int[] { 10, 11, 12 });
        //
        //foreach (int item in Result)
        //{
        //    Console.WriteLine(item);
        //
        //}



        #endregion

        #region Data Setup

       //Console.WriteLine(ListGenerator.ProductsList[0]);
       //Console.WriteLine(ListGenerator.CustomersList[0]);

        #endregion


    }
}
using System;

namespace MethodsFun
{
    /*ovreloading: method having the same name but different signature
    */
    class Program
    {
        static void Main(string[] args)
        {
            var total = new Calculator();
            var t = total.Add(new int[] { 1, 2, 3, 34, 5, 5, 5, 5 });
            //    var total = Calculator.Add(1,2,3,5);
            Console.WriteLine($"total: {t}");

            // ref

            var ref1 = new RefModifier();
            var a = 1;
            ref1.Modify(ref a);
            // ideally without ref value should be 1 .  as a a premitive type and not a refernce type....   
            Console.WriteLine($"RefModifier: {a}");



            /** 
             out is also the same , but return value different value    

             one case to use out modifier

             int num = int.Parse("abc");
                    => thorugh System.Number.ThrowOverflowOrFormatException
             Console.WriteLine($"num:{num}");

             there are two ways solve the Program , 
                    1) use try and catch
                    2) using out modifer
            */

            int number1;
            
            bool isNum = int.TryParse("abc", out number1);
            if (isNum)
                System.Console.WriteLine("is number");
            System.Console.WriteLine("not a number");


        }


    }
}

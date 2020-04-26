namespace MethodsFun
{
    class Calculator
    {
        private int total = 0;
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public static int Add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
        //..... ans so on.


        //so there is a simpler way to to do.. make an array
        //*Keyword 'this' is not valid in a static property, static method, or static field initializer
        public int Add(int[] a)
        {

            for (int i = 0; i < a.Length; i++)
            {
                this.total = this.total + a[i];
            }

            return this.total;
        }

        // ther is other way to do it ..  


        //using params we not need to creat an array ,, ....   
        public int Add1(params int[] a)
        {

            for (int i = 0; i < a.Length; i++)
            {
                this.total = this.total + a[i];
            }

            return this.total;
        }
    }
}

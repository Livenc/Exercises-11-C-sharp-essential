namespace Exercise_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = MyClass<string>.FactoryMethod();
         
        }
    }
    class MyClass<T>
    {
        public static T FactoryMethod()
        {
            return default(T);
        }





    }

}
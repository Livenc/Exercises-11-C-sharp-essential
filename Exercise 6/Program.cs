using System.Collections;

namespace Exercise_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ArrayList arrayList= new ArrayList();
           arrayList.Add(1);
            arrayList.Add("2");
            arrayList.Add(true);
            arrayList.Add(new object());
            arrayList.Add(DateTime.Now);
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            Console.ReadLine();
        }
    }
}
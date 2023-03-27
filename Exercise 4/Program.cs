using System.Collections;

namespace Exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArrayList arrayList = new MyArrayList();   
            arrayList.Add(1);
            arrayList.Add('g');
            arrayList.Add("sds");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i].ToString());

            }
            Console.ReadLine();
        }

    }
    public class MyArrayList
    {
       private object [] _arrayValue = Array.Empty<object> ();

        public object this[int index]
        {
            get
            {
                return _arrayValue[index];
            }
            set
            {
                _arrayValue[index] = value;
            }
        }
        public void Add(object value)
        {
            var arrayTemp = new object[_arrayValue.Length + 1];
            for (int i = 0; i < _arrayValue.Length; i++)
            {
                arrayTemp[i] = _arrayValue[i];
            }
            arrayTemp[_arrayValue.Length] = value;
            _arrayValue = arrayTemp;
        }
        public int Count { get { return _arrayValue.Length; } }

        public void Clear()
        {
            _arrayValue = Array.Empty<object>();
        }
    }
}
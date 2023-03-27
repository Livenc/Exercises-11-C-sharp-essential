namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarCollection<Car> carCollection = new CarCollection<Car>();
            carCollection.Add(new Car("Ferari", 1997));
            carCollection.Add(new Car("Mitsubisi", 2002));
            carCollection.Add(new Car("Lamba", 2011));
            carCollection.Add(new Car("Suzuki", 2003));

            Console.WriteLine(carCollection[1].NameCar + " " + carCollection[1].AgeCar);
            Console.WriteLine(carCollection.Count);
            carCollection.Clear();
            Console.WriteLine(carCollection.Count);

            Console.ReadKey();
        }
    }
    public class Car
    {
       // string nameCar;
        public string NameCar { get; set; }
        public int AgeCar { get; set; }
        public Car(string NameCar, int AgeCar) 
        {
            this.NameCar = NameCar;
            this.AgeCar = AgeCar;
        }
    }
    public class CarCollection<T> where T : Car 
    {
        private T[] _arrayValue = Array.Empty<T>();

        public T this[int index]
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
        public void Add(T value)
        {
            var arrayTemp = new T[_arrayValue.Length + 1];
            for (int i = 0; i < _arrayValue.Length; i++)
            {
                arrayTemp[i] = _arrayValue[i];
            }
            arrayTemp[_arrayValue.Length] = value;
            _arrayValue = arrayTemp;
        }
        public void Clear()
        {
            _arrayValue = Array.Empty<T>();
        }


        public int Count { get { return _arrayValue.Length; } }

    }
}
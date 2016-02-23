namespace Model
{
    public class CarPassport
    {
        // 1. Owner – property, владелец (водитель)
        public Driver Owner { get; set; }

        // 2. Car – readonly property, машина, 
        // задается параметром в конструкторе.
        public Car Car { get; }

        public CarPassport(Car car)
        {
            Car = car;
            Owner = null;
        }
    }
}

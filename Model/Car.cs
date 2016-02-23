using System.Drawing;

namespace Model
{
    public class Car
    {
        // 1. Model – readonly property, имя водителя, 
        // задается параметром в конструкторе
        public string Model { get; }

        // 2. Color – property, цвет машины, по умолчанию синий. 
        // Не использовать строку (тип string), ищите стандартные типы
        public Color Color { get; set; }

        // 3. CarNumber – property, номер машины, setter закрыт для внешнего кода
        public string CarNumber { get; private set; }

        // 4. Category - readonly property, категория транспортного средства 
        // (BCDEF – только одна), задается параметром в конструкторе
        public string Category { get; }

        // 5. CarPassport – readonly property, 
        // создается автоматически при создании машины
        public CarPassport CarPassport { get; }

        public Car(string model, string category)
        {
            Model = model;
            Category = category;
            Color = Color.Blue;
            CarPassport = new CarPassport(this);
        }

        // 6. ChangeOwner – method, закрепляет нового водителя за машиной, 
        // принимает через параметры нового владельца и новый номер машины.
        // Поменять владельца в паспорте.
        // Изменить у владельца машину. Изменить номер мышины
        public void ChangeOwnwer(Driver driver, string newNumber)
        {
            // Если возникнет исключение, то обработать в вызывающем коде
            driver.OwnCar(this);  
            CarPassport.Owner = driver;
            CarNumber = newNumber;
        }
    }
}

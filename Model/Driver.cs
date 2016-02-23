using System;
using Exceptions;
namespace Model
{
    public class Driver
    {
        // LicenceDate - readonly property, дата выдачи прав, 
        // задается параметром в конструкторе
        public DateTime LicenceDate { get; }

        // Name – readonly property, имя водителя, 
        // задается параметром в конструкторе
        public string Name { get; }

        // Experience – calculated property, водительский стаж, 
        // вычисляется из даты получения прав и
        // текущей даты, измеряется в полных годах
        public int Experience
        {
            get
            {
                return (int) (DateTime.Now - LicenceDate).TotalDays / 365;
            }
        }

        // Category – property, категория прав (ABCDEF - может быть несколько)
        public string Category { get; set; }

        // Car – property, машина водителя, setter закрыт для внешнего кода
        public Car Car { get; private set; }

        public Driver(DateTime licenceDate, string name)
        {
            LicenceDate = licenceDate;
            Name = name;
        }

        // OwnCar – method, закрепляет машину за водителем, 
        // принимает закрепляемую машину через параметр.        // Если в правах водителя нет категории машины – выдать исключение
        public void OwnCar(Car car)
        {
            if (Category.Contains(car.Category))
            {
                Car = car;
            }
            else
            {
                throw new MyCustomException("Invalid Category: " +
                                            "Driver " + Name + " has \"" + Category 
                                            + "\" category, " 
                                            + "but " + car.Model + " requires \"" 
                                            + car.Category + "\" category.");
            }
        }
    }
}

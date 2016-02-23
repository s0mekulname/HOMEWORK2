using System;
using System.Drawing;
using Exceptions;
using Model;

namespace MITA.HOMEWORK2
{
    class Program
    {
        static void Main(string[] args)
        {
          try
            {
                // FR001
                // Автосалон должен приобрести (создать объект Car) машину
                // модели Лада категории D, и покрасить ее в баклажановый цвет
                Console.WriteLine("FR001: ");
                Console.WriteLine("Trying to create Lada...");
                var lada = new Car("Lada", "D") {Color = Color.FromArgb(0xFF, 0x2B, 0x0B, 0x30)};

                Console.WriteLine("Lada creation was successfull.");
                Console.WriteLine("Model: " + lada.Model);
                Console.WriteLine("Color: " + lada.Color);
                Console.WriteLine("Category: " + lada.Category);
                Console.WriteLine();

                // FR002 
                // Вывести имя владельца Лады
                Console.WriteLine("FR002: ");
                try
                {
                    Console.WriteLine("Trying to print lada's owner name...");
                    Console.WriteLine(lada.CarPassport.Owner.Name);
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine("Name cannot be printed because owner is not assigned: " 
                        + e.Message + "\n");            
                }
                Console.WriteLine();

                // FR003 
                // Нанять (создать объект Driver) инструктора Вольдемара, дать
                // ему категории BC
                Console.WriteLine("FR003: ");
                Console.WriteLine("Trying to hire Valdemar with \"BC\" qualification...");

                var qwaldate = DateTime.Parse("Jan 1, 2012");
                var valdemar = new Driver(qwaldate, "Valdemar");
                valdemar.Category = "BC";

                Console.WriteLine("Valdemar's hiring was successfull");
                Console.WriteLine("Name: " + valdemar.Name);
                Console.WriteLine("Licence Date: " + valdemar.LicenceDate);
                Console.WriteLine("Experience: " + valdemar.Experience);
                Console.WriteLine("Category: " + valdemar.Category);
                Console.WriteLine();

                // FR004
                // Сменить водителя Лады на Вольдемара с номером о777оо
                Console.WriteLine("FR004: ");
                try
                {
                    Console.WriteLine("Trying to change Lada's owner to Voldemar...");
                    lada.ChangeOwnwer(valdemar, "o777oo");
                    Console.WriteLine("Changing Lada's owner to Vodemar was successfull.");
                    Console.WriteLine("Lada's owner: " + lada.CarPassport.Owner.Name);
                    Console.WriteLine("CarNumber: " + lada.CarNumber);
                    Console.WriteLine("Voldemar's car: " + valdemar.Car.Model);
                }
                catch (MyCustomException e)
                {
                    Console.WriteLine("Something went wrong. " + e.Message +"\n");
                }
                Console.WriteLine();

                // FR005
                // Добавить Вольдемару категорию D и сменить водителя Лады
                // на Вольдемара еще раз
                Console.WriteLine("FR005: ");
                Console.WriteLine("Changing Voldemar's category to \"D\"...");
                valdemar.Category += "D";
                Console.WriteLine("Voldemar's category now is \"" + valdemar.Category + "\"");
                try
                {
                    Console.WriteLine("Trying to change Lada's owner to Voldemar...");
                    lada.ChangeOwnwer(valdemar, "o777oo");
                    Console.WriteLine("Changing Lada's owner to Vodemar was successfull.");
                    Console.WriteLine("Lada's owner: " + lada.CarPassport.Owner.Name);
                    Console.WriteLine("CarNumber: " + lada.CarNumber);
                    Console.WriteLine("Voldemar's car: " + valdemar.Car.Model);
                }
                catch (MyCustomException e)
                {
                    Console.WriteLine("Something went wrong. " + e.Message + "\n");
                }
                Console.WriteLine();

                // FR006
                // Вывести номер машины Вольдемара
                Console.WriteLine("FR006: ");
                try
                {
                    Console.WriteLine("Trying to print Valdemar's car number...");
                    Console.WriteLine("Valdemar's car number is \'" + valdemar.Car.CarNumber +"\'\n");
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine("Valdemar has no car. " + e.Message + "\n");

                }
                Console.WriteLine();

                // FR007
                // Вывести имя владельца Лады
                Console.WriteLine("FR007: ");
                try
                {
                    Console.WriteLine("Trying to print name of the Lada's owner...");
                    Console.WriteLine(lada.CarPassport.Owner.Name);
                }
                catch (NullReferenceException e)
                {
                    
                    Console.WriteLine("Name cannot be printed because owner is not assigned: "
                        + e.Message + "\n");
                }
                Console.WriteLine();

            }

            catch (Exception e)
            {
                Console.WriteLine("Something went wrong. " + e.Message + "\n");
            }

            Console.WriteLine("Press \"Enter\" to close application\n");
            Console.ReadLine();

        }
    }
}

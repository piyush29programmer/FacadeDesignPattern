using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDesignPattern
{
    class CarModel
    {
        public void SetModel()
        {
            Console.WriteLine(" CarModel - SetModel");
        }
    }
    class CarEngine
    {
        public void SetEngine()
        {
            Console.WriteLine(" CarEngine - SetEngine");
        }
    }
    class CarBody
    {
        public void SetBody()
        {
            Console.WriteLine(" CarBody - SetBody");
        }
    }
    class CarAccessories
    {
        public void SetAccessories()
        {
            Console.WriteLine(" CarAccessories - SetAccessories");
        }
    }
    public class CarFacade
    {
        CarModel model;
        CarEngine engine;
        CarBody body;
        CarAccessories accessories;

        public CarFacade()
        {
            model = new CarModel();
            engine = new CarEngine();
            body = new CarBody();
            accessories = new CarAccessories();
        }

        public void CreateCompleteCar()
        {
            Console.WriteLine("******** Creating a Car **********\n");
            model.SetModel();
            engine.SetEngine();
            body.SetBody();
            accessories.SetAccessories();

            Console.WriteLine("\n******** Car creation complete **********");
        }
    }
    class Example1
    {
        public void RunExample1()
        {
            CarFacade facade = new CarFacade();

            facade.CreateCompleteCar();

            Console.ReadKey();
        }
    }
}

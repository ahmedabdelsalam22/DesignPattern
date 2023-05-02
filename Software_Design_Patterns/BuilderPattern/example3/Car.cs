using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_Design_Patterns.BuilderPattern.example3
{
    internal class Car : IBuilder
    {
        private String brandName;
        private Product product;

        public Car(String brand)
        {
            brandName = brand;
            product = new Product();
        }

        public void StartUpOperations()
        {
            product.Add($"Car Model Name is {brandName}");
        }
        public void BuildBody()
        {
            product.Add("Body of the car is added");
        }
        public void InsertWheels()
        {
            product.Add("Wheels of the car are inserted");
        }
        public void AddHeadLights()
        {
            product.Add("HeadLights of the car are added");
        }
        public void EndOperations()
        {
            /**/
        }
        
     
        public Product GetVehicle()
        {
            return product;
        }









    }
}

using System.Drawing;

namespace ObjectOrientedProgrammingExercises
{
    public enum CarModel
    {
        Volvo,
        Saab
    }

    public class Car
    {
        //4
        public CarModel Model { get => model; set => model = value; } //Visar lite short hand så ni vet om
        public double Price 
        {
            get 
            {
                return price;    
            }
            set 
            {
                price = value;
            }
        }
        public Color Color 
        {
            get { return color; }
            set { color = value; }
        }
        
        private CarModel model;
        private double price;
        private Color color;
        //5
        public Car() { } // new Car(); refererar hit för att anropets argument matchar parametrarna
        public Car(CarModel model, double price, Color color) // new Car(CarModel.Volvo, 30000, Color.Red); refererar hit för att anropets argument matchar parametrarna
        {
            
            this.model = model;
            this.price = price;
            this.color = color;
        }
        
        //6
        public void HalfPrice()
        {
            price = price / 2;
        }
    }
}
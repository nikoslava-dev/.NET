namespace CommonPractises.ClassRecordStruct
{
    public class MainStruct
    {
        public void RunProcess()
        {
            Car c1;

            // c1's data
            c1.Brand = "Bugatti";
            c1.Model = "Bugatti Veyron EB 16.4";
            c1.Color = "Gray";

            // Displaying the values
            Console.WriteLine("Name of brand: " + c1.Brand
                              + "\nModel name: " + c1.Model
                              + "\nColor of car: " + c1.Color);

            c1.Details("ssssss", "dddddddd", "aaaaaaa");
        }
    }

    public struct Car
    {

        // Declaring different data types
        public string Brand;
        public string Model;
        public string Color;

        public void Details(string brand, string model, string color)
        {
            Brand = brand;
            Model = model;
            Color = color;

            Console.WriteLine("Name of brand: " + brand
                              + "\nModel name: " + model
                              + "\nColor of car: " + color);
        }
    }
}

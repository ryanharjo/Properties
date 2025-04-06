namespace Properties_Harjo_Ryan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(); // Creating the first instance of the Car class
                                 // Setting the 'Make' and 'Model' properties for the first car   
            car.Make = "Nissan"; 
            car.Model = "Skyline 2000GT-R";
            // Printing the 'Make' and 'Model' of the first car to the console
            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}");

            Car car2 = new Car();// Creating the second instance of the Car class
                                 // Setting the 'Make' and 'Model' properties for the second car
            car2.Make = "BMW";
            car2.Model = "M3 E30";
            // Printing the 'Make' and 'Model' of the second car to the console
            Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}");
        }
    }
}

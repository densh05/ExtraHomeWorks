using SingleTon;

class Program
{
    static void Main()
    {
        SingleCar car1 = SingleCar.GetSingleCar();
        SingleCar car2 = SingleCar.GetSingleCar();
        SingleCar car3 = SingleCar.GetSingleCar();
        SingleCar car4 = SingleCar.GetSingleCar();

        Console.WriteLine(car1.GetHashCode());
        Console.WriteLine(car2.GetHashCode());
        Console.WriteLine(car3.GetHashCode());
        Console.WriteLine(car4.GetHashCode());
    }

}

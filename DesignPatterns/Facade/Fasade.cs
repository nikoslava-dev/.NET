namespace DesignPatterns.Facade
{
    public class Fasade
    {
        public Car GetCar(CarConfig conf)
        {
            BrandService brandService = new BrandService();
            ColorService colorService = new ColorService();
            ModelService modelService = new ModelService();

            Car car = new Car();
            car.Brand = brandService.Get(conf.Brand);
            car.Model = modelService.Get(conf.Model);
            car.Color = colorService.Get(conf.Color);

            return car;
        }

        public Car GetBike(BikeConfig conf)
        {
            BrandService brandService = new BrandService();
            ColorService colorService = new ColorService();
            ModelService modelService = new ModelService();
            BikeTypeService bikeTypeService = new BikeTypeService();

            Bike bike = new Bike();
            bike.Brand = brandService.Get(conf.Brand);
            bike.Model = modelService.Get(conf.Model);
            bike.Color = colorService.Get(conf.Color);
            bike.BikeType = bikeTypeService.Get(conf.BikeType);

            return bike;
        }
    }
}

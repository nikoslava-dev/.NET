namespace DesignPatterns.Facade
{
    public interface IService<Tin, Tout>
    {
        Tout Get(Tin type);
    }

    public class BrandService : IService<BrandTypes, IBrand>
    {
        public IBrand Get(BrandTypes type)
        {
            switch (type)
            {
                case BrandTypes.Volvo:
                    return new VolvoBrand();
                    break;
                case BrandTypes.BMW:
                    return new BMWBrand();
                    break;
                case BrandTypes.Seat:
                    return new SeatBrand();
                    break;
                case BrandTypes.Suzuki:
                default:
                    return new SuzukiBrand();
            }
        }
    }

    public class ModelService : IService<ModelTypes, IModel>
    {
        public IModel Get(ModelTypes type)
        {
            switch (type)
            {
                case ModelTypes.T80:
                    return new VolvoModel();
                    break;
                case ModelTypes.Ibiza:
                    return new SeatModel();
                    break;
                case ModelTypes.Cross:
                default:
                    return new SuzukiModel();
            }
        }
    }

    public class ColorService : IService<ColorTypes, IColor>
    {
        public IColor Get(ColorTypes type)
        {
            switch (type)
            {
                case ColorTypes.Red:
                    return new RedColor();
                    break;
                case ColorTypes.Blue:
                    return new BlueColor();
                    break;
                case ColorTypes.Brown:
                    return new BrownColor();
                    break;
                default:
                case ColorTypes.Green:
                    return new GreenColor();
                    break;
            }
        }
    }

    public class BikeTypeService : IService<BikeTypes, IBikeType>
    {
        public IBikeType Get(BikeTypes type)
        {
            switch (type)
            {
                case BikeTypes.Mountain:
                    return new MountainBike();
                    break;
                case BikeTypes.Street:
                    return new StreetBike();
                    break;
                case BikeTypes.Sport:
                    return new SportBike();
                    break;
                case BikeTypes.Extreme:
                default:
                    return new ExtremeBike();
                    break;
            }
        }
    }
}

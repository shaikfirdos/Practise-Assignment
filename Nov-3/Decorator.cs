using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Suzuki();
            CarDecorator decorator = new OfferPrice(car);

            Console.WriteLine(string.Format("Make:{0} Price:{1}" + "DiscountPrice:{2}", decorator.Make, decorator.GetPrice().ToString(), decorator.GetDiscounteredPrice().ToString()));
            Console.ReadLine();
        }
    }
    public interface ICar
    {
        string Make { get; }
        double GetPrice();
    }
    public sealed class Suzuki : ICar
    {
        public string Make
        {
            get { return "HatchBack"; }
        }
        public double GetPrice()
        {
            return 800000;
        }
    }
    public abstract class CarDecorator : ICar
    {
        private ICar car;
        public CarDecorator(ICar Car)
        {
            car = Car;
        }
        public String Make { get { return car.Make; } }
        public double GetPrice()
        {
            return car.GetPrice();
        }
        public abstract double GetDiscounteredPrice();
    }

    public class OfferPrice : CarDecorator
    {
        public OfferPrice(ICar car) : base(car)
        {

        }
        public override double GetDiscounteredPrice()
        {
            return .8 * base.GetPrice();
        }
    }

}

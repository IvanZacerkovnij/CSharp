using System.Runtime.CompilerServices;

namespace homework3;

class Program
{
    class Product
    {
        private string name;
        private double price;
        private int count;
        
        public int getCount(){ return count; }
        public double getPrice() { return price; }
        
        public void setCount(int value) { count = value; }
        public void setPrice(double value) { price = value; }
        public Product(string name, double price, int count)
        {
            this.name = name;
            this.price = price;
            this.count = count;
        }

        public static Product operator +(Product a ,int add)
        {
            if (add < 0)
            {
                Console.WriteLine("You cant add negative count!");
                return a;
            }
            a.count += add;
            return a;
        }
        public static Product operator -(Product a, int sub)
        {
            if (sub < 0)
            {
                Console.WriteLine("You cant substract negative count!");
                return a;
            }
            if (a.count < sub)
            {
                Console.WriteLine("Not enough products");
                return a;
            }
            a.count -= sub;
            return a;
            
        }

        public static bool operator ==(Product a, Product b)
        {
            return (a.price == b.price)?true:false;
        }
        public static bool operator !=(Product a, Product b)
        {
            return (a.price != b.price)?true:false;
        }

        public static bool operator <(Product a, Product b)
        {
            return (a.count < b.count)?true:false;
        }
        public static bool operator >(Product a, Product b)
        {
            return (a.count > b.count)?true:false;
        }
    }
    class TemperatureArray
    {
        private float[] tempetures = new float[7];

        public float this[int day]
        {
            get
            {
                if (day < 0 || day > tempetures.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return tempetures[day];
            }
            set
            {
                if (day < 0 || day > tempetures.Length)
                {
                    throw new ArgumentOutOfRangeException();
                }

                tempetures[day] = value;
            }
        }

        public float averageTemperature()
        {
            float sum = 0;
            for (int i = 0; i < tempetures.Length; i++)
                sum += tempetures[i];
            return sum / tempetures.Length;
        }
    }

    static void task1()
    {
        TemperatureArray temp = new TemperatureArray();
        temp[0] = 2.2f;
        temp[1] = 3.1f;
        Console.WriteLine($"The temperature in monday was: {temp[0]} C°");
        Console.WriteLine($"The avarege temperature by weak was: {temp.averageTemperature()} C°");
    }

    static void task2()
    {
        Product cookies = new Product("Maria", 3.99, 1);
        Product candies = new Product("Romashka", 0.99, 5);

        cookies += 2;
        
        Console.WriteLine($"The count of cookies is: {cookies.getCount()}");
        
        Console.WriteLine($"Is first have more count of second?: {candies < cookies}");
        Console.WriteLine($"Compare price of products: {candies != cookies}");
        
    }

    static void Main(string[] args)
    {
        task1();
        task2();
    }

}
using Homework8.Animals;
using Homework8.task2;
using Homework8.task2.Products;

namespace Homework8;

class Program
{
    static void Main(string[] args)
    {
        {
            //task1
            Oceanarium oceanarium = new Oceanarium("MyOceanarium");
            oceanarium.AddAnimal(new Shark("Dorri", 15));
            oceanarium.AddAnimal(new Dolphins("Derry", 7));
            oceanarium.AddAnimal(new Turtle("Todd", 95));
            
            oceanarium.ShownAnimals();
        }
        {
            //task2
            Shop shop = new Shop();
            shop.AddCategory<Book>("Books");
            shop.AddProduct("Books", new Book("It", 5.99, "Steven King"));
            shop.AddCategory<Electronic>("Electronics");
            shop.AddProduct("Electronics", new Electronic("Iphone 17", 1000));
            
            shop.ShowCategories();
            shop.ShowProductsPriceBetween(0,1500);
            shop.ShowProductAddedLastMonth();
        }
    }
}
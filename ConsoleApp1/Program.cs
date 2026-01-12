using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1;


class Program
{
    
    static void Main(string[] args)
    {
        Shop kopiechka = new Shop("Kopiechka");
        
        kopiechka.AddProduct(new Product("Maria",2.99));
        kopiechka.AddProduct(new Product("Jerry",2.99));
        kopiechka.AddProduct(new Product("Lays",6.99));

        foreach (var product in kopiechka)
        {
            Console.WriteLine(product);
        }
    }
}
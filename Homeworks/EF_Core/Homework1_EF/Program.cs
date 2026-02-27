using Homework1.Context;
using Homework1.Manager;

namespace Homework1;

class Program
{
    
    static void Main(string[] args)
    {
        using (var manager = new ShopDBManger(new ShopDBContext()))
        {
            manager.CreateCategory();
            manager.CreateProduct();
            manager.CreateProduct();
            manager.CreateProduct();
            manager.CreateProduct();
            
            manager.UpdateProductName();
            manager.UpdateProductQuantity();
            manager.ShowProductsOutOfStock();
            manager.RemoveProduct();
            manager.ShowTop3MostExpensiveProducts();
        }
    }
}
using MetalBake;
using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for StockService
/// </summary>
public class StockService :IStockService
{
    public StockService()
    {
        public Dictionary<string, int> productsStock = new Dictionary<string, int>()
        {
            {"B",40 },
            {"M",36 },
            {"C",24 },
            {"W",3 }

        };
    Products products = new Products();
    public void CheckStock(string[] itemId)
    {
        foreach (var item in itemId)
        {
            if (productsStock[item] <= 0)
            {
                Console.WriteLine($"Not enough stock of {products.productsNames[item]}");
                break;//Uso exit para parar aplicacion
            }
            else
            {
                productsStock[item]--;
            }
        }

    }
    public void ShowStock(string[] itemId)
    {
        foreach (var item in itemId)
        {
            Console.WriteLine($@"{products.productsNames[item]}  ||  {productsStock[item]}");
        }
    }
}

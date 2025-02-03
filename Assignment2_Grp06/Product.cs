using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Grp06
{
    public class Product
    {
        public int ProdID;
        public string ProdName;
        public int ItemPrice;
        public int StockAmount;

        Product(int ProdID, string ProdName, int ItemPrice, int StockAmount)
        {
            this.ProdID = ProdID;
            this.ProdName = ProdName;
            this.ItemPrice = ItemPrice;
            this.StockAmount = StockAmount;
        }

        public void IncreaseInStock(int Amount)
        {
            if (Amount != null && Amount > 0  )
            {
                StockAmount += Amount;
            }
            else
            {
                Console.WriteLine("Invalid Amount");
            }
        }

        public void DecreaseInStock(int Amount)
        {
            if (Amount != null && Amount > 0 && Amount <= StockAmount)
            {
                StockAmount -= Amount;
            }
            else
            {
                Console.WriteLine("Invalid Amount");
            }
        }

    }
}

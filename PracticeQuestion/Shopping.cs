using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestion
{
    public class Shopping
    {
        int prod_id;
        string prod_name;
        int price;
        int qty;
        int bill;

        public void AcceptDetail(int prod_d, string prod_name, int price, int qty)
        {
            this.prod_id = prod_d;
            this.prod_name = prod_name;
            this.price = price;
            this.qty = qty;
        }
        public void CalculateBill()
        {
            if (qty > 0)
            {
                bill = qty * price;
                ShowDeatils();
            }
            else
            {
                Console.WriteLine("Quantity must more than zero");
            }
        }
        public void ShowDeatils()
        {
            Console.WriteLine($"Product id:{prod_id} \nProduct Name:{prod_name} \nPrice:{price} \nQuantity:{qty} \nBill:{bill}");
        }

        static void Main(string[] args)
        {
            Shopping sh = new Shopping();
            sh.AcceptDetail(1, "Laptop", 30000, 2);
            sh.CalculateBill();
        }
    }
}

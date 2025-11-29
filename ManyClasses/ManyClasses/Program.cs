using System;
using System.Text;
using System.Threading.Tasks;

namespace ManyClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Products mersedes = new Products();
            mersedes.SetName("Мерседес");
            mersedes.SetPrice(1000000);
            Products uaz = new Products();
            uaz.SetName("Уаз");
            uaz.SetPrice(10000000);
            Storage storage = new Storage();
            storage.SetId(123);
            storage.SetLocation("Торжок, улица Студенская 3");
            storage.SetProductQuantity(mersedes, 2);
            storage.SetProductQuantity(uaz, 5);

            storage.GetProductQuantity();
            storage.CalculateMoney();

            Report report = new Report();
            ReportRaw row1 = new ReportRaw();
            row1.Products = "блаблаблаблала";
            row1.Quantity = 100;
            row1.Price = 5000;
            ReportRaw row2 = new ReportRaw();
            row2.Products = "укукккуукуккукукуку";
            row2.Quantity = 100;
            row2.Price = 100000;

            report.AddRecord(row1);
            report.AddRecord(row2);
            report.ToString();
        }
    }
}

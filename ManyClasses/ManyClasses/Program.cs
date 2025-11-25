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

        }
    }
}

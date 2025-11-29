using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClasses
{
    internal class Report
    {
        private List<ReportRaw> rows_ = new List<ReportRaw>();

        public void AddRecord (ReportRaw row)
        {
            rows_.Add(row);
        }
        static string ConvertRowToString(ReportRaw row)
        {
            return row.Products + "," + row.Quantity + "," + row.Price;
        }

        public void ToString(List<ReportRaw> rows)
        {
            foreach(ReportRaw row in rows)
            {
                Console.WriteLine(ConvertRowToString(row));
            }
        }
    }
}

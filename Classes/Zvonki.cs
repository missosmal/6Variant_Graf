using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Variant_Graf.Classes
{
    public class Zvonki
    {
        public int Id { get; set; }
        public string Number_phone { get; set; }
        public string Category_zvonkov { get; set; }
        public string Date { get; set; }
        public string Time_of_start { get; set; }
        public string Time_of_end { get; set; }

        public  Zvonki(int Id, string Number_phone, string Category_zvonkov, string Date, string Time_of_start, string Time_of_end)
        {
            this.Id = Id;
            this.Number_phone = Number_phone;
            this.Category_zvonkov = Number_phone;
            this.Date = Date;
            this.Time_of_start = Time_of_start;
            this.Time_of_end = Time_of_end;
        }
    }
}

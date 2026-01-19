using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Napominalka
{
    public class TaskItem
    {
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Date.ToShortDateString()} {Time.ToShortTimeString()} - {Description}";
        }


    }

}

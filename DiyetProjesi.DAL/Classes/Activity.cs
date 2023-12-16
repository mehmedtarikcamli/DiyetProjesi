using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProjesi.DAL.Classes
{
    public class Activity
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int CalariesPerMinute { get; set; }

        public virtual List<DailyActivity> DailyActivities { get; set; } = new();

        public override string ToString()
        {
            return Name;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public enum eStatus { Empty, dontStart,active,finish }//לא התחילה=1 2=פעילה 3=גמרה 

    public class Group
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public eStatus Status { get; set; }//לא התחילה=1 2=פעילה 3=גמרה

        public virtual ICollection<ChaptersTehilimToRead> ChaptersTehilimToReads { get; set; }
    }
}

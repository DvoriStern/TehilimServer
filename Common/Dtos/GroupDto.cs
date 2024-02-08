using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public enum eStatus { Empty, dontStart, active, finish }//לא התחילה=1 2=פעילה 3=גמרה 

    public class GroupDto
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public eStatus Status { get; set; }//לא התחילה=1 2=פעילה 3=גמרה
        //כל פעם שאני יוצרת קבוצה אני יוצרת לה רשימת פרקים לקריאה- 38 רשומות
       // public virtual ICollection<ChaptersTehilimToReadDto> ChaptersTehilimToReads { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class ChaptersOfTehilim
    {
        public int Id { get; set; }
        public string NameOfChapters { get; set; } = "";

        public string? Content { get; set; } //לבדוק מה לעשות עם ממשק לפרקי תהילים
        public virtual ICollection<ChaptersTehilimToRead> ChaptersTehilimToReads { get; set; }
    }
}

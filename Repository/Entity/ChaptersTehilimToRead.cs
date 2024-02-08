using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class ChaptersTehilimToRead
    {
        public int Id { get; set; }
        public int ChaptersOfTehilimId { get; set; }
        [ForeignKey("ChaptersOfTehilimId")]
        public virtual ChaptersOfTehilim ChaptersOfTehilim { get; set; }

        public int GroupId { get; set; }
        [ForeignKey ("GroupId")]
        public virtual Group Group { get; set; }
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }


    }
}

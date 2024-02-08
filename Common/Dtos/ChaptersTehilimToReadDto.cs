
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class ChaptersTehilimToReadDto
    {
        public int Id { get; set; }
        public int ChaptersOfTehilimId { get; set; }
        public int GroupId { get; set; }
        public int UserId { get; set; }
    }
}

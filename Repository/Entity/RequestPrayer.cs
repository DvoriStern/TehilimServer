using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class RequestPrayer
    {
        public int Id { get; set; }
        public string Content { get; set; } = "";//נוסח הבקשה
        public virtual ICollection<NameForPrayer> NameforPrayers { get; set; }
    }
}

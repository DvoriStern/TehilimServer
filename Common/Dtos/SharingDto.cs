
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public enum eKind { Empty, StorySalvation, Strengthening }//סיפור ישועה=1  חיזוק=2

    public class SharingDto
    {
        public int Id { get; set; }
        public string Content { get; set; } = "";//תוכן השיתוף
        public eKind Kind { get; set; }//סיפור ישועה=1  חיזוק=2
        public bool IsApproval { get; set; }//=0אושר ע"י המנהל=1 לא אושר
        public DateTime Date { get; set; }//תאריך העלאה
        public int Responses { get; set; }//מס' תגובות
        public int UserId { get; set; }

    }
}

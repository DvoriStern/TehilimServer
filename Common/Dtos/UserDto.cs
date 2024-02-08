
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public enum eRank { Empty, Manager, User }//2-user 1-manager

    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; }
        public bool IsActive { get; set; }//לא פעיל בסבב-0 פעיל בסבב-1
        public eRank Rank { get; set; }//2-user 1-manager

    }
}

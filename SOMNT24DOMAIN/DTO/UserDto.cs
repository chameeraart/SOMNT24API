using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMNT24DOMAIN.DTO
{
    public class UserDto
    {
        public string JWT { get; set; }
        public int? UserID { get; set; }
        public DateTime JwtValidFrom { get; set; }
        public DateTime JwtValidTo { get; set; }
        public string TokenType { get; set; }

        public string username { get; set; }

        public string userrole { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMNT24DOMAIN.Common
{
    public class SessionManager
    {
        public static byte[] salt
        {
            get
            {
                return System.Text.Encoding.ASCII.GetBytes("2TiJ4=[Tk-3`~C%5+;b{QryBKOT6?6{gl;HPyhH SC4XFI2,>eC{GC-/s|F AW1R");
            }
        }

        public static string Audiance
        {
            get
            {
                return "taskmanagement";
            }
        }

        public static string Issuer
        {
            get
            {
                return "com.taskmanagement";
            }
        }
    }

    }

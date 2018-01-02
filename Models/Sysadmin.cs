using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    [Serializable]    
    public class Sysadmin
    {
        public int SysadminID { get; set; }
        public string SysadminName { get; set; }
        public int SysadminPassword { get; set; }
    }
}

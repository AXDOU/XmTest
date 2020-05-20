
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace XmTest.Basic.DTO
{
    public class Pprice
    {
        /// <summary>
        /// 
        /// </summary>
        public string cprice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string onetime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string cycle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pmothod { get; set; }
    }

    public class Pconfig
    {
        /// <summary>
        /// 
        /// </summary>
        public string Connections { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string WebSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string MsSqlSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string MySqlSize { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DomainSum { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string productid { get; set; }
    }

    public class Psconfig
    {
        /// <summary>
        /// 
        /// </summary>
        public string time_cycle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string nastock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pricedes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string trial_hours { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string referralrate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string servicestatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string buylimit { get; set; }
    }

    public class Dto
    {
        /// <summary>
        /// 
        /// </summary>
        public string pid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pgid { get; set; }
        /// <summary>
        /// 全能虚拟主机400
        /// </summary>
        public string pname { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pstock { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pdes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string phidden { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Pprice pprice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Pconfig pconfig { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string pupgrade { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Psconfig psconfig { get; set; }
    }

    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        public Dto dto { get; set; }
    }
}
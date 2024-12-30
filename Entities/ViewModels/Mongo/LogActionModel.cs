using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ViewModels.Mongo
{
    public class LogActionModel
    {
        public string _id { get; set; }
        public long LogId { get; set; }
        public string Log { get; set; }
        public string Note { get; set; }
        public string CreatedUserName { get; set; }
        public int Type { get; set; }
        public DateTime CreatedTime { get; set; }


    }
}

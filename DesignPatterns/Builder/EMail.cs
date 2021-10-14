using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class EMail
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Content { get; set; }

        protected EMail() 
        { 
        }

        public static EMailBuilder New() => new EMailBuilder(new EMail());

        
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    /*
    public class EMailBuilder
    {
        private readonly EMail eMail;

        public EMailBuilder(EMail eMail) 
        { 
            this.eMail = eMail;
        }

        public EMailBuilder From(string from) 
        { 
            this.eMail.From = from;
            return this;
        }

        public EMailBuilder To(string to) 
        { 
            this.eMail.To = to;
            return this;
        }

        public EMailBuilder Content(string content) 
        { 
            this.eMail.Content = content;
            return this;
        }
        
        public static implicit operator EMail(EMailBuilder builder) 
        { 
            return builder.eMail;
        }
    }
    */
}

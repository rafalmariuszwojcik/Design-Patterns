using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class EMail
    {
        public string From { get; private set; }
        public string To { get; private set; }
        public string Content { get; private set; }
        public string Cc { get; private set; }
        public string Bcc { get; private set; }

        private EMail() 
        { 
        }

        public static EMailBuilder New() => new EMailBuilder(new EMail());

        public class EMailBuilder
        {
            private EMailAdditionalRecipientsBuilder eMailAdditionalRecipientsBuilder;

            protected readonly EMail eMail;

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

            public EMailAdditionalRecipientsBuilder AdditionalRecipients
            {
                get 
                {
                    if (eMailAdditionalRecipientsBuilder == null) 
                    {
                        eMailAdditionalRecipientsBuilder = new EMailAdditionalRecipientsBuilder(eMail);
                    }
                    
                    return eMailAdditionalRecipientsBuilder;
                }
            }

            public static implicit operator EMail(EMailBuilder builder)
            {
                return builder.eMail;
            }
        }

        public class EMailAdditionalRecipientsBuilder : EMailBuilder
        {
            public EMailAdditionalRecipientsBuilder(EMail eMail)
                : base(eMail)
            {
            }

            public EMailAdditionalRecipientsBuilder Cc(string cc) 
            {
                this.eMail.Cc = cc;
                return this;
            }

            public EMailAdditionalRecipientsBuilder Bcc(string bcc)
            {
                this.eMail.Bcc = bcc;
                return this;
            }
        }
    }
}

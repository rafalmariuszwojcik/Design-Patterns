using DesignPatterns.Builder;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternsTests
{
    public class BuilderTests
    {
        [Test]
        public void AAA() 
        {
            EMail eMail = EMail.New()
                .AdditionalRecipients.Cc("cc")
                .From("rw@soloplan.de")
                .To("it@soloplan.de")
                .Content("AAAAA")
                .AdditionalRecipients.Bcc("bcc");

            Assert.AreEqual("rw@soloplan.de", eMail.From);
            Assert.AreEqual("it@soloplan.de", eMail.To);
            Assert.AreEqual("AAAAA", eMail.Content);
            Assert.AreEqual("cc", eMail.Cc);
            Assert.AreEqual("bcc", eMail.Bcc);
        }
    }
}

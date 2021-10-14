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
            EMail eMail = EMail.New().From("rw@soloplan.de").To("it@soloplan.de").Content("AAAAA");
            Assert.AreEqual("rw@soloplan.de", eMail.From);
            Assert.AreEqual("it@soloplan.de", eMail.To);
            Assert.AreEqual("AAAAA", eMail.Content);
        }
    }
}

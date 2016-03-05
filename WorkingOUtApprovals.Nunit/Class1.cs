using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;

namespace WorkingOutApprovals.Nunit
{
    [TestFixture]
    public class Class1
    {
        [Test]
        [UseReporter(typeof(ClipboardReporter))]
  //  [UseReporter(typeof(DiffReporter))]
        public void LineEndingsTest()
        {      
           Approvals.Verify("Jee" + "\n"+"\t"+"r");
        }
    }
}

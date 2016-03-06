using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApprovalTests;
using ApprovalTests.Reporters;
using ApprovalTests.WinForms;
using NUnit.Framework;

namespace WorkingOutApprovals.Nunit
{
    [TestFixture]
    [UseReporter(typeof(ClipboardReporter))]
    public class MiscTestsOnNunit
    {
        [Test]

  //      [UseReporter(typeof(DiffReporter))]
        public void LineEndingsTest()
        {      
          Approvals.Verify("Jee" + "\n"+"\t"+"r");         
        }

        [Test]
        public void XmlTest()
        {
            String xml = @"<config><diagnostics><path>C:\temp</path>
            <proxy usedefault=""true""/></diagnostics></config>";
            ApprovalTests.Approvals.VerifyXml(xml);              
        }

        [Test]
        public void RandomTest()
        {
            var s = Approvals.GetDefaultNamer();
            Console.WriteLine("This is it: "+ s);
            
        }

    }
}

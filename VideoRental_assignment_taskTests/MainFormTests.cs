using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoRental_assignment_task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoRental_assignment_task.Tests
{
    [TestClass()]
    public class MainFormTests
    {
        [TestMethod()]
        public void MainFormTest()
        {
            Logic logic = new Logic();
            logic.CmdIns("insert into customerField (Name,Phone,Address)values('ok','789456','NZ')");
            Assert.IsTrue(true);

        }
        [TestMethod()]
        public void MainFormTest2()
        {
            Logic logic = new Logic();
            logic.CmdIns("delete from customerField where ID=1");
            Assert.IsTrue(true);

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project1.Data;
using Xunit;

namespace Tests.Integration
{
    public class Class1
    {
        [Fact]
        public void TestMethod()
        {
            TestClass testClass = new TestClass();
            testClass.Test();
            Assert.True(true);
        }
    }
}

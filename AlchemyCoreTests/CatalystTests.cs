using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using AlchemyCore;

namespace AlchemyCoreTests
{
    public class CatalystTests
    {
        [Fact]
        public void CatalystTestConstructor_Name()
        {
            Catalyst catalyst = new Catalyst("Heat");
            Assert.IsType<Catalyst>(catalyst);
            Assert.Equal("Heat", catalyst.Name);
        }
    }
}

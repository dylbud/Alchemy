using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using AlchemyCore;

namespace AlchemyCoreTests
{
    public class ElementTests
    { 
        [Fact]
        public void ElementTestNameConstructor()
        {
            Element element = new Element("Gold");
            Assert.IsType<Element>(element);
            Assert.NotEmpty(element.Name);
            Assert.NotNull(element.Name);
            Assert.Equal("Gold", element.Name);
        }

        [Fact]
        public void ElementTest_IsEqual()
        {
            Element gold = new Element("Gold");
            Element goldCopy = new Element("Gold");
            Assert.True(gold.Equals(goldCopy));
        }

        [Fact]
        public void ElementTest_Combine()
        {
            Element earth = new Element("Earth");
            Element water = new Element("Water");
            Element clay = new Element("Clay");

            Element element = earth.Combine(water);
            Assert.True(element.Equals(clay));

        }
        

    }
}

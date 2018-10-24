using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using AlchemyCore;
using System.Linq;

namespace AlchemyCoreTests
{
    public class CrucibleTests
    {
        [Fact]
        public void CrucibleConstructor_ElementElement()
        {
            Element element1 = new Element("Gold");
            Element element2 = new Element("Silver");
            Crucible crucible = new Crucible(element1, element2);
            Assert.IsType<Crucible>(crucible);
        }



        [Fact]
        public void CrucibleTests_Synthesize()
        {

            Element earth = new Element("Earth");
            Element water = new Element("Water");
            Element clay = new Element("Clay");

            Crucible crucible = new Crucible(earth, water);

            Element element = crucible.Yield;

            Assert.True(element.Equals(clay));
        }
    }
}

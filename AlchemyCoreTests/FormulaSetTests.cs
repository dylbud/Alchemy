using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using AlchemyCore;
using System.Data;



namespace AlchemyCoreTests
{
    public class FormulaSetTests
    {
        [Fact]
        public void FormulaSetTestGetData()
        {
            DataTable formulae = FormulaSet.Get();
            string valueAtRow1Col1 = formulae.Rows[0]["Element1"].ToString();
            Assert.Equal("Fire", valueAtRow1Col1);


            Assert.Equal(-1, "alpha".CompareTo("Beta"));
        }
    }
}

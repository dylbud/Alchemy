using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace AlchemyCore
{
    public class Crucible
    {
        public Element Element1 { get; set; }

        public Element Element2 { get; set; }

        /// <summary>
        /// The element yielded from the crucible
        /// </summary>
        private Element yield;

        private readonly DataTable formulae = FormulaSet.Get();

        /// <summary>
        /// Initializes a new instance of the Crucible class
        /// </summary>
        public Crucible(Element element1, Element element2)
        {
            if (element1.Name.CompareTo(element2.Name) == 1)
            {
                Element temp = element1;
                element1 = element2;
                element2 = temp;
            }
            Element1 = element1;
            Element2 = element2;
        }
        
        public Element Yield
        {
            get
            {
                Synthesize();
                return yield;
            }
        }

        private void Synthesize()
        {
            foreach (DataRow dataRow in formulae.Rows)
            {
                if (Element1.Name == dataRow["Element1"].ToString())
                {
                    if (Element2.Name == dataRow["Element2"].ToString())
                    {
                        yield = new Element(dataRow["Yield"].ToString());
                    }
                }
            }
        }


    }
}

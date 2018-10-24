using System;
using System.Collections.Generic;
using System.Text;

namespace AlchemyCore
{
    public class Element
    {
        /// <summary>
        /// The Name of the Element.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Initializes a new instance of the Element class.
        /// </summary>
        public Element(string name)
        {
            Name = name;
        }

        public Element Combine(Element element)
        {
            Crucible crucible = new Crucible(this, element);
            return crucible.Yield;
            
        }

        public bool Equals(Element element)
        {
            if (element.Name == this.Name)
            {
                return true;
            }
            return false;
        }

    }
}
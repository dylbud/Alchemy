using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Data;

namespace AlchemyCore
{
    public static class FormulaSet
    {
        private static readonly DataTable formulas = new DataTable("Formulas");

        public static DataTable Get()
        { 
            return formulas;
        }

        private static void AddColumns()
        {
            formulas.Columns.Add("Element1");
            formulas.Columns.Add("Element2");
            formulas.Columns.Add("Yield");
        }

        static FormulaSet()
        {
            AddColumns();
            AddPrimaryKey();
            PopulateTable();
        }

        private static void Add(string e1, string e2, string yield)
        {
            if (e1.CompareTo(e2) == 1)
            {
                string temp = e1;
                e1 = e2;
                e2 = temp;
            }
            try
            {
                formulas.Rows.Add(e1, e2, yield);
            }
            catch
            {
                // at this point, we simply don't insert the row
            }
        }

        private static void AddPrimaryKey()
        {
            DataColumn[] keyColumns = new DataColumn[2];
            DataColumn column1 = formulas.Columns[0];
            DataColumn column2 = formulas.Columns[1];

            keyColumns[0] = column1;
            keyColumns[1] = column2;

            // Set the PrimaryKeys property to the array.
            formulas.PrimaryKey = keyColumns;

        }

        private static void PopulateTable()
        {
            Add("Fire", "Water", "Steam");
            Add("Earth", "Air", "Dust");
            Add("Earth", "Water", "Clay");
            Add("Fire", "Air", "Wind");
            }

    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Data;
using System.IO;

namespace Diagrammorama
{
    public class PrnReader
    {
        public List<string> WhatsMyName = new List<string>();
        public string _dp;
        DataTable tabi = new DataTable();
        public int tb;
        public PrnReader()
        {
        }
        public DataTable Tabelle()
        {
            DataTable result = new DataTable();
            string[] lineArray = File.ReadAllLines(_dp);
            char[] seperatingChars = { ' ', '#' };
            string[] columns = lineArray[0].Split(seperatingChars, StringSplitOptions.RemoveEmptyEntries);
            foreach (string columnName in columns)
            {
                WhatsMyName.Add(columnName + " tb" + tb);
                result.Columns.Add(new DataColumn(columnName + " tb" + tb, typeof(double)));
            }

            for (int i = 1; i < lineArray.Length; i++)
            {
                string[] values = lineArray[i].Split(seperatingChars, StringSplitOptions.RemoveEmptyEntries);
                DataRow dr = result.NewRow();
                for (int j = 0; j < values.Length; j++)
                {
                    dr[j] = Convert.ToDouble(values[j], CultureInfo.InvariantCulture);
                }
                result.Rows.Add(dr);
            }
            tabi.Merge(result);
            return tabi;
        }
    }
}

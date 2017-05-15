using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.IO;

namespace Diagrammorama
{
    public class PRN_Reader
    {
        private string dp;
        public PRN_Reader(string path)
        {
            dp = path;
        }
        public DataTable Tabelle()
        {
            DataTable result = new DataTable();
            string[] LineArray = File.ReadAllLines(dp);
            char[] seperatingChars = { ' ', '#' };


            string[] columns = LineArray[0].Split(seperatingChars, System.StringSplitOptions.RemoveEmptyEntries);
            foreach (string columnName in columns)
            {
                DataColumn dc = new DataColumn(columnName, typeof(double));
                result.Columns.Add(dc);
            };
            for (int i = 1; i < LineArray.Length; i++)
            {
                string[] values = LineArray[i].Split(seperatingChars, System.StringSplitOptions.RemoveEmptyEntries);
                DataRow dr = result.NewRow();
                for (int j = 0; j < values.Length; j++)
                {
                    dr[j] = Convert.ToDouble(values[j], CultureInfo.InvariantCulture);
                }
                result.Rows.Add(dr);
            }
            return result;
        }
    }
}

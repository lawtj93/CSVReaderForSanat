using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public class CSVData
    {
        public string CName { get; set; }
        public string CAddress { get; set; }
        public string EName { get; set; }
        public string EGender { get; set; }
        public string EType { get; set; }
        public string ESalary { get; set; }
        public string ERate { get; set; }

        public static CSVData FromCsv(string csvLine)
        {
            CSVData CSVData = new CSVData();
            try
            {
                string[] values = csvLine.Split(',');

                CSVData.CName = values[0].ToString();
                CSVData.CAddress = values[1].ToString();
                CSVData.EName = values[2].ToString();
                CSVData.EGender = values[3].ToString();
                CSVData.EType = values[4].ToString();
                CSVData.ESalary = values[5].ToString();
                CSVData.ERate = values[6].ToString();
            }
            catch (Exception ex)
            {
                var s = ex.Message;
            }

            return CSVData;
        }
    }
}

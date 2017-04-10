using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertialNavigationSystem_Demo.Logic
{
    public class CSVFile
    {

        public Dictionary<double, List<double>> Data { get; private set; } = new Dictionary<double, List<double>>();

        public CSVFile(string file, char delimiter)
        {
            using (var fs = File.OpenRead(@file))
            using (var reader = new StreamReader(fs))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(delimiter);
                    List<double> record = new List<double>();
                    foreach (string value in values)
                    {
                        double dataField = double.NaN;
                        if (double.TryParse(value.Replace('.',','), out dataField))
                        {
                            record.Add(dataField);
                        }
                        else
                            break;
                    }

                    if (record.Count > 0)
                    {
                        double time = record.First();
                        record.RemoveAt(0);
                        Data.Add(time, record);
                    }
                }
            }
        }
    }
}

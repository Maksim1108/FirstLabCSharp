using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLab.fileWork
{
    internal class FileWork
    {
        public bool saveOnFile()
        {
            return false;
        }

        public bool loadFromFile(string fileName, out double x1, out double y1, out double x2, out double y2, out double x3, out double y3, out double x4, out double y4)
        {
            x1 = y1 = x2 = y2 = x3 = y3 = x4 = y4 = 0.0;
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line = reader.ReadLine();
                    if (line != null)
                    {
                        string[] coordinates = line.Split(' ');
                        if (coordinates.Length >= 8)
                        {
                            x1 = double.Parse(coordinates[0]);
                            y1 = double.Parse(coordinates[1]);
                            x2 = double.Parse(coordinates[2]);
                            y2 = double.Parse(coordinates[3]);
                            x3 = double.Parse(coordinates[4]);
                            y3 = double.Parse(coordinates[5]);
                            x4 = double.Parse(coordinates[6]);
                            y4 = double.Parse(coordinates[7]);
                        }
                        Console.WriteLine("\nДанные успешно загружены!");
                        //Console.WriteLine($"{x1},{y1},{x2},{y2},{x3},{y3},{x4},{y4}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при чтении файла: " + ex.Message);
            }

            return false;
        }
    }
}
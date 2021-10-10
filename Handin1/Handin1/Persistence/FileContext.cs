using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Models;

namespace FileData
{
    public class FileContext
    {
        //public IList<Family> Families { get; private set; }
        public IList<Adult> Adults { get; private set; }

        //private readonly string familiesFile = "families.json";
        private readonly string adultsFile = "adults.json";

        public FileContext()
        {
            //Families = File.Exists(familiesFile) ? ReadData<Family>(familiesFile) : new List<Family>();
            Adults = File.Exists(adultsFile) ? ReadData<Adult>(adultsFile) : new List<Adult>();
        }

        private IList<T> ReadData<T>(string s)
        {
            using (var jsonReader = File.OpenText(familiesFile))
            {
                return JsonSerializer.Deserialize<List<T>>(jsonReader.ReadToEnd());
            }
        }

        public void SaveChanges()
        {
            // storing families
            /*string jsonFamilies = JsonSerializer.Serialize(Families, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            using (StreamWriter outputFile = new StreamWriter(familiesFile, false))
            {
                outputFile.Write(jsonFamilies);
            }*/

            // storing persons
            string jsonAdults = JsonSerializer.Serialize(Adults, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            using (StreamWriter outputFile = new StreamWriter(adultsFile, false))
            {
                outputFile.Write(jsonAdults);
            }
        }

        public void AddAdult(Adult adult)
        {
            int nextId = Adults.Max(a => adult.Id);
            adult.Id = ++nextId;
            Adults.Add(adult);
            SaveChanges();
        }

        public void EditAdult(Adult adult)
        {
            Adult e = Adults.First(a => a.Id == adult.Id);
            e.FirstName = adult.FirstName;
            e.LastName = adult.LastName;
            e.Age = adult.Age;
            SaveChanges();
        }

        public void RemoveAdult(Adult adult)
        {
            Adult r = Adults.First(a => a.Id == adult.Id);
            Adults.Remove(r);
            SaveChanges();
        }
    }
}
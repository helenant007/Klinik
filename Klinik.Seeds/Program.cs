
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinik.Seeds
{
    class Program
    {
        class Sets
        {
            string[] data = new string[100];

            public Sets()
            {
                data[0] = "Dar";
                data[1] = "Helen";

                for (int i = 2; i < 100; i++)
                    data[i] = "Haha";
            }

            public string FirstOrDefault(Func<string, bool> comparer)
            {
                for (int i = 0; i < 100; i++)
                {
                    if (comparer(data[i]))
                        return data[i];
                }
                return null;
            }
        }

        static void Main(string[] args)
        {
            Klinik.Data.KlinikModelContainer db = new Data.KlinikModelContainer();

            // Si Admin pake column Username
            db.Admins.AddOrUpdate(admin => admin.Username,
                new Data.Admin[]
                {
                    new Data.Admin() { Username = "helen", Pass = "helen" } ,
                    new Data.Admin() { Username = "dar", Pass = "dar" } ,
                    new Data.Admin() { Username = "ranti", Pass = "suster" } ,
                });
            db.SaveChanges();

            // Medicine pake column Name
            db.Medicines.AddOrUpdate(med => med.Name,
                new Data.Medicine[]
                {
                    new Data.Medicine() { Name = "Panadol", Type = "Tablet" }  ,
                    new Data.Medicine() { Name = "Mylanta", Type = "Tablet" }  ,
                    new Data.Medicine() { Name = "Tolak Angin", Type = "Syrup" } ,
                    new Data.Medicine() { Name = "Bioplacenton", Type = "Tube" } ,
                    new Data.Medicine() { Name = "Hansaplast", Type = "Strip" }  ,
                });
            db.SaveChanges();

            // Patient pake column BinusianId
            db.Patients.AddOrUpdate(patient => patient.BinusianId,
                new Data.Patient[]
                {
                    new Data.Patient() { BinusianId = "1801377654", BloodType = "B", Gender = "Male", Name = "Billy Darmawan", Section = "MHS" },
                    new Data.Patient() { BinusianId = "2600112323", BloodType = "B", Gender = "Female", Name = "Erquin", Section = "MHS" },
                    new Data.Patient() { BinusianId = "2020202020", BloodType = "A", Gender = "Female", Name = "Erjini", Section = "MHS" },
                    new Data.Patient() { BinusianId = "1801380333", BloodType = "O", Gender = "Female", Name = "Natanael", Section = "MHS" },
                    new Data.Patient() { BinusianId = "1801483238", BloodType = "AB", Gender = "Male", Name = "Ardhi Wirawan", Section = "MHS" },
                });
            db.SaveChanges();


            Console.ReadLine();
        }
    }
}

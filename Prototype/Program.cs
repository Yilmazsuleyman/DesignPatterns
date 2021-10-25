using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Database mdl = new Database();

            Database db1 = (Database)mdl.Clone();
            db1.Name = "StokTakip";
            db1.AddTable("Stoklar");
            Console.WriteLine(db1.Name);
            db1.TableList();

            Database db2 = (Database)mdl.Clone();
            db2.Name = "CRM";
            db2.AddTable("Musteriler");
            Console.WriteLine(db2.Name);
            db2.TableList();
        }
    }
}

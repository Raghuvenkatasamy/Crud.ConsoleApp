using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DapperDataAccessLayer;

namespace MobileDetails.ConsoleApp
{
    class MenuDriven
    {
        IMobileDetailsRepository _MDtl;
        public MenuDriven()
        {
            _MDtl = new MobileDetailsRepository();
        }

        public void MobileDetails()
        {


            int a;
            do
            {
                Console.WriteLine("1-->InsertSP");
                Console.WriteLine("2-->UpdateSP");
                Console.WriteLine("3-->DeleteSP");
                Console.WriteLine("4-->ReadSP");
                Console.WriteLine("Enter the number:");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:

                        MobileDetail _md = new MobileDetail();

                        Console.WriteLine("Enter the Name:");
                        _md.Name = Console.ReadLine();
                        Console.WriteLine("Enter the ManufactureName:");
                        _md.ManufactureName = Console.ReadLine();
                        Console.WriteLine("Enter the DateofMaufacture (dd/mm/yyyy):");
                        _md.DateofMaufacture = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Enter the YearofMaufacture (yyyy):");
                        _md.YearofMaufacture= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Quantity (yyyy):");
                        _md.Quantity= Convert.ToInt32(Console.ReadLine());

                        _MDtl.InsertSP(_md);


                        break;
                    case 2:
                        Console.WriteLine("Enter the record number that you want to update");
                        long b = Convert.ToInt32(Console.ReadLine());


                        MobileDetail _up = new MobileDetail();

                        Console.WriteLine("Enter the Name:");
                        _up.Name = Console.ReadLine();
                        Console.WriteLine("Enter the ManufactureName:");
                        _up.ManufactureName = Console.ReadLine();
                        Console.WriteLine("Enter the DateofMaufacture (MM/dd/yyyy):");
                        _up.DateofMaufacture = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Enter the YearofMaufacture (yyyy):");
                        _up.YearofMaufacture = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Quantity (yyyy):");
                        _up.Quantity = Convert.ToInt32(Console.ReadLine());

                        _MDtl.UpdateSP(b, _up);
                        break;
                    case 3:
                        Console.WriteLine("Enter the record number that you want to delete");
                        int c = Convert.ToInt32(Console.ReadLine());

                        _MDtl.DeleteRecordSP(c);


                        var record = _MDtl.ReadSP();
                        if (record == null)
                        {
                            Console.WriteLine("Invalid Number");
                            break;

                        }
                        else
                        {
                            Console.WriteLine($"{"MobileID"}\t{"Name"}\t{"ManufactureName"}\t{"DateofMaufacture"}\t{"YearofMaufacture"}\t{"Quantity"}");

                            foreach (var p in record)
                            {
                                Console.WriteLine($"{p.MobileId}\t\t{p.Name}\t\t{p.ManufactureName}\t\t{p.DateofMaufacture.ToString("d")}\t\t{p.YearofMaufacture}\t\t{p.Quantity}");

                            }
                        }
                        break;
                    case 4:
                        var dlt = _MDtl.ReadSP();
                        if (dlt == null)
                        {
                            Console.WriteLine("Invalid Number");
                            break;

                        }
                        else
                        {
                            Console.WriteLine($"{"MobileID"}\t{"Name"}\t{"ManufactureName"}\t{"DateofMaufacture"}\t{"YearofMaufacture"}\t{"Quantity"}");
                            foreach (var p in dlt)
                            {
                                Console.WriteLine($"{p.MobileId}\t{p.Name}\t{p.ManufactureName}\t{p.DateofMaufacture.ToString("d")}\t{p.YearofMaufacture}\t{p.Quantity}");
                            }
                        }
                        break;
                    case 5:
                        break;

                }
            } while (a <= 5);
            Console.WriteLine("Invail Number");

        }

    }
}

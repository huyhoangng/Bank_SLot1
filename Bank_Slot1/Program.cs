using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Slot1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vietnam vietnameseCustomer = new Vietnam();
            Console.WriteLine("Enter Vietnamese Customer Details:");
            Console.Write("Customer ID: ");
            vietnameseCustomer.CustomerID = Console.ReadLine();
            Console.Write("Full Name: ");
            vietnameseCustomer.FullName = Console.ReadLine();
            Console.Write("Invoice Date (yyyy-MM-dd): ");
            vietnameseCustomer.InvoiceDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Customer Type (Sinh hoat/Kinh doanh/San xuat): ");
            vietnameseCustomer.CustomerType = Console.ReadLine();
            Console.Write("Quantity: ");
            vietnameseCustomer.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Unit Price: ");
            vietnameseCustomer.UnitPrice = double.Parse(Console.ReadLine());

            ForeignCustomer foreignCustomer = new ForeignCustomer();
            Console.WriteLine("\nEnter Foreign Customer Details:");
            Console.Write("Customer ID: ");
            foreignCustomer.CustomerID = Console.ReadLine();
            Console.Write("Full Name: ");
            foreignCustomer.FullName = Console.ReadLine();
            Console.Write("Invoice Date (yyyy-MM-dd): ");
            foreignCustomer.InvoiceDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Nationality: ");
            foreignCustomer.Nationality = Console.ReadLine();
            Console.Write("Quantity: ");
            foreignCustomer.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Unit Price: ");
            foreignCustomer.UnitPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("\nVietnamese Customer:");
            Console.WriteLine($"Total Price: {vietnameseCustomer.CalculateTotal()}");

            Console.WriteLine("\nForeign Customer:");
            Console.WriteLine($"Total Price: {foreignCustomer.CalculateTotal()}");

            Console.ReadLine();
        }
    }
}

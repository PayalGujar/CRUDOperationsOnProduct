using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDOperationsOnProduct
{
    public class Program
    {
        static void Main(string[] args)
        {

            int a = 0; 
            ProductImplementation crud= new ProductImplementation();
            do {
                Console.WriteLine("1.Display Product");
                Console.WriteLine("2.Display Product By ID");
                Console.WriteLine("3.Add Product");
                Console.WriteLine("4.Update Product");
                Console.WriteLine("5.Delete Product");
                int choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        List<ProductData> list=crud.GetProducts();
                        foreach(ProductData record in list)
                        {
                            Console.WriteLine($"{record.ID}\t{record.Name}\t{record.Price}\t{record.Company}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter Id of Product which Details you want to Display");
                        int id=Convert.ToInt32(Console.ReadLine());
                        ProductData p=crud.GetProductsByID(id);
                        Console.WriteLine($"{p.ID}\t{p.Name}\t{p.Company}\t{p.Price}");
                        break;
                    case 3:
                        ProductData p1=new ProductData();
                        Console.WriteLine("Enter Product ID");
                        p1.ID=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product Name");
                        p1.Name=Console.ReadLine();
                        Console.WriteLine("Enter Product Price");
                        p1.Price=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product Company");
                        p1.Company=Console.ReadLine();
                        crud.ProductAdd(p1);
                        break;
                    case 4:
                        ProductData p2=new ProductData();
                        Console.WriteLine("Enter ID You want to update");
                        p2.ID=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product Name");
                        p2.Name=Console.ReadLine();
                        Console.WriteLine("Enter Product Price");
                        p2.Price=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Product Company");
                        p2.Company=Console.ReadLine();
                        crud.ProductUpdate(p2);
                        Console.WriteLine("UPDATED");
                        break;
                    case 5:
                        ProductData p3=new ProductData();
                        Console.WriteLine("Enter ID of product you want to Delete");
                        int id1=Convert.ToInt32(Console.ReadLine());
                        crud.ProductDelete(id1);
                        break;
                    
                }
            
                Console.WriteLine("Press 1 To Continue");
                a=Convert.ToInt32(Console.ReadLine());
            }while(a==1);
         }
                
        }
    }



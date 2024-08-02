using product_Management_System;

product_management product_Management = new product_management();
for(int i = 0; i < 3; i++)
{


productinfo productinfo = new productinfo();
Console.WriteLine("enter product name");
productinfo.product_name = Console.ReadLine();

Console.WriteLine("enter product productID");
productinfo.product_ID = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("enter product product cost");
productinfo.product_cost_price = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("enter product sale price");
productinfo.product_sale_price = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("enter product availabal stock");
productinfo.product_availabal_stock = Convert.ToInt32(Console.ReadLine());
product_Management.addproduct(productinfo);
product_Management.removeproduct(productinfo);
}


product_Management.display();
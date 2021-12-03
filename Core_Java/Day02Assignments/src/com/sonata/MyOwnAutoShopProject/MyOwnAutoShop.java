package com.sonata.MyOwnAutoShopProject;

public class MyOwnAutoShop {
	public static void main(String[] args) {
		
		Sedan s = new Sedan(100, 28000, "Violet");
		s.length = 12;
		Ford f1 = new Ford(120, 40000, "Indigo");
		f1.year = 2007;
		f1.manufacturerDiscount=10;
		Ford f2 = new Ford(140, 36000, "Blue");
		f2.year = 2009;
		f2.manufacturerDiscount=8;
		Truck t = new Truck(80, 60000, "Green");
		t.weight = 2300;
		
		s.display();
		f1.display();
		f2.display();
		t.display();
		
	}
}

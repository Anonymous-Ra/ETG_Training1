package com.sonata;

public class Product {

	int prdId;
	String prdName;
	double prdPrice;
	double finalPrice;
	public Product() {
		
	}
	public Product(int id,String name,double price) {
		this.prdId = id;
		this.prdName = name;
		this.prdPrice = price;
	}
	public void display() {
		System.out.println("Product ID :" + prdId);
		System.out.println("Product Name :" + prdName);
		System.out.println("Product Price :" + prdPrice);
		System.out.println("Product Price with GST : " + finalPrice);
	}
	public double calPrice() {
		this.finalPrice = prdPrice + (prdPrice*0.06);
		return prdPrice;
	}
	public static void main(String[] args) {
		Product p1 = new Product(12, "Choco", 112);
		p1.calPrice();
		p1.display();
	}

}

package com.sonata.MyOwnAutoShopProject;

public class Ford extends Car{
	int year;
	double manufacturerDiscount;
	public Ford(int s, double prc, String col) {
		super(s,prc,col);
	}
	public double getsalePrice() {
		double price ;
		double disc = regularPrice*(manufacturerDiscount/100.0);
		price= regularPrice - (disc);
		return price;
	}
	public void display() {
		System.out.println("Ford Details ");
		System.out.println("Ford year : " + year);
		System.out.println("Ford speed : " + speed);
		System.out.println("Ford color : " + color);
		System.out.println("Ford original Price : " + regularPrice);
		System.out.println("Ford SalePrice : " + getsalePrice());
		System.out.println();
	}
}

package com.sonata.MyOwnAutoShopProject;

public class Truck extends Car{
	int weight;
	public Truck(int s, double prc, String col) {
		super(s,prc,col);
	}
	public double getsalePrice() {
		double price ;
		if(weight>2000) {
			 price = regularPrice - (regularPrice*0.1);
		}
		else {
			 price = regularPrice - (regularPrice*0.2);
		}
		return price;
	}
	public void display() {
		System.out.println("Truck Details ");
		System.out.println("Truck weight : " + weight);
		System.out.println("Truck speed : " + speed);
		System.out.println("Truck color : " + color);
		System.out.println("Truck original Price : " + regularPrice);
		System.out.println("Truck SalePrice : " + getsalePrice());
		System.out.println();
	}
}

package com.sonata.MyOwnAutoShopProject;

public class Car {
	int speed;
	double  regularPrice;
	String color;
	public Car(int s, double prc, String col) {
		this.color=col;
		this.regularPrice=prc;
		this.speed=s;
	}
	public double getsalePrice() {
		double price = regularPrice;
		return price;
	}
}

package com.sonata.Shape;

public class Square extends Shape{
	public Square(double Length) {
		// TODO Auto-generated constructor stub
		super(Length);
	}
	//Overriding Method
	public double CalArea() {
		double area =this.l *this.l;
		return area;
	}
	public static void main(String[] args) {
		Square sq = new Square(4);
		System.out.println("Area of Triangle : "+sq.CalArea());
	}
}

package com.sonata.Shape;

public class Rectangle extends Shape {
	public Rectangle( double height, double width) {
		// TODO Auto-generated constructor stub
		super(height,width);
	}
	//Overriding Method
	public double CalArea() {
		double area =this.l *this.w;
		return area;
	}
	public static void main(String[] args) {
		Rectangle rec = new Rectangle(3,4);
		System.out.println("Area of Triangle : "+rec.CalArea());
	}
}

package com.sonata.Employee;


public class Manager extends Employee{
	public Manager() {
		// TODO Auto-generated constructor stub
	}
	public Manager(int i, String j, double k) {
		super(i,j,k);
	}
	//Overridden Method
	public double calSal(double HRA,double DA) {
		double total = super.calSal(HRA, DA) + 10000;
		return total;
	}
	public static void main(String[] args) {
		Manager m1 = new Manager(102, "Manager", 40000);
		m1.display();
		System.out.println("Calculated Salary with Bonus: " + m1.calSal(200, 500));
	}
}

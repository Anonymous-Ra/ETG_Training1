package com.sonata.Employee;

public class Tester extends Employee {
	public Tester() {
		// TODO Auto-generated constructor stub
	}
	public Tester(int i, String j, double k) {
		super(i,j,k);
	}
	//Overridden Method
	public double calSal(double HRA,double DA) {
		double total = super.calSal(HRA, DA) + 2500;
		return total;
	}
	public static void main(String[] args) {
		Tester m1 = new Tester(22, "Tester", 30000);
		m1.display();
		System.out.println("Calculated Salary with Salary : " + m1.calSal(200, 500));
	}
}

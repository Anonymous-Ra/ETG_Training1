package com.sonata.Employee;

public class Developer extends Employee{
	public Developer() {
		// TODO Auto-generated constructor stub
	}
	public Developer(int i, String j, double k) {
		super(i,j,k);
	}
	//Overridden Method
	public double calSal(double HRA,double DA) {
		double total = super.calSal(HRA, DA) + 5000;
		return total;
	}
	public static void main(String[] args) {
		Developer m1 = new Developer(67, "Developer", 60000);
		m1.display();
		System.out.println("Calculated Salary with Bonus: " + m1.calSal(200, 500));
	}
}

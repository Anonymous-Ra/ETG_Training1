package com.sonata.Employee;

public class Employee {
	int empId;
	String empName;
	double empSal;
	public Employee() {
		// TODO Auto-generated constructor stub
	}
	public Employee(int id,String name,double sal) {
		this.empId = id;
		this.empName = name;
		this.empSal = sal;
	}
	public void display() {
		System.out.println("Employee ID :" + empId);
		System.out.println("Employee Name :" + empName);
		System.out.println("Employee Salary :" + empSal);
	}
	public double calSal(double HRA,double DA) {
		double total = this.empSal + HRA + DA;
		return total;
	}
}

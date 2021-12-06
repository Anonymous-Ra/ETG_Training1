package com.sonata.AbstractEmployee;

public class TechnicalEmployee extends Employee{
	
	public double calSal() {
		double total = Employee.basicPay + Employee.basicPay * .12;
		return total;
	}

	@Override
	public String toString() {
		return "TechnicalEmployee [calSal()=" + calSal() + "]";
	}
	
}

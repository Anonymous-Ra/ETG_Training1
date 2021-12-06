package com.sonata.AbstractEmployee;


public class UsingPeople {
	public static void main(String[] args) {
		Employee em = new Employee() {
			
			@Override
			double calSal() {
				// TODO Auto-generated method stub
				return 0;
			}
		};
		em.setBasicPay(2000);
		TechnicalEmployee te = new TechnicalEmployee();
		System.out.println(te);
		Staff st = new Staff();
		System.out.println(st);
	}
	
}

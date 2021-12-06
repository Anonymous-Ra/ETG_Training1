package com.sonata.MyException;


public class CallMyException {
	public static void main(String[] args) throws MyException {
		double empSal = 10009;
		if(empSal<100000) {
			throw new MyException("Your Salary does not the our minimum criteria of 1Lakh.");
		}
		else {
			System.out.println("Welcome to our program.");
		}
	}
}

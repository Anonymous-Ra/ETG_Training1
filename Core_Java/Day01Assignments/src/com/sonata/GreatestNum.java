package com.sonata;

public class GreatestNum {
	public static void main(String[] args) {
		int a = 12;
		int b = 25;
		int c = 89;
		if(a>b && a>c) {
			System.out.println(a +" is the Greatest Number.");
		}
		else if(b>a && b>c){
			System.out.println(b +" is the Greatest Number.");
		}
		else {
			System.out.println(c +" is the Greatest Number.");
		}
	}
}

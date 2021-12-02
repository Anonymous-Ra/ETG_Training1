package com.sonata;

import java.util.Scanner;

public class CubeOfNum {
	public static void main(String[] args) {
		Scanner obj = new Scanner(System.in);
		System.out.println("Enter the number:");
		
		int num = obj.nextInt();
		int cubeOfnum = num*num*num;
		System.out.println("Cube of "+num+" is :"+cubeOfnum);
	}
}

package com.sonata;

public class CheckForElementInArray {
	public static void main(String[] args) {
		int arr[] = {1,2,3,4,5,6};
		int num = 9;
		boolean flag = false;
		for(int i=0;i<arr.length;i++) {
			if(arr[i]==num) {
				flag = true;
			}
		}
		if(flag == true) {
			System.out.println("Element " + num+" is present in the array");
		}
		else {
			System.out.println("Element " + num+" is not present in the array");

		}
	}
}

package com.sonata;

public class ReverseAnArray {
	public static void main(String[] args) {
		int arr[] = {1,2,3,4,5,6};
		for(int i=0;i<arr.length;i++) {
			System.out.print(arr[i]);
		}
		int n = arr.length;
		int j = n;
		int revarr[]= new int[n];
		for(int i=0;i<n;i++) {
			revarr[j-1]=arr[i];
			j = j-1;
		}
		System.out.println("");
		for(int i=0;i<arr.length;i++) {
			System.out.print(revarr[i]);
		}
	}
}

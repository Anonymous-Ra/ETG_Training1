package com.sonata;

public class MaxNumInArray {
	public static void main(String[] args) {
		int arr[] = {1,9,3,4,5,6,2,3,1,2,2};
		
		int maxnum1 = 0;
		
		int maxnum2 = 0;
		for(int i = 1;i<arr.length;i++) {
			int currentnum = arr[i];
			if(currentnum>maxnum1 ) {
				maxnum2 = maxnum1;
				maxnum1 = currentnum;
			}
			else if( maxnum2<currentnum ) {
				maxnum2 = currentnum;
			}
			
		}
		System.out.println(maxnum1);
		System.out.println(maxnum2);
	}
}

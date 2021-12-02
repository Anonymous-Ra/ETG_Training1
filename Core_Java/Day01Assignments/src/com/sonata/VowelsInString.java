package com.sonata;

import java.util.Scanner;

public class VowelsInString {
	public static void main(String[] args) {
		Scanner obj = new Scanner(System.in);
		System.out.println("Enter a String : ");
		String str = obj.nextLine();
		char[] ch = str.toCharArray();
		for(int i = 0; i<ch.length;i++) {
			if(ch[i]=='a'||ch[i]=='e'||ch[i]=='i'||ch[i]=='o'||ch[i]=='u') {
				ch[i] = '$';
			}
		}
		String str1 = new String(ch);
		System.out.println(str1);
	}
}

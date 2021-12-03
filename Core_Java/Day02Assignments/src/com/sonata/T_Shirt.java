package com.sonata;

public class T_Shirt {
	String color;
	String material;
	String design;
	public T_Shirt(String c, String m, String d) {
		this.color=c;
		this.design=d;
		this.material=m;
	}
	public static void main(String[] args) {
		T_Shirt small = new T_Shirt("Red", "Cotton", "V-neck") ;
		T_Shirt large = new T_Shirt("Orange", "Dry-Fit", "Collared") ;
		T_Shirt xl = new T_Shirt("White", "Wool", "Round-neck") ;
	}

}

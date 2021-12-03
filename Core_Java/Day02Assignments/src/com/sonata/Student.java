package com.sonata;

public class Student {

	int stdId ;
	String stdName;
	int stdClass;
	public Student() {
		
	}
	public Student(int id, String name, int clas) {
		this.stdId = id;
		this.stdName = name;
		this.stdClass = clas;
	}
	public void display() {
		System.out.println("Student Name : " +stdName);
		System.out.println("Student ID : " +stdId);
		System.out.println("Student Class : " +stdClass);
		System.out.println(" ");
	}
	public static void main(String[] args) {
		Student s1 = new Student(36,"Name1",2);
		Student s2 = new Student();
		s2.stdId = 63;
		s2.stdClass=4;
		s2.stdName="Name2";
		s1.display();
		s2.display();
	}

}

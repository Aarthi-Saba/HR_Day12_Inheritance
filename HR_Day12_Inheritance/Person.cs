/*
 * Objective
Today, we're delving into Inheritance. Check out the attached tutorial for learning materials and an instructional video!

Task
You are given two classes, Person and Student, where Person is the base class and Student is the derived class.
Completed code for Person and a declaration for Student are provided for you in the editor. Observe that Student inherits all the properties of Person.

Complete the Student class by writing the following:

A Student class constructor, which has  parameters:
A string,firstName .
A string,lastName .
An integer, id.
An integer array (or vector) of test scores, .
A char calculate() method that calculates a Student object's average and returns the grade character representative of their calculated average:
 * */
using System;
using System.Collections.Generic;
using System.Linq;

namespace HR_Day12_Inheritance
{
	class Person
	{
		protected string firstName;
		protected string lastName;
		protected int id;

		public Person() { }
		public Person(string firstName, string lastName, int identification)
		{
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
		}
		public void printPerson()
		{
			Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
		}
	}

	class Student : Person
	{
		private int[] testScores;

		/*	
		*   Class Constructor
		*   
		*   Parameters: 
		*   firstName - A string denoting the Person's first name.
		*   lastName - A string denoting the Person's last name.
		*   id - An integer denoting the Person's ID number.
		*   scores - An array of integers denoting the Person's test scores.
		*/
		// Write your constructor here
		public Student(string fName,string lName,int idnum,int[] scores)
		{
			this.firstName = fName;
			this.lastName = lName;
			this.id = idnum;
			testScores = scores;
		}

		/*	
		*   Method Name: Calculate
		*   Return: A character denoting the grade.
		*/
		// Write your method here
		public char Calculate()
		{
			char grade = 'I';
			int average = testScores.Sum() / testScores.Length;
			if(average < 40)
			{
				grade = 'T';
			}
			else if(average < 55 && average >= 40)
			{
				grade = 'D';
			}
			else if(average < 70 && average >= 55)
			{
				grade = 'P';
			}
			else if(average < 80 && average >= 70)
			{
				grade = 'A';
			}
			else if(average < 90 && average >= 80)
			{
				grade = 'E';
			}
			else if(average <=100 && average >= 90)
			{
				grade = 'O';
			}
			return grade;
		}
	}

	class Solution
	{
		static void Main()
		{
			string[] inputs = Console.ReadLine().Split();
			string firstName = inputs[0];
			string lastName = inputs[1];
			int id = Convert.ToInt32(inputs[2]);
			int numScores = Convert.ToInt32(Console.ReadLine());
			inputs = Console.ReadLine().Split();
			int[] scores = new int[numScores];
			for (int i = 0; i < numScores; i++)
			{
				scores[i] = Convert.ToInt32(inputs[i]);
			}

			Student s = new Student(firstName, lastName, id, scores);
			s.printPerson();
			Console.WriteLine("Grade: " + s.Calculate() + "\n");
		}
	}
}

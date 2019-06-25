using System;

namespace Lab1
{
    public class Student
    {
        private string name;
        private string id;
        private int yearOfStudy;

        public Student(string name, string id)
        {
            this.name = name;
            this.id = id; 
            this.yearOfStudy = 0;
        }
            
        public string getName()
        {
            
            return name;
        }

        public string getId()
        {
            //TODO: write code here
            return id;
        }

        public int getYearOfStudy()
        {
            //TODO: write code here
            return yearOfStudy;
        }


        public void incrementYearOfStudy()
        {
            yearOfStudy ++; 
        }
    }
}

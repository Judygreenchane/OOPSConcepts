using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    internal class Person                                // 3.1 Question 1
    {
        private int age;
        private string fName = string.Empty;
        private string lName = string.Empty;
        private double height;
        private double weight;

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                    age = value;
                else
                    throw new ArgumentException("Enter a value greater than zero");
            }
        }
        public string FName
        {
            get { return fName; }
            set
            {
                if ((value.Length >= 2) && (value.Length <= 10))
                    fName = value;
                else
                    throw new ArgumentException("First name should contain minimum 2 and maximum 10 characters ");
            }
        }

        public string LName
        {
            get { return lName; }
            set
            {
                if ((value.Length >= 3) && (value.Length <= 15))
                    lName = value;
                else
                    throw new ArgumentException("First name should contain minimum 3 and maximum 15 characters ");
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                height = value;

            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                weight = value;

            }
        }
    }
    }

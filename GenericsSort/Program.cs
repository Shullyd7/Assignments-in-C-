using System;
using System.Collections.Generic;

namespace GenericsSort
{
    /*
    This is a Person Class
     It contains some attributes of class 'Person'
     This Class should inherit IComparable<Person> and so as to implement public int CompareTo(Person person) method.
     */
    /// <summary>
    /// This is the main <c>Person</c> Class.
    /// It contains some attributes of class 'Person'
    /// This Class should inherit IComparable Person and so as to implement public int CompareTo(Person person) method
    /// </summary>
    public class Person : IComparable<Person>{

        //Attributes of Person
        
        private string name;
        private int age;

        //This method will sort the members of the list based on the name in Person List using the default comparer that is being implemented 
        /// <summary>
        /// This method will sort the members of the list based on the name in Person List using the default comparer that is being implemented
        /// </summary>
        public int CompareTo(Person person)

        {

            return this.Name.CompareTo(person.Name);

        }
    
        //Getters and Setters Method for the Attributes
        /// <summary>
        /// Getters and Setters Method for the name Attribute
        /// </summary>
        /// <value>
        /// gets and sets the name attribute
        /// </value>
        public string Name{
            get{
                return name;
                }
            set{
                name = value;
            }
        }

        /// <summary>
        /// Getters and Setters Method for the age Attribute
        /// </summary>
        /// <value>
        /// gets and sets the age attribute
        /// </value>
        public int Age{
            get{
                return age;
                }
            set{
                age = value;
            }
        } 
        

        static void Main(string[] args)
        {
            //Person Generic List creation
            List<Person> personlist1 = new List<Person>();

            //Creating Objects of class 'Person' and adding it to the Person List
            Person person1 = new Person();
            person1.name = "Isaac";
            person1.age = 30;
            personlist1.Add(person1);

            Person person2 = new Person();
            person2.name = "Eric";
            person2.age = 25;
            personlist1.Add(person2);

            Person person3 = new Person();
            person3.name = "Adam";
            person3.age = 40;
            personlist1.Add(person3);

            Person person4 = new Person();
            person4.name = "Lisa";
            person4.age = 29;
            personlist1.Add(person4);

            Person person5 = new Person();
            person5.name = "Ruth";
            person5.age = 15;
            personlist1.Add(person5);
            
            //calling the Generic List Sort Method
            personlist1.Sort();

            foreach (Person person in personlist1)

            {

                Console.WriteLine(person.Name + " " + person.Age);

            }
        }
    }
}

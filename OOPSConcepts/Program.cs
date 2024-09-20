using System;

namespace OOPSConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();


            p.FName = "Judy";       // We cannot access private field fName in Class Person.But we can  set value to it through this public property FName.
            //Console.WriteLine(p.FName); // Here we are retreiving value from private field fName through Public property FName . So we have direct  access to public property .
            // This is encapsulation and protecting the fields from direct acccess.


            PersonHandler personHandler = new PersonHandler();
            try
            {

                Person p1 = personHandler.CreatePerson(30, "Judy", "Green", 160.80, 56.8);      // 3.1 Question 5
                Person p3 = personHandler.CreatePerson(35, "Nini", "Jos", 140.87, 66.8);
                Person p4 = personHandler.CreatePerson(40, "Rini", "Jewel", 170.40, 59.3);
                Person p5 = personHandler.CreatePerson(45, "Binu", "Tomas", 150.80, 66.4);
            }
            catch
            {
                Console.WriteLine("Enter correct values");
            }

            try
            {
                personHandler.SetAge(p, 0);
                //p.Age = 0;                               // 3.1 Question 1
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


            try                                              // 3.1 Question 1
            {

                p.FName = "J";
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }



            try                                                    // 3.1 Question 1
            {
                p.LName = "Jg";
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


            List<UserError> list = new List<UserError>();    // 3.2 Question 7
            NumericInputError numericInputError1 = new NumericInputError();
            list.Add(numericInputError1);
            NumericInputError numericInputError2 = new NumericInputError();
            list.Add(numericInputError2);

            TextInputError textInputError1 = new TextInputError();
            list.Add(textInputError1);
            TextInputError textInputError2 = new TextInputError();
            list.Add(textInputError2);

            CustomClass1 customClass1 = new CustomClass1();     // 3.2 Question 10
            list.Add(customClass1);

            CustomClass2 customClass2 = new CustomClass2();
            list.Add(customClass2);

            CustomClass3 customClass3 = new CustomClass3();
            list.Add(customClass3);


            foreach (UserError error in list)                // 3.2 Question 8
            {
                Console.WriteLine(error.UEMessage());
            }



            Dog dog = new Dog();
            dog.DoSound();
            Horse horse = new Horse();
            horse.DoSound();
            Hedgehog hedgehog = new Hedgehog();
            hedgehog.DoSound();
            Worm worm = new Worm();
            worm.DoSound();
            Bird bird = new Bird();
            bird.DoSound();
            Wolf wolf = new Wolf();
            wolf.DoSound();


            Wolfman wolfman = new Wolfman();
            wolfman.Talk();

            List<Animal> animals = new List<Animal>();   //Question 3
            Wolf w = new Wolf();                          //Question 4                       
            animals.Add(w);
            Horse h = new Horse();
            animals.Add(h);
            Hedgehog hH = new Hedgehog();
            animals.Add(hH);

            Wolfman wolfman1 = new Wolfman();
            animals.Add(wolfman1);

            string animalName = string.Empty;
            foreach (Animal animal in animals)
            {
                animalName = animal.GetType().ToString().Split('.')[1];
           
               
                Console.WriteLine($"Animal is {animalName}");   //Question 5: Printing which animals are in the list.
                animal.DoSound();                //  Question 6: Call animals sound() method


                try                               // Question 7 :  If animal is of type IPerson,executing Talk method.
                {
                    ((IPerson)animal).Talk();
                }
                catch {
                    
                }

               
            }


            List<Dog> dogs = new List<Dog>(); //Question 8 : Created list of Dogs
            Dog dog1 = new Dog();
            dogs.Add(dog1);
            Dog dog4 = new Dog();
            dogs.Add(dog4);
            Horse horse1 = new Horse();
            // dogs.Add(horse1);                //Question 9 We cannot add a horse to dogs list since these two are two differnt types.

            //Question 10 If we need to store all classes together we have to have an animal list which is the base for all classes. 

            //Question 11 Below is the answer for "print all animals stats() through a foreach loop"
            // Question 12 : I tested and see the control flow. 
            //Question 13 According to the type of  animal , it will execute that particular animal class's stats method.
            // For example ,if it is worm,sats method in the worm class will execute.


            List<Animal> animals1 = new List<Animal>();
            Wolf w1 = new Wolf();
            animals1.Add(w);
            Horse h1 = new Horse();
            animals1.Add(h);
            Hedgehog hH1 = new Hedgehog();
            animals1.Add(hH);
            Bird bird1 = new Bird();
            animals1.Add(bird1);
            Dog dog2 = new Dog();
            animals1.Add(dog2);
            Worm worm1 = new Worm();
            animals1.Add(worm1);
            Dog dog3 = new Dog();
            animals1.Add(dog3);

            foreach (Animal animal in animals1)
            {
              Console.WriteLine ( animal.Stats());
            }

            //Question 14  Here(below) is answer for Printing Stats method only for dogs.
            Console.WriteLine("");
            Console.WriteLine("Only displaying Stats method for Dogs from the given list of animals");
            foreach (Animal animal in animals1)
            {
                if (animal.GetType().ToString().Split('.')[1] == "Dog")
                {
                    Console.WriteLine(animal.Stats());
                    Console.WriteLine(((Dog)animal).OptionalMethod());      //Question 18: Here Dog's optional method is printing only for dogs
                }
                //Question 16 & 17
                //We cannot access Dog class's optional method from this  animal list since it only exists in Dog (subclass)
                //not in the base class animal. Stats method will work since it gets overrided in all animal subclass and it exists in animal class
                //by using virtual keyword. 
            }
        }
    }
}

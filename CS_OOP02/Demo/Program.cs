using Demo.Binding;

namespace Demo
{
    internal class Program
    {

        #region Overloading
        //overloading
        public static void Sum(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static void Sum(double x, int y)
        {
            Console.WriteLine(x + y);
        }
        public static void Sum(int x, double y)
        {
            Console.WriteLine(x + y);
        }
        public static void Sum(double x, double y)
        {
            Console.WriteLine(x + y);
        }
        #endregion

        public static void EmployeeProccess(FullTimeEmployee employee)
        {
            if (employee == null) return;
            employee.Fun01();
            employee.Fun02();
        }
        public static void EmployeeProccess(PartTimeEmployee employee)
        {
            if (employee == null) return;
            employee.Fun01();
            employee.Fun02();
        }
        static void Main(string[] args)
        {

            #region Inheritance
            //Inheritance : 

            //Parent parent = new Parent(1, 2);
            ////Console.WriteLine(parent);
            //parent.Fun1();
            //parent.Fun2();

            //Child child = new Child(1, 2, 3);
            //child.Fun1();
            //child.Fun2();
            #endregion

            #region Polymorphism
            // Polymorphism
            //  1. Polymorphism Method (Function) Overloading
            //  2. Polymorphism Method (Function) Overriding

            //Console.WriteLine(int);
            //Console.WriteLine(string);
            //Console.WriteLine(double); -> 17 overloads

            //  1. Polymorphism Method (Function) Overloading
            // There are more than one function in the same scope [class - struct]
            // these have the same name but with different signature
            // (count - type - order) parameter

            //Sum(1, 2);
            //Sum(1.6, 2);
            //Sum(1, 2.8);
            //Sum(1.6, 2.5);


            //  1. Polymorphism Method (Function) Overloading
            // There are more than one function in [different class]
            // these have the same name with same signature but different body [behaviour]

            //TypeB typeB = new TypeB() { A = 12, B = 13 }; //object initializer
            ////typeB.A = 12;
            ////typeB.B = 13;
            //typeB.Fun01();
            //typeB.Fun02(); 
            #endregion

            #region Binding
            //// Binding 
            //// Refernece from Parent ---> Object from Child

            //TypeA obj = new TypeB();

            //obj.A = 1;
            //obj.Fun01(); // Static Binding Method
            //obj.Fun02(); // Dynamic Binding Method 


            //TypeA obj = new TypeA();
            //obj = new TypeB(); // Binding

            // Child is a parent
            // Animal -> Dog : Dog is an Animal
            // Dog -> (Dog) Animal 

            //TypeA Ref = new TypeA();
            //Ref = new TypeB();

            //TypeB typeB = (TypeB)Ref;

            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            //{
            //    Id = 1,
            //    Name = "Ahmed",
            //    Address = "Cairo",
            //    Email = "ahmed@gmai.com",
            //    salary = 20000
            //};
            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Id = 1,
            //    Name = "Ahmed",
            //    Address = "Cairo",
            //    Email = "ahmed@gmai.com",
            //    NumberOfHoure = 50,
            //    HoureRate = 200
            //};

            //EmployeeProccess(fullTimeEmployee);
            //EmployeeProccess(partTimeEmployee);

            TypeA typeA;

            typeA = new TypeA();
            typeA = new TypeB(); //binding
            typeA = new TypeC(); //binding
            typeA = new TypeD(); //binding

            typeA.A = 12;
            //typeA.B // Invalid

            typeA.Fun01(); // Type A                    // Static
            typeA.Fun02(); //  A: 12, B: 0, C: 0, D: 0  // Dynamic


            #endregion

            #region Task02

            //Task 02

            // private protected:
            //      member is accessible by types derived(inherited class) from the containing class,
            //      but only within its containing assembly file(namespace)

            // protected internal:
            //      member is accessible from the current assembly
            //      or from types that are derived from the containing class

            #endregion
        }
    }
}

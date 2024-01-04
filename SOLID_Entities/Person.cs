using System;

namespace SOLID_Entities
{
    public class Person
    {



        public int ID { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public DateTime Birthdate { get; set; }

        public int LifeExpectancy { get; } = 0;

    }
}


// Public class Bird { Fly() , Eat()  }

// public class Canary : Bird 

// public class Ostrich : Bird {Fly (Error)}

// Bird (Eat ())

// FlyingBird : Bird (Fly())

// Canary : Flyingbird

// Ostrich : Bird

//-------------------------------

// یک کلاس داریم با این 3 متد
// این کلاس و سناریو را با اصول سالید طراحی کنید

// Task : OrderService (عملیات مربوط به سفارش)

           // Verify Order ()
           // Save Order ()
           // Send Notification ()

//------------------------------------
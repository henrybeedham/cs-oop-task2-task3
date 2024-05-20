using System;

class Program
{
    static void Main()
    {
        // Here is your empty program!
        Console.WriteLine("Hello world!");

        Animal animal = new Animal("animal",0);

        Console.WriteLine($"{animal.GetState()} is of size {animal.GetSize()}");

        while (animal.GetState().Equals(animal.GetState().ToLower(), StringComparison.Ordinal)) {
            animal.Feed();
            Console.WriteLine(animal.GetState());
        }
    }
}

class Animal {
    private string state;
    private int size;
    public Animal (string s, int n) {
        state = s;
        size = n;
    }

    public void Feed() {
        size++;
        if (size >= 5) {
            state = state.ToUpper();
        }
    }

    public string GetState() {
        return state;
    }

    public int GetSize() {
        return size;
    }
}

// 	Animal = CLASS
// 	   Public
// 	      Constructor (s, n)
// 	      Procedure feed()
// 	      Function getState()
// 	      Function getSize()
// 	   Private
// 	      state: String 
// 	      size: Integer
	 
// 	Animal.Constructor (s, n)
// 	   Animal.state  s
// 	   Animal.size  n
 
// 	Procedure Animal.feed()
// 	   Animal.size  Animal.size + 1
// 	   IF Animal.size = 5 THEN
// 	      Animal.state  "FISH"
	 
// 	Function Animal.getState
// 	   RETURN Animal.state
	 
// 	Function Animal.getSize
// 	   RETURN Animal.size
	 
// END CLASS

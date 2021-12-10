using System;

namespace Generics
{
    public class GenericType<T>
    {
        //where T : class // reference constraint; makes sure the generic type is a class
        public GenericType(T item, string name)
        {
            Item = item;
            Name = name;
        }
        public T Item{get; private set;}
        public string Name{get; private set;}

        static void Main(string[] args)
        {
            var a = new GenericType<int>(42, "The answer");  // int type
            Console.WriteLine(a.Item );
        }
    }
}

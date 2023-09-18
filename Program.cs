using System;

namespace EntendendoAlgoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList<int>();
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Print(); // Saída: 1 -> 2 -> 3 -> null

            linkedList.Remove(2);
            linkedList.Print();// Saída: 1 -> 3 -> null
        }
    }
}
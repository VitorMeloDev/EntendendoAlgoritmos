
namespace EntendendoAlgoritmos
{
    class LinkedList<T>
    {
        private Node<T> head;

        public void Add(T item)
        {
            var newNode = new Node<T>(item);
            
            if (head == null) head = newNode;
            else
            {
                var current = head;
                while(current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void Remove(T value)
        {
            if (head == null)
            {
                return; // Lista vazia, nada a fazer
            }

            if (head.Value.Equals(value))
            {
                // Caso especial: o elemento a ser removido é o primeiro nó (cabeça)
                head = head.Next; // Atualiza a cabeça para o próximo nó
                return;
            }

            var current = head;
            while (current.Next != null)
            {
                if (current.Next.Value.Equals(value))
                {
                    current.Next = current.Next.Next; // Atualiza a referência 'Next' do nó anterior
                    return;
                }
                current = current.Next;
            }
        }

        public void Print()
        {
            var current = head;
            while (current != null)
            {
                Console.Write(current.Value + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}

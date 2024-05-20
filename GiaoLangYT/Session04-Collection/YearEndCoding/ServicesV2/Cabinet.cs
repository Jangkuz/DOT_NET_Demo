namespace ServicesV2
{
    public class Cabinet<T>
    {
        private List<T> list = new List<T>();

        public void addItem(T item)
        {
            list.Add(item);
        }

        public void printAll()
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}

namespace MyObjectPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - ");

            objectPool<Student> objectPool = new objectPool<Student>();

            Student student = objectPool.getObject();

            Console.WriteLine("First object assigned.Lets check!");

            objectPool.releaseObject(student);

            Console.WriteLine("Objects number must now be equal to 1 : [{0}]",objectPool.getObjectsNUmber());

            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
        }
    }
}

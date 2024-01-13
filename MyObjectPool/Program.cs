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
            
            Console.WriteLine("Objects number in object pool must now be equal to 0 : [{0}]", objectPool.getObjectsNUmber());

            Console.WriteLine("Now we release the object and ...");

            Thread.Sleep(1000);

            objectPool.releaseObject(student);

            Console.WriteLine("Objects number in object pool must now be equal to 1 : [{0}]",objectPool.getObjectsNUmber());

            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
        }
    }
}

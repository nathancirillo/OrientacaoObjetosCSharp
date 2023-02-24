namespace Course
{
    class LacoForeach
    {
        public static void Main(string[]args)
        {
            string[] vect = new string[]{"Nathan", "Vanessa", "Ana", "Pedro"}; 

            for(int i=0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]); 
            }

            Console.WriteLine("--------------------------");

            foreach(string obj in vect)
            {
                System.Console.WriteLine(obj);
            } 
        }
    }
}
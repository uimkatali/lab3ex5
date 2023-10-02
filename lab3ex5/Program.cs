namespace lab1ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sir = Console.ReadLine();
            int nrVocale = 0;
            for (int i = 0; i < sir.Length; i++)
            {
               if(sir[i] == 'a' || sir[i] == 'e' || sir[i] == 'i' || sir[i] == 'o' || sir[i] == 'u')
                {
                    nrVocale++;
                }
            }
            Console.WriteLine(nrVocale);
        }
    }
}
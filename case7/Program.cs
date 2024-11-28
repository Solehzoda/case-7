using System;

namespace case7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массу:");
            Console.WriteLine("1 - килограмм, 2 - миллиграмм, 3 - грамм, 4 - тонна, 5 - центнер");

            string масса = Console.ReadLine();
            string единица = Console.ReadLine();

            
            double массаВЧисле = Double.Parse(масса);
            int единицаВЧисл = Int32.Parse(единица);
            
            double массаВКГ = 0;

           
            switch (единицаВЧисл)
            {
                case 1: 
                    массаВКГ = массаВЧисле; 
                    break;

                case 2: 
                    массаВКГ = массаВЧисле / 1_000_000; 
                    break;

                case 3: 
                    массаВКГ = массаВЧисле / 1000; 
                    break;

                case 4: 
                    массаВКГ = массаВЧисле * 1000; 
                    break;

                case 5: 
                    массаВКГ = массаВЧисле * 100; 
                    break;

                default:
                    Console.WriteLine("Incorrect input");
                    return; 
            }

          
            Console.WriteLine($"Масса килограммах: {массаВКГ} кг");
        }
    }
}
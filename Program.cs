namespace HomeWorkCollections1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> words = new Dictionary<string, string>(6);
            bool isProgramOn = true;

            AddDictionary(words);

            Console.Write("Для выхода из программы напишите Escape\nВведите слово: ");
            Console.SetCursorPosition(0, 2);

            while (isProgramOn)
            {
                string userInput = Console.ReadLine(); 

                if (words.ContainsKey(userInput))
                {
                    Console.WriteLine("Значение - " + ValueTask.FromResult(words[userInput]));
                }
                else if(userInput == "Escape")
                {
                    isProgramOn = false;
                }
                else
                {
                    Console.WriteLine("Такого значения нет");
                }
            }
        }

        static void AddDictionary(Dictionary<string,string> words)
        {
            words.Add("Привет", "И тебе привет!");
            words.Add("Земля", "Небо");
            words.Add("День", "Ночь");
            words.Add("Свет", "Тьма");
            words.Add("Белое", "Черное");
            words.Add("Инь", "Янь");
        }
    }
}
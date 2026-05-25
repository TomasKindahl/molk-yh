namespace MJU23v_D10_inl_sveng
{
    internal class Program
    {
        static List<SweEngGloss> dictionary;
        class SweEngGloss
        {
            public string word_swe, word_eng;
            public SweEngGloss(string word_swe, string word_eng)
            {
                this.word_swe = word_swe; this.word_eng = word_eng;
            }
            public SweEngGloss(string line)
            {
                string[] words = line.Split('|');
                this.word_swe = words[0]; this.word_eng = words[1];
            }
        }
        static void Main(string[] args)
        {
            string defaultFile = "..\\..\\..\\dict\\sweeng.lis";
            Console.WriteLine("Welcome to the dictionary app!");
            do
            {
                Console.Write("> ");
                string[] argument = Console.ReadLine().Split();
                string command = argument[0];
                if (command == "quit")
                {
                    Console.WriteLine("Goodbye!");
                    break; // now it really quits!
                }
                else if (command == "load")
                {
                    if (argument.Length == 2)
                        ReadDictionaryFromFile(argument[1]);
                    else if (argument.Length == 1)
                        ReadDictionaryFromFile(defaultFile);
                    else 
                        Console.WriteLine("Usage:\n" +
                            "  load          - loads 'sweeng.lis'\n" +
                            "  load /file/   - loads a file");
                }
                else if (command == "list")
                {
                    // FIXME: NullReferenceException if dictionary == null!
                    foreach (SweEngGloss gloss in dictionary)
                        Console.WriteLine($"{gloss.word_swe,-10}  - {gloss.word_eng,-10}");
                }
                else if (command == "new")
                {
                    // FIXME: NullReferenceException if dictionary is empty!
                    if (argument.Length == 3)
                        dictionary.Add(new SweEngGloss(argument[1], argument[2]));
                    else if(argument.Length == 1)
                    {
                        string swed = Input("Write word in Swedish: ");
                        string eng = Input("Write word in English: ");
                        dictionary.Add(new SweEngGloss(swed, eng));
                    }
                    // FIXME: no bad number of arguments handling!
                }
                else if (command == "delete")
                {
                    if (argument.Length == 3)
                        RemoveAllMatching(argument[1], argument[2]);
                    else if (argument.Length == 1)
                    {
                        string swed = Input("Write word in Swedish: ");
                        string eng = Input("Write word in English: ");
                        RemoveAllMatching(swed, eng);
                    }
                    // FIXME: no bad number of arguments handling!
                }
                else if (command == "translate")
                {
                    if (argument.Length == 2)
                        WriteTranslationsOf(argument[1]);
                    else if (argument.Length == 1)
                        WriteTranslationsOf(Input("Write word to be translated: "));
                    // FIXME: no bad number of arguments handling!
                }
                else
                {
                    Console.WriteLine($"Unknown command: '{command}'");
                }
            }
            while (true);
        }

        private static void ReadDictionaryFromFile(string filePath)
        {
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    dictionary = new List<SweEngGloss>(); // Empty it!
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        SweEngGloss gloss = new SweEngGloss(line);
                        dictionary.Add(gloss);
                        line = sr.ReadLine();
                    }
                    // NYI: list number of entries read!
                }
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine($"File '{filePath}' not found!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Bad file name '{filePath}'!");
            }
            catch (IOException)
            {
                Console.WriteLine($"Bad file name '{filePath}'!");
            }
        }
        private static void RemoveAllMatching(string swed, string eng)
        {
            int index = -1;
            // FIXME: NullReferenceException if dictionary == null!
            for (int i = 0; i < dictionary.Count; i++)
            {
                SweEngGloss gloss = dictionary[i];
                if (gloss.word_swe == swed && gloss.word_eng == eng)
                    index = i;
            }
            // FIXME: ArgumentOutOfRangeException if index remains -1!
            dictionary.RemoveAt(index);
        }

        private static string Input(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        private static void WriteTranslationsOf(string word)
        {
            foreach (SweEngGloss gloss in dictionary)
            {
                if (gloss.word_swe == word)
                    Console.WriteLine($"English for {gloss.word_swe} is {gloss.word_eng}");
                if (gloss.word_eng == word)
                    Console.WriteLine($"Swedish for {gloss.word_eng} is {gloss.word_swe}");
            }
        }
    }
}
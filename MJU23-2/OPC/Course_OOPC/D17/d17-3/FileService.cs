namespace d17ReadFromFileExe3
{
    public class FileService
    {
        public List<AddressEntry> ReadFile(string filePath)
        {
            List<AddressEntry> entries = new List<AddressEntry>();
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 2)
                    {
                        entries.Add(new AddressEntry { Name = parts[0], Address = parts[1] });
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions or log errors
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
            return entries;
        }
    }
}
namespace ovn_6_1_2
{
    internal class Program
    {
        static IEnumerable<string> Räkneramsa(int n)
        {
            yield return "esike";
            yield return "desike";
            yield return "luntan";
            yield return "tuntan";
            yield return "simili";
            yield return "maka";
            yield return "kokeli";
            yield return "kaka";
            yield return "ärtan";
            yield return "pärtan";
            yield return "puff";
        }
        static void Main(string[] args)
        {
            foreach (string s in Räkneramsa(5))
                Console.Write($"{s} ");
            Console.WriteLine();
        }
    }
}

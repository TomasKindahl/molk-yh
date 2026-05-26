namespace shuntingyard {
	internal class Program {
		static void Main(string[] arg) {
			Console.WriteLine("Welcome to the interpreter. Write '/q' to exit!");
			while(true) {
				Console.Write(": ");
				string line = Console.ReadLine();
				if(line == "/q") {
					break;
				}
				else {
					double answ = ShuntingYard.Execute(line);
					Console.WriteLine($"answ = {answ}");
				}
			}
			Console.WriteLine("Bye");
		}
	}
}
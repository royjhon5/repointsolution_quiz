using System.Text;

class RePointSolutionsQuiz {
    static void Main() {
        Console.Write("Input your data here: ");
        string input = Console.ReadLine();
        int number = ParseTheNumberFromString(input);
        Console.WriteLine("The extracted number is: " + number);
    }
    static int ParseTheNumberFromString(string input) {
        StringBuilder numberBuilder = new StringBuilder();
         foreach (char valuesainput in input){
            if (char.IsDigit(valuesainput)){
                numberBuilder.Append(valuesainput);
            }
        }
        return numberBuilder.Length > 0 ? int.Parse(numberBuilder.ToString()) : 0;
    }
}
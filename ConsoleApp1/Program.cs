using System.Text;

class RePointSolutionsQuiz {
    static void Main() {
        Console.Write("Input your data here: ");
        string input = Console.ReadLine();
        int number = ParseTheNumberFromString(input);
        Console.WriteLine("The extracted number is: " + number);
    }
    static int ParseTheNumberFromString(string input) {
        int result = 0;
        bool getTheDigitOnly = false;
        foreach (char valuesinput in input) {
           if (valuesinput >= '0' && valuesinput <= '9') {
            getTheDigitOnly = true;
            result = result * 10 + (valuesinput - '0');
           }
        }
         return getTheDigitOnly ? result : 0;

    }
}
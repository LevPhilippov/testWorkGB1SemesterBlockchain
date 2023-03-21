using System.Text;

public class Program {
    public static void Main(){
        var initialString = getArgsFromConsole();
        var delim = 3;
        Console.WriteLine($"Исходная строка данных {initialString}");

        String[] initialArray = initialString.Split("$");
        Console.WriteLine("Делим на токены");
        String[] finalArray = new String[initialArray.Length];
        long counter = 0;
        Console.WriteLine("Начинаем работу в цикле for");
        for(int i = 0; i<initialArray.Length; i++){
            if(initialArray[i].Length <= delim) {
                finalArray[counter] = initialArray[i];
                counter++;
            }
        }
        Console.WriteLine($"Работа в цикле for окончена, размер финального массива {counter}");
        String[] result = new String[counter];
        Array.Copy(finalArray, result, counter);
        Console.WriteLine(String.Join(" ",result));
    }

    private static String getArgsFromConsole(){
        Console.WriteLine("Введите произвольное количество слов/символов, разделяя их клавишей ввод. Когда надоест - ваберите слово \"хватит\". Не применяйте символ $");
        StringBuilder sb = new StringBuilder();
        string ? token; 
        while(true){
            token = Console.ReadLine() ?? "";
            if(token.ToLowerInvariant().Equals("хватит"))
                break;
            sb.Append(token).Append("$");
            Console.WriteLine($"Принято слово {token}");
        }    
        return sb.ToString();
    }


}

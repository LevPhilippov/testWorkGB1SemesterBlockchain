using System.Text;

public class Program {
    public static void Main(){
        var initialString = getArgsFromConsole();
        Console.WriteLine($"Исходная строкаданных {initialString}");
        
    }

    private static String getArgsFromConsole(){
        Console.WriteLine("Введите произвольное колечество слов/символов, разделяя их клавишей ввод. Когда надоест - ваберите слово \"хватит\".");
        StringBuilder sb = new StringBuilder();
        string ? token; 
        while(true){
            token = Console.ReadLine() ?? "";
            if(token.ToLowerInvariant().Equals("хватит"))
                break;
            sb.Append(token).Append(" ");
            Console.WriteLine($"Принято слово {token}");
        }    
        return sb.ToString();
    }


}

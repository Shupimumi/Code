/*Разработать программу для вывода зеркального отображения начала и
конца строки. В терминале вводится слово. Необходимо вывести на экран
строку зеркально отображенную в начале и конце слова или указать что такой
строки нет. Например, вводится строка «asdBGRYsa» - результат: «as».*/
import java.util.Scanner; 

public class First_Lab {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.println("Enter your string:");
        String enter = in.nextLine();
        String result;
        Boolean check = isEmpty(enter); 
       
       if (check == false)
        {
            result = giveReflectedString(enter);
            if(result.length()==enter.length())
            {
             int mid = result.length() / 2;
            String[] parts = {result.substring(0, mid),result.substring(mid)};
            System.out.println("enter: " +enter);
            System.out.println("result: " +parts[0]);
            }
            else
            {
               System.out.println("enter: " +enter);
               System.out.println("result: " +result); 
            }
            
        }
        else 
        {
            System.out.println("String is null or empty");
        }
    }
    public static Boolean isEmpty(String str){
        return (str == null|| str.length()== 0);
    }
    public static String giveReflectedString(String str) {
        char[] chArray = str.toCharArray(); 
        String result="";
        if (chArray[0] == chArray[chArray.length - 1]) { 

            for (int i = 0; i < chArray.length; i++) {
                if (chArray[i] == chArray[chArray.length - 1 - i]) {
                    result+=Character.toString(chArray[i]);
                }
                if (chArray[i] != chArray[chArray.length - 1 - i]) break;
            }
        }
        if (chArray[0] != chArray[chArray.length - 1])
        {
            System.out.print("Reflection is not found or enter was uncorrectly, entered string will be returned.   ");
        }
        
        return result;
    }
}


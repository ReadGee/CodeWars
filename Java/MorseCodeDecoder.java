import java.util.Arrays;

public class MorseCodeDecoder {
    public static void main(String[] args) {
        System.out.println(decode("   .   ."));
    }

    public static String decode(String morseCode) {
        String[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l",
                  "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", 
                  "y", "z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                  ",", ".", "?", "!", "SOS" };

        String[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", 
                ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.",
                "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", ".----",
                "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.",
                "-----", "--..--", ".-.-.-", "..--..", "-.-.--", "...---..." };

        String[] morseSplitingText = morseCode.toLowerCase().split("   ");
        morseCode = "";

        for (var elem : morseSplitingText)
        {
            String[] word = elem.split(" ");

            for (int i = 0; i < word.length; i++)
            {
                if(Arrays.stream(morse).toList().indexOf(word[i]) != -1)
                {                    
                    morseCode += alphabet[Arrays.stream(morse).toList().indexOf(word[i])];
                }
                else{
                    morseCode += word[i];
                }
            }

            if(elem != morseSplitingText[morseSplitingText.length-1] && elem != "") morseCode += " ";
        }
        return morseCode.toUpperCase();
    }
}

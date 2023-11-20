import java.io.*;
import java.util.StringTokenizer;

public class SwapFirstAndLastWords {
    public static void main(String[] args) {
        String inputFileName = "input.txt";
        String outputFileName = "output.txt";

        try {
            BufferedReader reader = new BufferedReader(new FileReader(inputFileName));
            BufferedWriter writer = new BufferedWriter(new FileWriter(outputFileName));
            String line;

            while ((line = reader.readLine()) != null) {
                String[] words = line.split("\\s+");
                if (words.length >= 2) {
                    String firstWord = words[0];
                    String lastWord = words[words.length - 1];
                    words[0] = lastWord;
                    words[words.length - 1] = firstWord;

                    String newLine = String.join(" ", words);
                    writer.write(newLine);
                    writer.newLine();
                } else {
                    writer.write(line);
                    writer.newLine();
                }
            }

            reader.close();
            writer.close();

            System.out.println("Файл успешно обработан.");
        } catch (IOException e) {
            System.err.println("Ошибка при чтении/записи файла: " + e.getMessage());
        }
    }
}

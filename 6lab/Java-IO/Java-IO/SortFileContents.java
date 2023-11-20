import java.io.*;
import java.util.ArrayList;
import java.util.Collections;
import java.util.Random;

public class SortFileContents {
    public static void main(String[] args) {
        String fileName = "random_numbers.txt";
        int numberOfNumbers = 100;
        int minNumber = 1;
        int maxNumber = 1000;

        generateRandomNumbersToFile(fileName, numberOfNumbers, minNumber, maxNumber);

        sortNumbersInFile(fileName);
    }

    private static void generateRandomNumbersToFile(String fileName, int numberOfNumbers, int minNumber, int maxNumber) {
        try (BufferedWriter writer = new BufferedWriter(new FileWriter(fileName))) {
            Random random = new Random();
            for (int i = 0; i < numberOfNumbers; i++) {
                int randomNumber = random.nextInt(maxNumber - minNumber + 1) + minNumber;
                writer.write(String.valueOf(randomNumber));
                writer.newLine();
            }
        } catch (IOException e) {
            System.err.println("Ошибка при записи в файл: " + e.getMessage());
        }
    }

    private static void sortNumbersInFile(String fileName) {
        try (BufferedReader reader = new BufferedReader(new FileReader(fileName))) {
            ArrayList<Integer> numbers = new ArrayList<>();
            String line;

            while ((line = reader.readLine()) != null) {
                int number = Integer.parseInt(line);
                numbers.add(number);
            }

            Collections.sort(numbers);

            try (BufferedWriter writer = new BufferedWriter(new FileWriter(fileName))) {
                for (int number : numbers) {
                    writer.write(String.valueOf(number));
                    writer.newLine();
                }
            }
        } catch (IOException e) {
            System.err.println("Ошибка при чтении или записи файла: " + e.getMessage());
        }
    }
}


// DateHandler.java
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Input day/month/year
        System.out.print("Nhap ngay: ");
        int day = scanner.nextInt();
        System.out.print("Nhap thang: ");
        int month = scanner.nextInt();
        System.out.print("Nhap nam: ");
        int year = scanner.nextInt();

        // Check if the date is valid
        if (!isValidDate(day, month, year)) {
            System.out.println("Ngay khong hop le!");
        } else {
            // Display valid date
            LocalDate date = LocalDate.of(year, month, day);
            System.out.println("Ngay hop le: " + formatDate(date));

            // Calculate next day
            LocalDate nextDay = date.plusDays(1);
            System.out.println("Ngay ke tiep: " + formatDate(nextDay));

            // Calculate previous day
            LocalDate previousDay = date.minusDays(1);
            System.out.println("Ngay truoc do: " + formatDate(previousDay));
        }

        scanner.close();
    }

    // Function to check if the date is valid
    public static boolean isValidDate(int day, int month, int year) {
        try {
            LocalDate.of(year, month, day);
            return true;
        } catch (Exception e) {
            return false;
        }
    }

    // Function to format date as "dd/MM/yyyy"
    public static String formatDate(LocalDate date) {
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd/MM/yyyy");
        return date.format(formatter);
    }
}

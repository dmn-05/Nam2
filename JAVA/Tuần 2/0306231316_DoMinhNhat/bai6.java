package bai6;
import java.util.*;
import java.time.*;
import java.time.format.DateTimeFormatter;
public class bai6 {
    public static void main(String[] args) {
        System.out.println("Tong thoi gian tu 0h 01/01/1970 den nay: " +  System.currentTimeMillis() / 1000);
        LocalTime now = LocalTime.now();

        System.out.println(now);
        
    }
}

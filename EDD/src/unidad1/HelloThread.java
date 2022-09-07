package unidad1;

import java.time.Clock;
import java.time.Instant;
import java.time.LocalDate;
import java.time.ZoneId;
import java.util.Calendar;
import java.util.GregorianCalendar;

public class Ordenamiento {
    public static void main(String[] args) {
        var clockFixed = Clock.fixed(new GregorianCalendar(2022, Calendar.JANUARY, 1).toInstant(), ZoneId.systemDefault());
        var weekDay = LocalDate.now(clockFixed).getDayOfWeek().getValue();
        System.out.println(weekDay);
    }
}

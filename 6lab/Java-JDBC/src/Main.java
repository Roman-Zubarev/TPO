import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.List;

public class Main {
    public static void main(String[] args) throws SQLException {
        try (Connection connection = DatabaseConnection.getConnection()) {
            ClockStoreQueries clockStoreQueries = new ClockStoreQueries(connection);

            List<String> brandsByType = clockStoreQueries.getBrandsByType("Механические");
            System.out.println("Марки механических часов: " + brandsByType);

            List<String> mechanicalClockInfo = clockStoreQueries.getMechanicalClockInfo(150.0);
            System.out.println("Информация о механических часах: " + mechanicalClockInfo);

           List<String> brandsByCountry = clockStoreQueries.getBrandsByCountry("japan");
            System.out.println("Марки часов, изготовленных в заданной стране: " + brandsByCountry);

            List<String> manufacturersByTotalPrice = clockStoreQueries.getManufacturersByTotalPrice(10000.0);
            System.out.println("Производители: " + manufacturersByTotalPrice);
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
}
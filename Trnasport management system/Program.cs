using System;
using MySql.Data.MySqlClient;

namespace TransportManagementSystem
{
    internal class Program
    {
        // XAMPP default MySQL connection string
        static string connString = "server=127.0.0.1;user=root;database=transport_db;password=;";

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=== TRANSPORT MANAGEMENT SYSTEM ===");
                Console.WriteLine("1. View Available Fleet (Vehicles)");
                Console.WriteLine("2. View Available Drivers");
                Console.WriteLine("3. Create a Tour Request");
                Console.WriteLine("4. Exit");
                Console.Write("Enter Choice (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowAvailableVehicles();
                        break;
                    case "2":
                        ShowAvailableDrivers();
                        break;
                    case "3":
                        CreateTourRequest();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid option! Try again.");
                        break;
                }
            }
        }

        static void ShowAvailableVehicles()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, vehicle_number, vehicle_type, capacity FROM vehicles WHERE status = 'Available'";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("\n--- AVAILABLE VEHICLES ---");
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["id"]} | No: {reader["vehicle_number"]} | Type: {reader["vehicle_type"]} | Capacity: {reader["capacity"]} seats");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("DB Error: " + ex.Message);
                }
            }
        }

        static void ShowAvailableDrivers()
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, driver_name, phone FROM drivers WHERE status = 'Available'";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        Console.WriteLine("\n--- AVAILABLE DRIVERS ---");
                        while (reader.Read())
                        {
                            Console.WriteLine($"ID: {reader["id"]} | Name: {reader["driver_name"]} | Phone: {reader["phone"]}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("DB Error: " + ex.Message);
                }
            }
        }

        static void CreateTourRequest()
        {
            Console.Write("\nEnter Customer Name: ");
            string customer = Console.ReadLine();

            Console.Write("Pickup Location: ");
            string pickup = Console.ReadLine();

            Console.Write("Destination: ");
            string destination = Console.ReadLine();

            Console.Write("Select Vehicle ID: ");
            int vehicleId = int.Parse(Console.ReadLine());

            Console.Write("Select Driver ID: ");
            int driverId = int.Parse(Console.ReadLine());

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO tour_requests (customer_name, pickup_location, destination, request_date, vehicle_id, driver_id, status) " +
                                   "VALUES (@customer, @pickup, @dest, CURDATE(), @vId, @dId, 'Approved')";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@customer", customer);
                        cmd.Parameters.AddWithValue("@pickup", pickup);
                        cmd.Parameters.AddWithValue("@dest", destination);
                        cmd.Parameters.AddWithValue("@vId", vehicleId);
                        cmd.Parameters.AddWithValue("@dId", driverId);

                        cmd.ExecuteNonQuery();
                        Console.WriteLine(">> Tour request created and allocated successfully!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("DB Error: " + ex.Message);
                }
            }
        }
    }
}
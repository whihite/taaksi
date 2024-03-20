using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using taaksi.Models;

namespace taaksi
{
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
            LoadCarList();
        }

        private void LoadCarList()
        {
            // Здесь нужно использовать вашу строку подключения к базе данных
            string connectionString = "DESKTOP-410JK39\\SQLEXPRSS";

            // Здесь ваш SQL-запрос для выборки данных
            string query = "SELECT TOP 20 Model, Make, PlateNumber FROM Cars";

            List<Car> cars = new List<Car>();

            // Создаем подключение к базе данных
            using (var connection = new SqlConnection(connectionString))
            {
                // Создаем команду SQL с использованием запроса и подключения
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    // Создаем читатель данных
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Создаем объект Car для каждой строки и добавляем его в список
                            cars.Add(new Car
                            {
                                Model = reader.GetString(0),
                                Make = reader.GetString(1),
                                PlateNumber = reader.GetString(2)
                            });
                        }
                    }
                }
            }

            // Устанавливаем источник данных для элемента управления DataGrid
            carsDataGrid.ItemsSource = cars;
        }
    }

    // Класс для представления автомобиля
    public class Car
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public string PlateNumber { get; set; }
    }
}

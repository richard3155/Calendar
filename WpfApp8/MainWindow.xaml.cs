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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                DateTime selectedDate = (DateTime)((Calendar)sender).SelectedDate;
                taskInputPanel.Visibility = Visibility.Visible;
                calendar.IsEnabled = false;
            }
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            string taskDescription = taskDescriptionTextBox.Text;
            DateTime selectedDate = (DateTime)calendar.SelectedDate;

            MessageBox.Show($"Задача на {selectedDate.ToShortDateString()}: {taskDescription}");

            taskInputPanel.Visibility = Visibility.Collapsed;
            calendar.IsEnabled = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            taskInputPanel.Visibility = Visibility.Collapsed;
            calendar.IsEnabled = true;
        }
    }
}

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

namespace _17marNEW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="H:\Informatics 12\semester 2\17marNEW\17marNEW\Database1.mdf";Integrated Security=True
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            _17marNEW.TrainsDataSet trainsDataSet = ((_17marNEW.TrainsDataSet)(this.FindResource("trainsDataSet")));
            // Load data into the table Booking. You can modify this code as needed.
            _17marNEW.TrainsDataSetTableAdapters.BookingTableAdapter trainsDataSetBookingTableAdapter = new _17marNEW.TrainsDataSetTableAdapters.BookingTableAdapter();
            trainsDataSetBookingTableAdapter.Fill(trainsDataSet.Booking);
            System.Windows.Data.CollectionViewSource bookingViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("bookingViewSource")));
            bookingViewSource.View.MoveCurrentToFirst();
            // Load data into the table Schedule. You can modify this code as needed.
            _17marNEW.TrainsDataSetTableAdapters.ScheduleTableAdapter trainsDataSetScheduleTableAdapter = new _17marNEW.TrainsDataSetTableAdapters.ScheduleTableAdapter();
            trainsDataSetScheduleTableAdapter.Fill(trainsDataSet.Schedule);
            System.Windows.Data.CollectionViewSource scheduleViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("scheduleViewSource")));
            scheduleViewSource.View.MoveCurrentToFirst();
        }
    }
}

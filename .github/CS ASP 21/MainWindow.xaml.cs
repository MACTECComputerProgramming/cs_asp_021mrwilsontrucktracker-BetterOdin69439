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

namespace CS_ASP_21
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

       
        //Print Driver Ticket
        private void buttonPrint_Click_1(object sender, RoutedEventArgs e)
        {
            //Instantate variables

            string resultname = string.Format(" Driver - {0} ", textBoxName.Text);

            int ss = int.Parse(textBoxSS.Text);

            string resultSS = string.Format(" Social Security Numer # {0 : 000-00-0000} ", ss);

            int phone = int.Parse(textBoxPhone.Text);

            string resultPhone = string.Format(" Phone Number : {0 : (000)000-0000} ", phone);
            //Format Driver Info

            labelName.Content = resultname;

            labelSS.Content = resultSS;

            labelPhone.Content = resultPhone;


            //Get Total Days
            //Get Days Off
            //Get Total Miles
            //Get Total Pay
       

           
        }
    }
}
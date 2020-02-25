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

namespace WpfBasics
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



        private void BtnApply_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The description is: {this.txt_Description.Text}");
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            this.cboxWeld.IsChecked = this.cboxAssembly.IsChecked = this.cboxPlasma.IsChecked = this.cboxLaser.IsChecked = this.cboxPurchase.IsChecked
                = this.cboxLathe.IsChecked = this.cboxDrill.IsChecked = this.cboxFold.IsChecked = this.cboxRoll.IsChecked = this.cboxSaw.IsChecked = false;
        }

        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Cbox_Checked(object sender, RoutedEventArgs e)
        {
            this.txtLength.Text += ((CheckBox)sender).Content;
        }

        private void DropDownFinish_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.txtNote == null)
                return;

            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedValue;

            this.txtNote.Text = (string)value.Content;

            //this.txtNote.Text = (string)((ComboBoxItem)((ComboBox)sender).SelectedValue).Content;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DropDownFinish_SelectionChanged(this.dropDownFinish, null);
        }

        private void TxtSupplierName_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.txtMass.Text = this.txtSupplierName.Text;
        }
    }
}

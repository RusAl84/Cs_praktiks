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

namespace WpfApp1
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

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show("Maxim ushel v army");
    }

    private void myButton_Click(object sender, RoutedEventArgs e)
    {
      myButton.Background = Brushes.Blue;
      myListBox.Items.Add(textBox1.Text);
      myPG.Value += 1;
    }

    private void myListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      string str1 = myListBox.SelectedItem.ToString();
      MessageBox.Show(str1);
    }
  }
}

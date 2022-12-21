using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Diagnostics;

namespace HomeWork_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Stack<string> wordStack = new Stack<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ObservableCollection<string> wordList = new ObservableCollection<string>();
            foreach (string elem in splitTextBox.Text.Split(' '))
                wordList.Add(elem);
            splitBox.ItemsSource = wordList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (string elem in inverseText.Text.Split())
                wordStack.Push(elem);
            invLabel.Content = string.Join(" ", wordStack.ToArray());
            //string text = string.Join(" ", wordStack.ToArray());
        }
    }
}

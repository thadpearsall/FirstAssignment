using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace RTSLabs_Assignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<int> testList;

        public MainWindow()
        {
            InitializeComponent();
            testList = new List<int>();
            for (int x = 0; x < 20; x++)
            {
                testList.Add(x);
            }
        }

        //wanted to finish and return the assignment quick, it didn't specify any UI requirements so i just tested code here
        private void btn_AboveBelow_clicked(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            var ret = AssignmentClass.aboveBelow(testList, 5);
            
            if (ret == null) return;

            var first = ret.FirstOrDefault();
            var second = ret.LastOrDefault();
            if (first == null || second == null) return;
            Debug.Print(first.Item1 + " " + first.Item2 + "\n" + second.Item1 + " " + second.Item2);
            //Console.WriteLine(first.Item1 + " "+ first.Item2 + "\n" + second.Item1 + second.Item2);
        }

        private void btn_StringRotation_clicked(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
            var ret = AssignmentClass.stringRotation("StringToRotate", 5);
            Debug.Print(ret);
        }
    }
}

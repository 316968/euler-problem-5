/* Quinn Parker-Joyes
 * June 14 2018
 * Euler Problem 5
 * finds smallest number evenly divisible by all numbers from 1-20
 */



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

namespace eulerProblem5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int answer = 1;
        public MainWindow()
        {
            InitializeComponent();
            // this really long while loop just goes through each number and sees if it is evenly divisible, and the counter increases for a 'right' answer
            while (answer % 2 != 0 || answer % 3 != 0 || answer % 4 != 0 || answer % 5 != 0 ||
            answer % 6 != 0 || answer % 7 != 0 || answer % 8 != 0 || answer % 9 != 0 ||
            answer % 10 != 0 || answer % 11 != 0 || answer % 12 != 0 || answer % 13 != 0 ||
            answer % 14 != 0 || answer % 15 != 0 || answer % 16 != 0 || answer % 17 != 0 ||
            answer % 18 != 0 || answer % 19 != 0 || answer % 20 != 0)
            {
                answer++;
            }
            MessageBox.Show(answer.ToString());
        }
        
        

    }
}

using CodeGeneration.Models;
using Common;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CodeGeneration
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

        private void ShowTestWindow_Click(object sender, RoutedEventArgs e)
        {
            TestWindow testWindow = new TestWindow();
            testWindow.ShowDialog();
        }

        private void DotNet6_Click(object sender, RoutedEventArgs e)
        {
            var gen = new GenerateDotNet6();
            gen.Generate();
        }

        private void NetFrameWork_Click(object sender, RoutedEventArgs e)
        {
            var gen = new GenrerateNetFramework();
            gen.Generate();
        }
        private void GenrerateNetStandard_Click(object sender, RoutedEventArgs e)
        {
            var gen = new GenrerateNetStandard();
            gen.Generate();
        }
    }
}

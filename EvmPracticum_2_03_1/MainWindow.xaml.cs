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

namespace EvmPracticum_2_03_1
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
        private void ButtonWhite_Click(object sender, RoutedEventArgs e)
        {
            myInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            myInkCanvas.DefaultDrawingAttributes.Color = Colors.White;
        }

        private void ButtonRed_Click(object sender, RoutedEventArgs e)
        {
            myInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            myInkCanvas.DefaultDrawingAttributes.Color = Colors.Red;
        }

        private void ButtonOrange_Click(object sender, RoutedEventArgs e)
        {
            myInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            myInkCanvas.DefaultDrawingAttributes.Color = Colors.Orange;
        }

        private void ButtonYellow_Click(object sender, RoutedEventArgs e)
        {
            myInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            myInkCanvas.DefaultDrawingAttributes.Color = Colors.Yellow;
        }
        
        private void ButtonGreen_Click(object sender, RoutedEventArgs e)
        {
            myInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            myInkCanvas.DefaultDrawingAttributes.Color = Colors.Green;
        }

        private void ButtonBlue_Click(object sender, RoutedEventArgs e)
        {
            myInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            myInkCanvas.DefaultDrawingAttributes.Color = Colors.Blue;
        }
        private void ButtonPurple_Click(object sender, RoutedEventArgs e)
        {
            myInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            myInkCanvas.DefaultDrawingAttributes.Color = Colors.Purple;
        }
        private void ButtonBlack_Click(object sender, RoutedEventArgs e)
        {
            myInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
            myInkCanvas.DefaultDrawingAttributes.Color = Colors.Black;
        }
        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            myInkCanvas.Strokes.Clear();
        }
        private void slValue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = (Slider)sender;
            double value = slider.Value;
            if (value > 10)
            {
                myInkCanvas.DefaultDrawingAttributes.Width = value;
                myInkCanvas.DefaultDrawingAttributes.Height= value;
            }
        }

        private void ButtonEraser_Click(object sender, RoutedEventArgs e)
        {
            myInkCanvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }
        private void ButtonLosso_Click(object sender, RoutedEventArgs e)
        {
            myInkCanvas.EditingMode = InkCanvasEditingMode.Select;
        }
        private void ButtonPen_Click(object sender, RoutedEventArgs e)
        {
            myInkCanvas.EditingMode = InkCanvasEditingMode.Ink;
        }
    }
}

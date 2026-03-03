using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Forms;
using System.Windows.Media;

namespace ChartTest
{
    public partial class MainForm : Form
    {

        void FillCartesianChart()
        {
            LineSeries series = new LineSeries
            {
                Title = "Продажи",
                Values = new ChartValues<int> { 10, 15, 12, 18, 25, 22 },

                Stroke = new SolidColorBrush(Colors.Teal),
                StrokeThickness = 2,

                PointGeometry = DefaultGeometries.Circle,
                PointGeometrySize = 8,

                Fill = new LinearGradientBrush(
                    System.Windows.Media.Color.FromArgb(90, 0, 150, 136),
                    System.Windows.Media.Color.FromArgb(0, 0, 150, 136),
                    90)
            };

            cartesian.Series = new SeriesCollection { series, /*series_2, series_3*/ };

            /// Ось Y
            cartesian.AxisY.Add(new Axis
            {
                Foreground = new SolidColorBrush(Color.FromArgb(200, 69, 90, 100)), // Темно-серый с оттенком синего
                LabelFormatter = value => value.ToString("N0"),

                Separator = new Separator
                {
                    Stroke = new SolidColorBrush(Color.FromArgb(30, 100, 100, 180)),// Голубоватый сепаратор
                    StrokeThickness = 0.8,
                    StrokeDashArray = new DoubleCollection { 4 } // Пунктирная линия
                },

                MaxValue = 30,
                MinValue = 1
            }              
            );


            /// Ось X
            cartesian.AxisX.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.Black,
                Labels = new[] { "Янв", "Фев", "Мар", "Апр", "Май", "Июн" },

                Separator = new Separator
                {
                    IsEnabled = false,
                },
            }
            );
        }

        void FillAngular()
        {
            angular.Value = 65;
            angular.FromValue = 0;
            angular.ToValue = 100;

            angular.TicksForeground = Brushes.Gray;
            angular.NeedleFill = Brushes.DarkBlue;
        }

        void FillSolid()
        {
            solid.Value = 40;
            solid.From = 0;
            solid.To = 100;
            solid.LabelFormatter = value => value + "%";
        }
        public MainForm()
        {
            InitializeComponent();

            FillCartesianChart();

            FillAngular();

            FillSolid();
        }
    }
}

using System.Windows;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;

namespace LaboratoryWork1
{
    /// <summary>
    /// Interaction logic for histogram.xaml
    /// </summary>
    public partial class histogram : Window
    {
        public histogram()
        {
            InitializeComponent();
        }

        public void CreatingHistogram(ArrayList myAL)
        {
            // Все графики находятся в пределах области построения ChartArea, создадим ее
            chart.ChartAreas.Add(new ChartArea("Default"));

            // Добавим линию, и назначим ее в ранее созданную область "Default"
            chart.Series.Add(new Series("Series1"));
            chart.Series["Series1"].ChartArea = "Default";
            chart.Series["Series1"].ChartType = SeriesChartType.Column;

            for (int index = 0; index < myAL.Count; index++)
            {
                chart.Series["Series1"].Points.AddXY(index + 1, myAL[index]);
            }
        }
    }
}

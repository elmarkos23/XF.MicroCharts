using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microcharts;
using SkiaSharp;
using Microcharts.Forms;
using Xamarin.Forms;
using Entry = Microcharts.Entry;

namespace XF.MicroCharts
{
    public partial class MainPage : ContentPage
    {
        List<Entry> entries = new List<Entry>
        {
            new Entry(200)
            {
               // Color=SKColor.Parse("#FF1943"),
                Label ="Carlos",
                ValueLabel = "200"
            },
            new Entry(400)
            {
               // Color = SKColor.Parse("00BFFF"),
                Label = "Enrique",
                ValueLabel = "400"
            },
            new Entry(730)
            {
              //  Color = SKColor.Parse("00EEFF"),
                Label = "Elena",
                ValueLabel = "730"
            },
            new Entry(555)
            {
              //  Color = SKColor.Parse("00BBFF"),
                Label = "Antonio",
                ValueLabel = "555"
            },
            new Entry(50)
            {
              //  Color =  SKColor.Parse("#00CED1"),
                Label = "Saul",
                ValueLabel = "50"
            },
            };
        public MainPage()
        {
            InitializeComponent();
            Chart1.Chart = new RadialGaugeChart() { Entries = entries };
            Chart2.Chart = new LineChart() { Entries = entries };
            Chart3.Chart = new DonutChart() { Entries = entries };
            Chart4.Chart = new BarChart() { Entries = entries };
            Chart5.Chart = new PointChart() { Entries = entries };
            Chart6.Chart = new RadarChart() { Entries = entries };
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using YazilimSinamaStokTakipSistemi.Controller;
using DevExpress.XtraCharts;

namespace YazilimSinamaStokTakipSistemi.Views.Raporlar
{
    public partial class RaporlarForm : DevExpress.XtraEditors.XtraForm
    {
        public RaporlarForm()
        {
            InitializeComponent();
        }

        private void RaporlarForm_Load(object sender, EventArgs e)
        {
            getStockReport();
        }

        private void tileBar_SelectedItemChanged(object sender, TileItemEventArgs e)
        {
            navigationFrame.SelectedPageIndex = tileBarGroupTables.Items.IndexOf(e.Item);
        }

        public void getStockReport()
        {
            var result = StokController.StoklarıGetir();
            if (result.Count == 0) return;
            ChartControl DoughnutChart = new ChartControl();

          
            Series series1 = new Series("Series 1", ViewType.Doughnut);
            foreach (var item in result)
            {
                series1.Points.Add(new SeriesPoint(item.UrunStok.Urunler.UrunAdi.ToString(), item.UrunStok.Stok));
            }
            DoughnutChart.Series.Add(series1);

    
            series1.Label.TextPattern = "{A}: {VP:P0}";

           
            series1.SeriesPointsSorting = SortingMode.Ascending;
            series1.SeriesPointsSortingKey = SeriesPointKey.Argument;

           
            ((DoughnutSeriesLabel)series1.Label).Position = PieSeriesLabelPosition.TwoColumns;
            ((DoughnutSeriesLabel)series1.Label).ResolveOverlappingMode = ResolveOverlappingMode.Default;
            ((DoughnutSeriesLabel)series1.Label).ResolveOverlappingMinIndent = 5;

           
            ((DoughnutSeriesView)series1.View).ExplodedPoints.Add(series1.Points[0]);
            ((DoughnutSeriesView)series1.View).ExplodedDistancePercentage = 30;

          
            ((SimpleDiagram)DoughnutChart.Diagram).Dimension = 2;

           
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "Stok Pasta Grafiği";
            DoughnutChart.Titles.Add(chartTitle1);
            DoughnutChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;

       
            DoughnutChart.Dock = DockStyle.Fill;
            this.panel_Stok.Controls.Add(DoughnutChart);
        }
    }
}
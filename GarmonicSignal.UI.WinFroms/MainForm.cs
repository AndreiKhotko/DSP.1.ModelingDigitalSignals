using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GarmonicSignal.UI.WinFroms
{
    public partial class MainForm : Form
    {
        private List<double> cBoxPhaseConstList;
        private List<int> cBoxNConstList;
        private List<Function> functions;
        private List<double> incrementsA;
        private List<double> incrementsFreq;
        private List<double> incrementsPhase;

        public MainForm()
        {
            InitializeComponent();
            InitCBoxItems();
            InitPolyGarmonicElements();
            InitIncrements();
            InitChart();
            
        }

        private void InitIncrements()
        {
            incrementsA = new List<double>();
            incrementsFreq = new List<double>();
            incrementsPhase = new List<double>();

            foreach (var function in functions)
            {
                incrementsA.Add(function.Amplitude * 0.15);
                incrementsFreq.Add(function.Frequency * 0.15);
                incrementsPhase.Add(function.Phase * 0.15);
            }
        }

        private void InitChart()
        {
            chart.Series["PolyGarmonicFunction"].ChartType = SeriesChartType.Spline;
            chart.Series["PolyGarmonicFunction"].Points.Clear();

            chart.Series["GarmonicFunction"].Points.Clear();
            chart.Series["GarmonicFunction"].ChartType = SeriesChartType.Spline;
        }

        private void ClearChart()
        {
            chart.Series["PolyGarmonicFunction"].Points.Clear();
            chart.Series["GarmonicFunction"].Points.Clear();
        }

        private void InitCBoxItems()
        {
            // Init cBoxPhase
            this.cBoxPhase.Items.AddRange(new object[] {
            "0",
            "PI / 6",
            "PI / 3",
            "PI / 2",
            "PI",
            "3*PI / 4"});
            cBoxPhase.SelectedIndex = 5;
            cBoxPhaseConstList = new List<double>();
            cBoxPhaseConstList.AddRange(new double[] {
                0,
                Math.PI / 6,
                Math.PI / 3,
                Math.PI / 2,
                Math.PI,
                Math.PI * 3 / 4
            });

            // Init cBoxN
            this.cBoxN.Items.AddRange(new object[] {
                "512",
                "1024",
                "2048",
                "4096"});
            cBoxN.SelectedIndex = 0;
            cBoxNConstList = new List<int>();
            cBoxNConstList.AddRange(new int[] {
                512,
                1024,
                2048,
                4096    
            });
        }

        private void InitPolyGarmonicElements()
        {
            functions = new List<Function>();

            var phaseList = new List<double>(new double[] {
                Math.PI / 2,
                0,
                Math.PI / 4,
                Math.PI / 3,
                Math.PI / 6
            });

            int N = GetNValue();
            int A = 9;
            int freq = 1;

            for (int j = 0; j < 5; j++)
                functions.Add(new Function(A, freq++, phaseList[j], N));
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            ClearChart();

            int a = Convert.ToInt32(numUpDownA.Value);
            int freq = Convert.ToInt32(numUpDownFreq.Value);

            double phase = GetPhaseValue();
            int N = GetNValue();

            var function = new GarmonicSignal.Function(a, freq, phase, N);

            SetDataSourceForChart(function);
        }

        private double GetPhaseValue() => cBoxPhaseConstList[cBoxPhase.SelectedIndex];
        private int GetNValue() => cBoxNConstList[cBoxN.SelectedIndex];

        private void SetDataSourceForChart(GarmonicSignal.Function func)
        {
            for (int n = 0; n < func.N; n++)
            {
                double x = func.GetValue(n);

                chart.Series["GarmonicFunction"].Points.AddXY(n, x);
            }
        }

        private void radioBtnA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnA.Checked)
            {
                numUpDownA.Value = 5;
                numUpDownFreq.Value = 7;

                cBoxPhase.SelectedIndex = cBoxPhaseConstList.IndexOf(Math.PI);
                lblInfoForUser.Text = "Phase = Pi, 0, Pi/3, Pi/6, Pi/2";
            }
        }

        private void radioBtnB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnB.Checked)
            {
                numUpDownA.Value = 5;
                cBoxPhase.SelectedIndex = cBoxPhaseConstList.IndexOf(Math.PI * 3 / 4);

                numUpDownFreq.Value = 1;
                lblInfoForUser.Text = "Frequency = 1, 5, 11, 6, 3";
            }
        }

        private void radioBtnC_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnC.Checked)
            {
                numUpDownFreq.Value = 3;
                cBoxPhase.SelectedIndex = cBoxPhaseConstList.IndexOf(Math.PI * 3 / 4);

                numUpDownA.Value = 1;
                lblInfoForUser.Text = "A = 1, 2, 11, 4, 2";
            }
        }

        private void radioBtnD_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnD.Checked)
            {
                ClearChart();
                InitPolyGarmonicElements();
                var N = GetNValue();

                for (int n = 0; n < N; n++)
                {
                    double sum = 0;

                    foreach (var f in functions)
                    {
                        sum += f.GetValue(n);
                    }

                    chart.Series["PolyGarmonicFunction"].Points.AddXY(n, sum);
                }
            }
        }

        private void radioBtnE_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnE.Checked)
            {
                ClearChart();
                InitPolyGarmonicElements();
                var N = GetNValue();

                for (int n = 0; n < N; n++)
                {
                    double sum = 0;

                    foreach (var f in functions)
                    {
                        sum += f.GetValue(n);
                    }

                    IncrementValues();
                    chart.Series["PolyGarmonicFunction"].Points.AddXY(n, sum);
                }
            }
        }

        private void IncrementValues()
        {
            for (int i = 0; i < functions.Count; i++)
            {
                functions[i].Amplitude += incrementsA[i];
                functions[i].Frequency += incrementsFreq[i];
                functions[i].Phase += incrementsPhase[i];
            }
        }
    }
}

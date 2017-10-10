namespace GarmonicSignal.UI.WinFroms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBuild = new System.Windows.Forms.Button();
            this.numUpDownA = new System.Windows.Forms.NumericUpDown();
            this.numUpDownFreq = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblFreq = new System.Windows.Forms.Label();
            this.lblPhase = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.cBoxPhase = new System.Windows.Forms.ComboBox();
            this.cBoxN = new System.Windows.Forms.ComboBox();
            this.groupBoxVariant = new System.Windows.Forms.GroupBox();
            this.radioBtnE = new System.Windows.Forms.RadioButton();
            this.radioBtnD = new System.Windows.Forms.RadioButton();
            this.radioBtnC = new System.Windows.Forms.RadioButton();
            this.radioBtnB = new System.Windows.Forms.RadioButton();
            this.radioBtnA = new System.Windows.Forms.RadioButton();
            this.lblInfoForUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownFreq)).BeginInit();
            this.groupBoxVariant.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(36, 12);
            this.chart.Name = "chart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "GarmonicFunction";
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.Red;
            series6.Legend = "Legend1";
            series6.Name = "PolyGarmonicFunction";
            this.chart.Series.Add(series5);
            this.chart.Series.Add(series6);
            this.chart.Size = new System.Drawing.Size(753, 300);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(873, 147);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(75, 23);
            this.btnBuild.TabIndex = 1;
            this.btnBuild.Text = "Построить";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // numUpDownA
            // 
            this.numUpDownA.Location = new System.Drawing.Point(859, 39);
            this.numUpDownA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDownA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownA.Name = "numUpDownA";
            this.numUpDownA.Size = new System.Drawing.Size(120, 21);
            this.numUpDownA.TabIndex = 2;
            this.numUpDownA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUpDownFreq
            // 
            this.numUpDownFreq.Location = new System.Drawing.Point(859, 66);
            this.numUpDownFreq.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDownFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDownFreq.Name = "numUpDownFreq";
            this.numUpDownFreq.Size = new System.Drawing.Size(120, 21);
            this.numUpDownFreq.TabIndex = 4;
            this.numUpDownFreq.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(870, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Параметры";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(839, 41);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 7;
            this.lblA.Text = "A";
            // 
            // lblFreq
            // 
            this.lblFreq.AutoSize = true;
            this.lblFreq.Location = new System.Drawing.Point(795, 68);
            this.lblFreq.Name = "lblFreq";
            this.lblFreq.Size = new System.Drawing.Size(58, 13);
            this.lblFreq.TabIndex = 8;
            this.lblFreq.Text = "Frequency";
            // 
            // lblPhase
            // 
            this.lblPhase.AutoSize = true;
            this.lblPhase.Location = new System.Drawing.Point(817, 95);
            this.lblPhase.Name = "lblPhase";
            this.lblPhase.Size = new System.Drawing.Size(36, 13);
            this.lblPhase.TabIndex = 9;
            this.lblPhase.Text = "Phase";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(839, 122);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(14, 13);
            this.lblN.TabIndex = 10;
            this.lblN.Text = "N";
            // 
            // cBoxPhase
            // 
            this.cBoxPhase.FormattingEnabled = true;
            this.cBoxPhase.Location = new System.Drawing.Point(859, 92);
            this.cBoxPhase.Name = "cBoxPhase";
            this.cBoxPhase.Size = new System.Drawing.Size(120, 21);
            this.cBoxPhase.TabIndex = 11;
            // 
            // cBoxN
            // 
            this.cBoxN.FormattingEnabled = true;
            this.cBoxN.Location = new System.Drawing.Point(859, 120);
            this.cBoxN.Name = "cBoxN";
            this.cBoxN.Size = new System.Drawing.Size(120, 21);
            this.cBoxN.TabIndex = 12;
            // 
            // groupBoxVariant
            // 
            this.groupBoxVariant.Controls.Add(this.radioBtnE);
            this.groupBoxVariant.Controls.Add(this.radioBtnD);
            this.groupBoxVariant.Controls.Add(this.radioBtnC);
            this.groupBoxVariant.Controls.Add(this.radioBtnB);
            this.groupBoxVariant.Controls.Add(this.radioBtnA);
            this.groupBoxVariant.Location = new System.Drawing.Point(798, 213);
            this.groupBoxVariant.Name = "groupBoxVariant";
            this.groupBoxVariant.Size = new System.Drawing.Size(200, 149);
            this.groupBoxVariant.TabIndex = 13;
            this.groupBoxVariant.TabStop = false;
            this.groupBoxVariant.Text = "Вариант построения:";
            // 
            // radioBtnE
            // 
            this.radioBtnE.Location = new System.Drawing.Point(6, 112);
            this.radioBtnE.Name = "radioBtnE";
            this.radioBtnE.Size = new System.Drawing.Size(173, 37);
            this.radioBtnE.TabIndex = 4;
            this.radioBtnE.TabStop = true;
            this.radioBtnE.Text = "A, Freq, Phase возрастают по линейному закону";
            this.radioBtnE.UseVisualStyleBackColor = true;
            this.radioBtnE.CheckedChanged += new System.EventHandler(this.radioBtnE_CheckedChanged);
            // 
            // radioBtnD
            // 
            this.radioBtnD.AutoSize = true;
            this.radioBtnD.Location = new System.Drawing.Point(6, 89);
            this.radioBtnD.Name = "radioBtnD";
            this.radioBtnD.Size = new System.Drawing.Size(163, 17);
            this.radioBtnD.TabIndex = 3;
            this.radioBtnD.TabStop = true;
            this.radioBtnD.Text = "Полигармонический сигнал";
            this.radioBtnD.UseVisualStyleBackColor = true;
            this.radioBtnD.CheckedChanged += new System.EventHandler(this.radioBtnD_CheckedChanged);
            // 
            // radioBtnC
            // 
            this.radioBtnC.AutoSize = true;
            this.radioBtnC.Location = new System.Drawing.Point(6, 66);
            this.radioBtnC.Name = "radioBtnC";
            this.radioBtnC.Size = new System.Drawing.Size(180, 17);
            this.radioBtnC.TabIndex = 2;
            this.radioBtnC.TabStop = true;
            this.radioBtnC.Text = "Freq, Phase = const, A changes";
            this.radioBtnC.UseVisualStyleBackColor = true;
            this.radioBtnC.CheckedChanged += new System.EventHandler(this.radioBtnC_CheckedChanged);
            // 
            // radioBtnB
            // 
            this.radioBtnB.AutoSize = true;
            this.radioBtnB.Location = new System.Drawing.Point(6, 43);
            this.radioBtnB.Name = "radioBtnB";
            this.radioBtnB.Size = new System.Drawing.Size(180, 17);
            this.radioBtnB.TabIndex = 1;
            this.radioBtnB.TabStop = true;
            this.radioBtnB.Text = "A, Phase = const, Freq changes";
            this.radioBtnB.UseVisualStyleBackColor = true;
            this.radioBtnB.CheckedChanged += new System.EventHandler(this.radioBtnB_CheckedChanged);
            // 
            // radioBtnA
            // 
            this.radioBtnA.AutoSize = true;
            this.radioBtnA.Location = new System.Drawing.Point(6, 20);
            this.radioBtnA.Name = "radioBtnA";
            this.radioBtnA.Size = new System.Drawing.Size(180, 17);
            this.radioBtnA.TabIndex = 0;
            this.radioBtnA.TabStop = true;
            this.radioBtnA.Text = "A, Freq = const; Phase changes";
            this.radioBtnA.UseVisualStyleBackColor = true;
            this.radioBtnA.CheckedChanged += new System.EventHandler(this.radioBtnA_CheckedChanged);
            // 
            // lblInfoForUser
            // 
            this.lblInfoForUser.AutoSize = true;
            this.lblInfoForUser.Location = new System.Drawing.Point(801, 182);
            this.lblInfoForUser.Name = "lblInfoForUser";
            this.lblInfoForUser.Size = new System.Drawing.Size(0, 13);
            this.lblInfoForUser.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 365);
            this.Controls.Add(this.lblInfoForUser);
            this.Controls.Add(this.groupBoxVariant);
            this.Controls.Add(this.cBoxN);
            this.Controls.Add(this.cBoxPhase);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblPhase);
            this.Controls.Add(this.lblFreq);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUpDownFreq);
            this.Controls.Add(this.numUpDownA);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.chart);
            this.Name = "MainForm";
            this.Text = "ЦОС: Лабораторная работа 1 - Моделирование цифровых сигналов различных типов";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownFreq)).EndInit();
            this.groupBoxVariant.ResumeLayout(false);
            this.groupBoxVariant.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.NumericUpDown numUpDownA;
        private System.Windows.Forms.NumericUpDown numUpDownFreq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblFreq;
        private System.Windows.Forms.Label lblPhase;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.ComboBox cBoxPhase;
        private System.Windows.Forms.ComboBox cBoxN;
        private System.Windows.Forms.GroupBox groupBoxVariant;
        private System.Windows.Forms.RadioButton radioBtnD;
        private System.Windows.Forms.RadioButton radioBtnC;
        private System.Windows.Forms.RadioButton radioBtnB;
        private System.Windows.Forms.RadioButton radioBtnA;
        private System.Windows.Forms.Label lblInfoForUser;
        private System.Windows.Forms.RadioButton radioBtnE;
    }
}


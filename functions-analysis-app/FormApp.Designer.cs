﻿namespace functions_analysis_app
{
    partial class FormApp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApp));
            this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonGraphBuild = new System.Windows.Forms.Button();
            this.textBoxEquation = new System.Windows.Forms.TextBox();
            this.pictureBoxFunction = new System.Windows.Forms.PictureBox();
            this.buttonInputInfo = new System.Windows.Forms.Button();
            this.pictureBoxEqual = new System.Windows.Forms.PictureBox();
            this.comboBoxAnalysis = new System.Windows.Forms.ComboBox();
            this.buttonEvaluate = new System.Windows.Forms.Button();
            this.labelAnalysis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEqual)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGraph
            // 
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX2.Interval = 1D;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisY.Interval = 1D;
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY2.Interval = 1D;
            chartArea2.Name = "ChartArea1";
            this.chartGraph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGraph.Legends.Add(legend2);
            this.chartGraph.Location = new System.Drawing.Point(0, 96);
            this.chartGraph.Name = "chartGraph";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartGraph.Series.Add(series2);
            this.chartGraph.Size = new System.Drawing.Size(578, 421);
            this.chartGraph.TabIndex = 0;
            this.chartGraph.Text = "chart1";
            // 
            // buttonGraphBuild
            // 
            this.buttonGraphBuild.BackColor = System.Drawing.SystemColors.Info;
            this.buttonGraphBuild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonGraphBuild.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGraphBuild.Location = new System.Drawing.Point(0, 523);
            this.buttonGraphBuild.Name = "buttonGraphBuild";
            this.buttonGraphBuild.Size = new System.Drawing.Size(215, 44);
            this.buttonGraphBuild.TabIndex = 1;
            this.buttonGraphBuild.Text = "Построить график";
            this.buttonGraphBuild.UseVisualStyleBackColor = false;
            this.buttonGraphBuild.Click += new System.EventHandler(this.buttonGraphBuild_Click);
            // 
            // textBoxEquation
            // 
            this.textBoxEquation.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEquation.Location = new System.Drawing.Point(531, 34);
            this.textBoxEquation.Name = "textBoxEquation";
            this.textBoxEquation.Size = new System.Drawing.Size(289, 36);
            this.textBoxEquation.TabIndex = 2;
            // 
            // pictureBoxFunction
            // 
            this.pictureBoxFunction.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFunction.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFunction.Image")));
            this.pictureBoxFunction.Location = new System.Drawing.Point(371, 28);
            this.pictureBoxFunction.Name = "pictureBoxFunction";
            this.pictureBoxFunction.Size = new System.Drawing.Size(101, 50);
            this.pictureBoxFunction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFunction.TabIndex = 3;
            this.pictureBoxFunction.TabStop = false;
            // 
            // buttonInputInfo
            // 
            this.buttonInputInfo.BackColor = System.Drawing.SystemColors.Info;
            this.buttonInputInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonInputInfo.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInputInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonInputInfo.Location = new System.Drawing.Point(826, 34);
            this.buttonInputInfo.Name = "buttonInputInfo";
            this.buttonInputInfo.Size = new System.Drawing.Size(187, 36);
            this.buttonInputInfo.TabIndex = 6;
            this.buttonInputInfo.Text = "Инструкция";
            this.buttonInputInfo.UseVisualStyleBackColor = false;
            this.buttonInputInfo.Click += new System.EventHandler(this.buttonInputInfo_Click);
            // 
            // pictureBoxEqual
            // 
            this.pictureBoxEqual.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxEqual.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxEqual.Image")));
            this.pictureBoxEqual.Location = new System.Drawing.Point(478, 34);
            this.pictureBoxEqual.Name = "pictureBoxEqual";
            this.pictureBoxEqual.Size = new System.Drawing.Size(47, 36);
            this.pictureBoxEqual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEqual.TabIndex = 4;
            this.pictureBoxEqual.TabStop = false;
            // 
            // comboBoxAnalysis
            // 
            this.comboBoxAnalysis.FormattingEnabled = true;
            this.comboBoxAnalysis.Location = new System.Drawing.Point(607, 143);
            this.comboBoxAnalysis.Name = "comboBoxAnalysis";
            this.comboBoxAnalysis.Size = new System.Drawing.Size(184, 21);
            this.comboBoxAnalysis.TabIndex = 7;
            // 
            // buttonEvaluate
            // 
            this.buttonEvaluate.BackColor = System.Drawing.SystemColors.Info;
            this.buttonEvaluate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEvaluate.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEvaluate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEvaluate.Location = new System.Drawing.Point(812, 143);
            this.buttonEvaluate.Name = "buttonEvaluate";
            this.buttonEvaluate.Size = new System.Drawing.Size(187, 30);
            this.buttonEvaluate.TabIndex = 8;
            this.buttonEvaluate.Text = "Рассчитать";
            this.buttonEvaluate.UseVisualStyleBackColor = false;
            // 
            // labelAnalysis
            // 
            this.labelAnalysis.AutoSize = true;
            this.labelAnalysis.BackColor = System.Drawing.Color.Transparent;
            this.labelAnalysis.Font = new System.Drawing.Font("Sitka Small", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnalysis.Location = new System.Drawing.Point(634, 96);
            this.labelAnalysis.Name = "labelAnalysis";
            this.labelAnalysis.Size = new System.Drawing.Size(330, 35);
            this.labelAnalysis.TabIndex = 9;
            this.labelAnalysis.Text = "Исследование функции";
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 574);
            this.Controls.Add(this.labelAnalysis);
            this.Controls.Add(this.buttonEvaluate);
            this.Controls.Add(this.comboBoxAnalysis);
            this.Controls.Add(this.buttonInputInfo);
            this.Controls.Add(this.textBoxEquation);
            this.Controls.Add(this.pictureBoxEqual);
            this.Controls.Add(this.pictureBoxFunction);
            this.Controls.Add(this.buttonGraphBuild);
            this.Controls.Add(this.chartGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormApp";
            this.Text = "Functions analysis";
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEqual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
        private System.Windows.Forms.Button buttonGraphBuild;
        private System.Windows.Forms.TextBox textBoxEquation;
        private System.Windows.Forms.PictureBox pictureBoxFunction;
        private System.Windows.Forms.Button buttonInputInfo;
        private System.Windows.Forms.PictureBox pictureBoxEqual;
        private System.Windows.Forms.ComboBox comboBoxAnalysis;
        private System.Windows.Forms.Button buttonEvaluate;
        private System.Windows.Forms.Label labelAnalysis;
    }
}


namespace MusicLearner
{
    partial class StatisticForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.statisticChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toMainMenuButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statisticChart)).BeginInit();
            this.SuspendLayout();
            // 
            // statisticChart
            // 
            chartArea1.Name = "Лучшие серии ответов";
            chartArea2.Name = "Процент ответов";
            this.statisticChart.ChartAreas.Add(chartArea1);
            this.statisticChart.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.statisticChart.Legends.Add(legend1);
            this.statisticChart.Location = new System.Drawing.Point(31, 48);
            this.statisticChart.Name = "statisticChart";
            series1.ChartArea = "Лучшие серии ответов";
            series1.Legend = "Legend1";
            series1.Name = "Общее число вопросов";
            series2.BorderWidth = 5;
            series2.ChartArea = "Лучшие серии ответов";
            series2.Color = System.Drawing.Color.PaleGreen;
            series2.LabelBackColor = System.Drawing.Color.Lime;
            series2.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Лучшая серия ответов";
            series3.BorderWidth = 5;
            series3.ChartArea = "Процент ответов";
            series3.Color = System.Drawing.Color.Orange;
            series3.Legend = "Legend1";
            series3.Name = "Процент правильных ответов";
            this.statisticChart.Series.Add(series1);
            this.statisticChart.Series.Add(series2);
            this.statisticChart.Series.Add(series3);
            this.statisticChart.Size = new System.Drawing.Size(541, 341);
            this.statisticChart.TabIndex = 0;
            this.statisticChart.Text = "Статистика пользователя";
            title1.Name = "Статистика ответов";
            this.statisticChart.Titles.Add(title1);
            // 
            // toMainMenuButton
            // 
            this.toMainMenuButton.Location = new System.Drawing.Point(407, 219);
            this.toMainMenuButton.Name = "toMainMenuButton";
            this.toMainMenuButton.Size = new System.Drawing.Size(118, 82);
            this.toMainMenuButton.TabIndex = 1;
            this.toMainMenuButton.Text = "Назад";
            this.toMainMenuButton.UseVisualStyleBackColor = true;
            this.toMainMenuButton.Click += new System.EventHandler(this.toMainMenuButton_Click);
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.toMainMenuButton);
            this.Controls.Add(this.statisticChart);
            this.Name = "StatisticForm";
            this.Text = "Статистика пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.statisticChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart statisticChart;
        private System.Windows.Forms.Button toMainMenuButton;
    }
}
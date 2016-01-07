﻿namespace DogeStation2
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.stationNameLabel = new System.Windows.Forms.Label();
            this.sensorList = new System.Windows.Forms.ComboBox();
            this.recordButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.sensorLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.stationName = new System.Windows.Forms.TextBox();
            this.dataGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGraph)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // stationNameLabel
            // 
            this.stationNameLabel.AutoSize = true;
            this.stationNameLabel.Location = new System.Drawing.Point(30, 23);
            this.stationNameLabel.Name = "stationNameLabel";
            this.stationNameLabel.Size = new System.Drawing.Size(183, 32);
            this.stationNameLabel.TabIndex = 0;
            this.stationNameLabel.Text = "Station name";
            // 
            // sensorList
            // 
            this.sensorList.FormattingEnabled = true;
            this.sensorList.ItemHeight = 31;
            this.sensorList.Location = new System.Drawing.Point(821, 15);
            this.sensorList.Name = "sensorList";
            this.sensorList.Size = new System.Drawing.Size(121, 39);
            this.sensorList.TabIndex = 1;
            // 
            // recordButton
            // 
            this.recordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.recordButton.Location = new System.Drawing.Point(1198, 13);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(150, 53);
            this.recordButton.TabIndex = 2;
            this.recordButton.Text = "Record";
            this.recordButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(1354, 13);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 53);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // sensorLabel
            // 
            this.sensorLabel.AutoSize = true;
            this.sensorLabel.Location = new System.Drawing.Point(699, 23);
            this.sensorLabel.Name = "sensorLabel";
            this.sensorLabel.Size = new System.Drawing.Size(105, 32);
            this.sensorLabel.TabIndex = 4;
            this.sensorLabel.Text = "Sensor";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(948, 13);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(150, 53);
            this.refreshButton.TabIndex = 5;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            // 
            // stationName
            // 
            this.stationName.Location = new System.Drawing.Point(230, 20);
            this.stationName.Name = "stationName";
            this.stationName.Size = new System.Drawing.Size(418, 38);
            this.stationName.TabIndex = 6;
            // 
            // dataGraph
            // 
            this.dataGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "X";
            chartArea2.Name = "Y";
            chartArea3.Name = "Z";
            this.dataGraph.ChartAreas.Add(chartArea1);
            this.dataGraph.ChartAreas.Add(chartArea2);
            this.dataGraph.ChartAreas.Add(chartArea3);
            legend1.Name = "Legend1";
            this.dataGraph.Legends.Add(legend1);
            this.dataGraph.Location = new System.Drawing.Point(37, 90);
            this.dataGraph.Name = "dataGraph";
            series1.ChartArea = "X";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "X";
            series2.ChartArea = "Y";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Y";
            series3.ChartArea = "Z";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "Z";
            this.dataGraph.Series.Add(series1);
            this.dataGraph.Series.Add(series2);
            this.dataGraph.Series.Add(series3);
            this.dataGraph.Size = new System.Drawing.Size(1466, 1213);
            this.dataGraph.TabIndex = 7;
            this.dataGraph.Text = "Magnetic Data Sample";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 1333);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1535, 46);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(100, 41);
            this.toolStripStatus.Text = "Ready";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 1379);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.dataGraph);
            this.Controls.Add(this.stationName);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.sensorLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.sensorList);
            this.Controls.Add(this.stationNameLabel);
            this.Name = "MainForm";
            this.Text = "Magnetic Data Recorder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGraph)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stationNameLabel;
        private System.Windows.Forms.ComboBox sensorList;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label sensorLabel;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox stationName;
        private System.Windows.Forms.DataVisualization.Charting.Chart dataGraph;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
    }
}

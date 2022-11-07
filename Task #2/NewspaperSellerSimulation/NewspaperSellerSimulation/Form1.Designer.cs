namespace NewspaperSellerSimulation
{
    partial class NumOfNewspapersText
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridDayTypeDistribution = new System.Windows.Forms.DataGridView();
            this.DayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpenTestCase = new System.Windows.Forms.Button();
            this.NumOfNewspapers = new System.Windows.Forms.Label();
            this.NumOfNewspaperstextBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NumOfRecordsText = new System.Windows.Forms.TextBox();
            this.NumOfRecords = new System.Windows.Forms.Label();
            this.PurchasePriceText = new System.Windows.Forms.TextBox();
            this.PurchasePrice = new System.Windows.Forms.Label();
            this.ScrapPriceText = new System.Windows.Forms.TextBox();
            this.ScrapPrice = new System.Windows.Forms.Label();
            this.SellingPriceText = new System.Windows.Forms.TextBox();
            this.SellingPrice = new System.Windows.Forms.Label();
            this.dataGridDemandDistributions = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Demand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Good = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDayTypeDistribution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDemandDistributions)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(811, 411);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Measurement";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridDayTypeDistribution
            // 
            this.dataGridDayTypeDistribution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDayTypeDistribution.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DayType,
            this.Probability});
            this.dataGridDayTypeDistribution.Location = new System.Drawing.Point(77, 47);
            this.dataGridDayTypeDistribution.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridDayTypeDistribution.Name = "dataGridDayTypeDistribution";
            this.dataGridDayTypeDistribution.RowHeadersWidth = 51;
            this.dataGridDayTypeDistribution.RowTemplate.Height = 24;
            this.dataGridDayTypeDistribution.Size = new System.Drawing.Size(246, 316);
            this.dataGridDayTypeDistribution.TabIndex = 2;
            this.dataGridDayTypeDistribution.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DayType
            // 
            this.DayType.HeaderText = "Day Type";
            this.DayType.Name = "DayType";
            // 
            // Probability
            // 
            this.Probability.HeaderText = "Probability";
            this.Probability.Name = "Probability";
            // 
            // OpenTestCase
            // 
            this.OpenTestCase.BackColor = System.Drawing.SystemColors.Highlight;
            this.OpenTestCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenTestCase.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OpenTestCase.Location = new System.Drawing.Point(35, 411);
            this.OpenTestCase.Margin = new System.Windows.Forms.Padding(2);
            this.OpenTestCase.Name = "OpenTestCase";
            this.OpenTestCase.Size = new System.Drawing.Size(154, 51);
            this.OpenTestCase.TabIndex = 4;
            this.OpenTestCase.Text = "OpenTestCase";
            this.OpenTestCase.UseVisualStyleBackColor = false;
            this.OpenTestCase.Click += new System.EventHandler(this.OpenTestCase_Click);
            // 
            // NumOfNewspapers
            // 
            this.NumOfNewspapers.AutoSize = true;
            this.NumOfNewspapers.Location = new System.Drawing.Point(224, 412);
            this.NumOfNewspapers.Name = "NumOfNewspapers";
            this.NumOfNewspapers.Size = new System.Drawing.Size(99, 13);
            this.NumOfNewspapers.TabIndex = 5;
            this.NumOfNewspapers.Text = "NumOfNewspapers";
            this.NumOfNewspapers.Click += new System.EventHandler(this.NumOfNewspapers_Click);
            // 
            // NumOfNewspaperstextBox
            // 
            this.NumOfNewspaperstextBox.Location = new System.Drawing.Point(227, 442);
            this.NumOfNewspaperstextBox.Name = "NumOfNewspaperstextBox";
            this.NumOfNewspaperstextBox.Size = new System.Drawing.Size(96, 20);
            this.NumOfNewspaperstextBox.TabIndex = 6;
            this.NumOfNewspaperstextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // NumOfRecordsText
            // 
            this.NumOfRecordsText.Location = new System.Drawing.Point(341, 442);
            this.NumOfRecordsText.Name = "NumOfRecordsText";
            this.NumOfRecordsText.Size = new System.Drawing.Size(96, 20);
            this.NumOfRecordsText.TabIndex = 9;
            this.NumOfRecordsText.TextChanged += new System.EventHandler(this.NumOfRecordsText_TextChanged);
            // 
            // NumOfRecords
            // 
            this.NumOfRecords.AutoSize = true;
            this.NumOfRecords.Location = new System.Drawing.Point(347, 412);
            this.NumOfRecords.Name = "NumOfRecords";
            this.NumOfRecords.Size = new System.Drawing.Size(80, 13);
            this.NumOfRecords.TabIndex = 8;
            this.NumOfRecords.Text = "NumOfRecords";
            this.NumOfRecords.Click += new System.EventHandler(this.NumOfRecords_Click);
            // 
            // PurchasePriceText
            // 
            this.PurchasePriceText.Location = new System.Drawing.Point(456, 441);
            this.PurchasePriceText.Name = "PurchasePriceText";
            this.PurchasePriceText.Size = new System.Drawing.Size(96, 20);
            this.PurchasePriceText.TabIndex = 11;
            this.PurchasePriceText.TextChanged += new System.EventHandler(this.PurchasePriceText_TextChanged);
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.AutoSize = true;
            this.PurchasePrice.Location = new System.Drawing.Point(465, 411);
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.Size = new System.Drawing.Size(76, 13);
            this.PurchasePrice.TabIndex = 10;
            this.PurchasePrice.Text = "PurchasePrice";
            this.PurchasePrice.Click += new System.EventHandler(this.PurchasePrice_Click);
            // 
            // ScrapPriceText
            // 
            this.ScrapPriceText.Location = new System.Drawing.Point(575, 442);
            this.ScrapPriceText.Name = "ScrapPriceText";
            this.ScrapPriceText.Size = new System.Drawing.Size(96, 20);
            this.ScrapPriceText.TabIndex = 13;
            this.ScrapPriceText.TextChanged += new System.EventHandler(this.ScrapPriceText_TextChanged);
            // 
            // ScrapPrice
            // 
            this.ScrapPrice.AutoSize = true;
            this.ScrapPrice.Location = new System.Drawing.Point(591, 412);
            this.ScrapPrice.Name = "ScrapPrice";
            this.ScrapPrice.Size = new System.Drawing.Size(59, 13);
            this.ScrapPrice.TabIndex = 12;
            this.ScrapPrice.Text = "ScrapPrice";
            this.ScrapPrice.Click += new System.EventHandler(this.ScrapPrice_Click);
            // 
            // SellingPriceText
            // 
            this.SellingPriceText.Location = new System.Drawing.Point(688, 441);
            this.SellingPriceText.Name = "SellingPriceText";
            this.SellingPriceText.Size = new System.Drawing.Size(96, 20);
            this.SellingPriceText.TabIndex = 15;
            this.SellingPriceText.TextChanged += new System.EventHandler(this.SellingPriceText_TextChanged);
            // 
            // SellingPrice
            // 
            this.SellingPrice.AutoSize = true;
            this.SellingPrice.Location = new System.Drawing.Point(695, 411);
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.Size = new System.Drawing.Size(62, 13);
            this.SellingPrice.TabIndex = 14;
            this.SellingPrice.Text = "SellingPrice";
            this.SellingPrice.Click += new System.EventHandler(this.SellingPrice_Click);
            // 
            // dataGridDemandDistributions
            // 
            this.dataGridDemandDistributions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDemandDistributions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Demand,
            this.Good,
            this.Fair,
            this.Poor});
            this.dataGridDemandDistributions.Location = new System.Drawing.Point(456, 47);
            this.dataGridDemandDistributions.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridDemandDistributions.Name = "dataGridDemandDistributions";
            this.dataGridDemandDistributions.RowHeadersWidth = 51;
            this.dataGridDemandDistributions.RowTemplate.Height = 24;
            this.dataGridDemandDistributions.Size = new System.Drawing.Size(449, 316);
            this.dataGridDemandDistributions.TabIndex = 16;
            this.dataGridDemandDistributions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDemandDistributions_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "DayTypeDistributions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "DemandDistributions";
            // 
            // Demand
            // 
            this.Demand.HeaderText = "Demand";
            this.Demand.Name = "Demand";
            // 
            // Good
            // 
            this.Good.HeaderText = "Good";
            this.Good.Name = "Good";
            // 
            // Fair
            // 
            this.Fair.HeaderText = "Fair";
            this.Fair.Name = "Fair";
            // 
            // Poor
            // 
            this.Poor.HeaderText = "Poor";
            this.Poor.Name = "Poor";
            // 
            // NumOfNewspapersText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1026, 507);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridDemandDistributions);
            this.Controls.Add(this.SellingPriceText);
            this.Controls.Add(this.SellingPrice);
            this.Controls.Add(this.ScrapPriceText);
            this.Controls.Add(this.ScrapPrice);
            this.Controls.Add(this.PurchasePriceText);
            this.Controls.Add(this.PurchasePrice);
            this.Controls.Add(this.NumOfRecordsText);
            this.Controls.Add(this.NumOfRecords);
            this.Controls.Add(this.NumOfNewspaperstextBox);
            this.Controls.Add(this.NumOfNewspapers);
            this.Controls.Add(this.OpenTestCase);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridDayTypeDistribution);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NumOfNewspapersText";
            this.Text = "NumOfNewspapersText";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDayTypeDistribution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDemandDistributions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridDayTypeDistribution;
        private System.Windows.Forms.Button OpenTestCase;
        private System.Windows.Forms.Label NumOfNewspapers;
        private System.Windows.Forms.TextBox NumOfNewspaperstextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox NumOfRecordsText;
        private System.Windows.Forms.Label NumOfRecords;
        private System.Windows.Forms.TextBox PurchasePriceText;
        private System.Windows.Forms.Label PurchasePrice;
        private System.Windows.Forms.TextBox ScrapPriceText;
        private System.Windows.Forms.Label ScrapPrice;
        private System.Windows.Forms.TextBox SellingPriceText;
        private System.Windows.Forms.Label SellingPrice;
        private System.Windows.Forms.DataGridView dataGridDemandDistributions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probability;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Good;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fair;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poor;
    }
}
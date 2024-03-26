namespace WindowsFormsApplication1
{
    partial class Product_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Add));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboRegion_DB = new System.Windows.Forms.ComboBox();
            this.txtProPrice = new System.Windows.Forms.TextBox();
            this.txtProNum = new System.Windows.Forms.TextBox();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.label_DB = new System.Windows.Forms.Label();
            this.label_HDD = new System.Windows.Forms.Label();
            this.label_OS = new System.Windows.Forms.Label();
            this.labelProPrice = new System.Windows.Forms.Label();
            this.labelProNum = new System.Windows.Forms.Label();
            this.radioW = new System.Windows.Forms.RadioButton();
            this.cboRegion_Period = new System.Windows.Forms.ComboBox();
            this.cboRegion_HDD = new System.Windows.Forms.ComboBox();
            this.radioR = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pnlTop, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 45);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTop.BackgroundImage")));
            this.pnlTop.Controls.Add(this.btnClose2);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Location = new System.Drawing.Point(3, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(344, 34);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
            // 
            // btnClose2
            // 
            this.btnClose2.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnClose2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose2.BackgroundImage")));
            this.btnClose2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose2.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose2.Location = new System.Drawing.Point(300, 0);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(44, 34);
            this.btnClose2.TabIndex = 14;
            this.btnClose2.UseVisualStyleBackColor = false;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(519, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 34);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // cboRegion_DB
            // 
            this.cboRegion_DB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegion_DB.FormattingEnabled = true;
            this.cboRegion_DB.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "500",
            "1024"});
            this.cboRegion_DB.Location = new System.Drawing.Point(104, 143);
            this.cboRegion_DB.Name = "cboRegion_DB";
            this.cboRegion_DB.Size = new System.Drawing.Size(81, 20);
            this.cboRegion_DB.TabIndex = 23;
            // 
            // txtProPrice
            // 
            this.txtProPrice.Location = new System.Drawing.Point(104, 169);
            this.txtProPrice.Name = "txtProPrice";
            this.txtProPrice.Size = new System.Drawing.Size(81, 21);
            this.txtProPrice.TabIndex = 21;
            this.txtProPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProPrice_KeyPress);
            // 
            // txtProNum
            // 
            this.txtProNum.Location = new System.Drawing.Point(104, 64);
            this.txtProNum.Name = "txtProNum";
            this.txtProNum.Size = new System.Drawing.Size(81, 21);
            this.txtProNum.TabIndex = 22;
            this.txtProNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProNum_KeyPress);
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelPeriod.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelPeriod.ForeColor = System.Drawing.Color.White;
            this.labelPeriod.Location = new System.Drawing.Point(30, 199);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(29, 12);
            this.labelPeriod.TabIndex = 14;
            this.labelPeriod.Text = "기간";
            // 
            // label_DB
            // 
            this.label_DB.AutoSize = true;
            this.label_DB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label_DB.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_DB.ForeColor = System.Drawing.Color.White;
            this.label_DB.Location = new System.Drawing.Point(30, 146);
            this.label_DB.Name = "label_DB";
            this.label_DB.Size = new System.Drawing.Size(25, 12);
            this.label_DB.TabIndex = 16;
            this.label_DB.Text = "DB";
            // 
            // label_HDD
            // 
            this.label_HDD.AutoSize = true;
            this.label_HDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label_HDD.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_HDD.ForeColor = System.Drawing.Color.White;
            this.label_HDD.Location = new System.Drawing.Point(30, 119);
            this.label_HDD.Name = "label_HDD";
            this.label_HDD.Size = new System.Drawing.Size(35, 12);
            this.label_HDD.TabIndex = 17;
            this.label_HDD.Text = "HDD";
            // 
            // label_OS
            // 
            this.label_OS.AutoSize = true;
            this.label_OS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label_OS.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label_OS.ForeColor = System.Drawing.Color.White;
            this.label_OS.Location = new System.Drawing.Point(30, 94);
            this.label_OS.Name = "label_OS";
            this.label_OS.Size = new System.Drawing.Size(24, 12);
            this.label_OS.TabIndex = 18;
            this.label_OS.Text = "OS";
            // 
            // labelProPrice
            // 
            this.labelProPrice.AutoSize = true;
            this.labelProPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelProPrice.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelProPrice.ForeColor = System.Drawing.Color.White;
            this.labelProPrice.Location = new System.Drawing.Point(30, 172);
            this.labelProPrice.Name = "labelProPrice";
            this.labelProPrice.Size = new System.Drawing.Size(53, 12);
            this.labelProPrice.TabIndex = 19;
            this.labelProPrice.Text = "제품가격";
            // 
            // labelProNum
            // 
            this.labelProNum.AutoSize = true;
            this.labelProNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelProNum.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelProNum.ForeColor = System.Drawing.Color.White;
            this.labelProNum.Location = new System.Drawing.Point(30, 67);
            this.labelProNum.Name = "labelProNum";
            this.labelProNum.Size = new System.Drawing.Size(53, 12);
            this.labelProNum.TabIndex = 20;
            this.labelProNum.Text = "제품번호";
            // 
            // radioW
            // 
            this.radioW.AutoSize = true;
            this.radioW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.radioW.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioW.ForeColor = System.Drawing.Color.Red;
            this.radioW.Location = new System.Drawing.Point(169, 91);
            this.radioW.Name = "radioW";
            this.radioW.Size = new System.Drawing.Size(59, 16);
            this.radioW.TabIndex = 27;
            this.radioW.TabStop = true;
            this.radioW.Text = "윈도우";
            this.radioW.UseVisualStyleBackColor = false;
            // 
            // cboRegion_Period
            // 
            this.cboRegion_Period.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegion_Period.FormattingEnabled = true;
            this.cboRegion_Period.Items.AddRange(new object[] {
            "6개월",
            "1년",
            "2년",
            "3년"});
            this.cboRegion_Period.Location = new System.Drawing.Point(104, 196);
            this.cboRegion_Period.Name = "cboRegion_Period";
            this.cboRegion_Period.Size = new System.Drawing.Size(81, 20);
            this.cboRegion_Period.TabIndex = 24;
            // 
            // cboRegion_HDD
            // 
            this.cboRegion_HDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegion_HDD.FormattingEnabled = true;
            this.cboRegion_HDD.Items.AddRange(new object[] {
            "10",
            "30",
            "50",
            "80",
            "100"});
            this.cboRegion_HDD.Location = new System.Drawing.Point(104, 116);
            this.cboRegion_HDD.Name = "cboRegion_HDD";
            this.cboRegion_HDD.Size = new System.Drawing.Size(81, 20);
            this.cboRegion_HDD.TabIndex = 26;
            // 
            // radioR
            // 
            this.radioR.AutoSize = true;
            this.radioR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.radioR.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioR.ForeColor = System.Drawing.Color.Red;
            this.radioR.Location = new System.Drawing.Point(104, 92);
            this.radioR.Name = "radioR";
            this.radioR.Size = new System.Drawing.Size(59, 16);
            this.radioR.TabIndex = 28;
            this.radioR.TabStop = true;
            this.radioR.Text = "리눅스";
            this.radioR.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(297, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 50);
            this.btnSave.TabIndex = 29;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(191, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "GB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label2.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(191, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 12);
            this.label2.TabIndex = 30;
            this.label2.Text = "MB";
            // 
            // Product_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboRegion_DB);
            this.Controls.Add(this.txtProPrice);
            this.Controls.Add(this.txtProNum);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.label_DB);
            this.Controls.Add(this.label_HDD);
            this.Controls.Add(this.label_OS);
            this.Controls.Add(this.labelProPrice);
            this.Controls.Add(this.labelProNum);
            this.Controls.Add(this.radioW);
            this.Controls.Add(this.cboRegion_Period);
            this.Controls.Add(this.cboRegion_HDD);
            this.Controls.Add(this.radioR);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.ComboBox cboRegion_DB;
        private System.Windows.Forms.TextBox txtProPrice;
        private System.Windows.Forms.TextBox txtProNum;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Label label_DB;
        private System.Windows.Forms.Label label_HDD;
        private System.Windows.Forms.Label label_OS;
        private System.Windows.Forms.Label labelProPrice;
        private System.Windows.Forms.Label labelProNum;
        private System.Windows.Forms.RadioButton radioW;
        private System.Windows.Forms.ComboBox cboRegion_Period;
        private System.Windows.Forms.ComboBox cboRegion_HDD;
        private System.Windows.Forms.RadioButton radioR;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
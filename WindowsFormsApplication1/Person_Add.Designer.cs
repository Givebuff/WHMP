namespace WindowsFormsApplication1
{
    partial class Person_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Person_Add));
            this.txtEmNum = new System.Windows.Forms.TextBox();
            this.txtEmName = new System.Windows.Forms.TextBox();
            this.labelPW = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelEmNum = new System.Windows.Forms.Label();
            this.labelEmName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboPosition = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTnumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmNum
            // 
            this.txtEmNum.BackColor = System.Drawing.Color.White;
            this.txtEmNum.Location = new System.Drawing.Point(104, 91);
            this.txtEmNum.Name = "txtEmNum";
            this.txtEmNum.Size = new System.Drawing.Size(106, 21);
            this.txtEmNum.TabIndex = 11;
            this.txtEmNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmNum_KeyPress);
            // 
            // txtEmName
            // 
            this.txtEmName.Location = new System.Drawing.Point(104, 64);
            this.txtEmName.Name = "txtEmName";
            this.txtEmName.Size = new System.Drawing.Size(106, 21);
            this.txtEmName.TabIndex = 10;
            // 
            // labelPW
            // 
            this.labelPW.AutoSize = true;
            this.labelPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelPW.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelPW.ForeColor = System.Drawing.Color.White;
            this.labelPW.Location = new System.Drawing.Point(30, 175);
            this.labelPW.Name = "labelPW";
            this.labelPW.Size = new System.Drawing.Size(26, 12);
            this.labelPW.TabIndex = 5;
            this.labelPW.Text = "PW";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelID.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelID.ForeColor = System.Drawing.Color.White;
            this.labelID.Location = new System.Drawing.Point(30, 148);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(20, 12);
            this.labelID.TabIndex = 6;
            this.labelID.Text = "ID";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelPosition.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelPosition.ForeColor = System.Drawing.Color.White;
            this.labelPosition.Location = new System.Drawing.Point(30, 121);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(29, 12);
            this.labelPosition.TabIndex = 7;
            this.labelPosition.Text = "직급";
            // 
            // labelEmNum
            // 
            this.labelEmNum.AutoSize = true;
            this.labelEmNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelEmNum.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelEmNum.ForeColor = System.Drawing.Color.White;
            this.labelEmNum.Location = new System.Drawing.Point(30, 94);
            this.labelEmNum.Name = "labelEmNum";
            this.labelEmNum.Size = new System.Drawing.Size(53, 12);
            this.labelEmNum.TabIndex = 8;
            this.labelEmNum.Text = "전화번호";
            // 
            // labelEmName
            // 
            this.labelEmName.AutoSize = true;
            this.labelEmName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelEmName.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelEmName.ForeColor = System.Drawing.Color.White;
            this.labelEmName.Location = new System.Drawing.Point(30, 67);
            this.labelEmName.Name = "labelEmName";
            this.labelEmName.Size = new System.Drawing.Size(29, 12);
            this.labelEmName.TabIndex = 9;
            this.labelEmName.Text = "이름";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pnlTop, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 45);
            this.tableLayoutPanel1.TabIndex = 12;
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
            this.btnClose2.TabIndex = 11;
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
            // cboPosition
            // 
            this.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosition.FormattingEnabled = true;
            this.cboPosition.Items.AddRange(new object[] {
            "사장",
            "부장",
            "과장",
            "대리",
            "사원"});
            this.cboPosition.Location = new System.Drawing.Point(104, 118);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(106, 20);
            this.cboPosition.TabIndex = 13;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(104, 145);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(106, 21);
            this.txtID.TabIndex = 10;
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(104, 172);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(106, 21);
            this.txtPW.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "고유 번호";
            // 
            // txtTnumber
            // 
            this.txtTnumber.Location = new System.Drawing.Point(104, 200);
            this.txtTnumber.Name = "txtTnumber";
            this.txtTnumber.Size = new System.Drawing.Size(106, 21);
            this.txtTnumber.TabIndex = 16;
            this.txtTnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTnumber_KeyPress);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(298, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Person_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTnumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboPosition);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtEmNum);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtEmName);
            this.Controls.Add(this.labelPW);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelEmNum);
            this.Controls.Add(this.labelEmName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Person_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmNum;
        private System.Windows.Forms.TextBox txtEmName;
        private System.Windows.Forms.Label labelPW;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelEmNum;
        private System.Windows.Forms.Label labelEmName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.ComboBox cboPosition;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTnumber;
        private System.Windows.Forms.Button button1;
    }
}
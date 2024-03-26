namespace WindowsFormsApplication1
{
    partial class Customer_Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customer_Add));
            this.btnClose2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelCustomerNum = new System.Windows.Forms.Label();
            this.labelRepresentativeName = new System.Windows.Forms.Label();
            this.labelBusinessName = new System.Windows.Forms.Label();
            this.labelDealNum = new System.Windows.Forms.Label();
            this.txtCuProNum = new System.Windows.Forms.TextBox();
            this.txtCustomerNum = new System.Windows.Forms.TextBox();
            this.txtRepresentativeName = new System.Windows.Forms.TextBox();
            this.txtBusinessName = new System.Windows.Forms.TextBox();
            this.txtDealNum = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtIidentity = new System.Windows.Forms.TextBox();
            this.labelCuProNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
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
            this.btnClose2.TabIndex = 15;
            this.btnClose2.UseVisualStyleBackColor = false;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
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
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTop.BackgroundImage")));
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnClose2);
            this.pnlTop.Location = new System.Drawing.Point(3, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(344, 34);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            this.pnlTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseMove);
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
            // labelCustomerNum
            // 
            this.labelCustomerNum.AutoSize = true;
            this.labelCustomerNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelCustomerNum.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelCustomerNum.ForeColor = System.Drawing.Color.White;
            this.labelCustomerNum.Location = new System.Drawing.Point(30, 148);
            this.labelCustomerNum.Name = "labelCustomerNum";
            this.labelCustomerNum.Size = new System.Drawing.Size(53, 12);
            this.labelCustomerNum.TabIndex = 20;
            this.labelCustomerNum.Text = "전화번호";
            // 
            // labelRepresentativeName
            // 
            this.labelRepresentativeName.AutoSize = true;
            this.labelRepresentativeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelRepresentativeName.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelRepresentativeName.ForeColor = System.Drawing.Color.White;
            this.labelRepresentativeName.Location = new System.Drawing.Point(30, 121);
            this.labelRepresentativeName.Name = "labelRepresentativeName";
            this.labelRepresentativeName.Size = new System.Drawing.Size(53, 12);
            this.labelRepresentativeName.TabIndex = 24;
            this.labelRepresentativeName.Text = "대표자명";
            // 
            // labelBusinessName
            // 
            this.labelBusinessName.AutoSize = true;
            this.labelBusinessName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelBusinessName.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelBusinessName.ForeColor = System.Drawing.Color.White;
            this.labelBusinessName.Location = new System.Drawing.Point(30, 94);
            this.labelBusinessName.Name = "labelBusinessName";
            this.labelBusinessName.Size = new System.Drawing.Size(41, 12);
            this.labelBusinessName.TabIndex = 25;
            this.labelBusinessName.Text = "기업명";
            // 
            // labelDealNum
            // 
            this.labelDealNum.AutoSize = true;
            this.labelDealNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelDealNum.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelDealNum.ForeColor = System.Drawing.Color.White;
            this.labelDealNum.Location = new System.Drawing.Point(30, 67);
            this.labelDealNum.Name = "labelDealNum";
            this.labelDealNum.Size = new System.Drawing.Size(53, 12);
            this.labelDealNum.TabIndex = 26;
            this.labelDealNum.Text = "거래번호";
            // 
            // txtCuProNum
            // 
            this.txtCuProNum.Location = new System.Drawing.Point(131, 172);
            this.txtCuProNum.Name = "txtCuProNum";
            this.txtCuProNum.Size = new System.Drawing.Size(97, 21);
            this.txtCuProNum.TabIndex = 34;
            this.txtCuProNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuProNum_KeyPress);
            // 
            // txtCustomerNum
            // 
            this.txtCustomerNum.Location = new System.Drawing.Point(131, 145);
            this.txtCustomerNum.Name = "txtCustomerNum";
            this.txtCustomerNum.Size = new System.Drawing.Size(97, 21);
            this.txtCustomerNum.TabIndex = 35;
            this.txtCustomerNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerNum_KeyPress);
            // 
            // txtRepresentativeName
            // 
            this.txtRepresentativeName.Location = new System.Drawing.Point(131, 118);
            this.txtRepresentativeName.Name = "txtRepresentativeName";
            this.txtRepresentativeName.Size = new System.Drawing.Size(97, 21);
            this.txtRepresentativeName.TabIndex = 36;
            // 
            // txtBusinessName
            // 
            this.txtBusinessName.Location = new System.Drawing.Point(131, 91);
            this.txtBusinessName.Name = "txtBusinessName";
            this.txtBusinessName.Size = new System.Drawing.Size(97, 21);
            this.txtBusinessName.TabIndex = 37;
            // 
            // txtDealNum
            // 
            this.txtDealNum.Location = new System.Drawing.Point(131, 64);
            this.txtDealNum.Name = "txtDealNum";
            this.txtDealNum.Size = new System.Drawing.Size(97, 21);
            this.txtDealNum.TabIndex = 38;
            this.txtDealNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDealNum_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Location = new System.Drawing.Point(286, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 60);
            this.btnSave.TabIndex = 39;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtIidentity
            // 
            this.txtIidentity.Location = new System.Drawing.Point(132, 199);
            this.txtIidentity.Name = "txtIidentity";
            this.txtIidentity.Size = new System.Drawing.Size(96, 21);
            this.txtIidentity.TabIndex = 40;
            // 
            // labelCuProNum
            // 
            this.labelCuProNum.AutoSize = true;
            this.labelCuProNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.labelCuProNum.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelCuProNum.ForeColor = System.Drawing.Color.White;
            this.labelCuProNum.Location = new System.Drawing.Point(30, 175);
            this.labelCuProNum.Name = "labelCuProNum";
            this.labelCuProNum.Size = new System.Drawing.Size(53, 12);
            this.labelCuProNum.TabIndex = 23;
            this.labelCuProNum.Text = "제품번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Font = new System.Drawing.Font("HY견고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 12);
            this.label1.TabIndex = 41;
            this.label1.Text = "직원 고유 번호";
            // 
            // Customer_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIidentity);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCuProNum);
            this.Controls.Add(this.txtCustomerNum);
            this.Controls.Add(this.txtRepresentativeName);
            this.Controls.Add(this.txtBusinessName);
            this.Controls.Add(this.txtDealNum);
            this.Controls.Add(this.labelCustomerNum);
            this.Controls.Add(this.labelCuProNum);
            this.Controls.Add(this.labelRepresentativeName);
            this.Controls.Add(this.labelBusinessName);
            this.Controls.Add(this.labelDealNum);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer_Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form8";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelCustomerNum;
        private System.Windows.Forms.Label labelRepresentativeName;
        private System.Windows.Forms.Label labelBusinessName;
        private System.Windows.Forms.Label labelDealNum;
        private System.Windows.Forms.TextBox txtCuProNum;
        private System.Windows.Forms.TextBox txtCustomerNum;
        private System.Windows.Forms.TextBox txtRepresentativeName;
        private System.Windows.Forms.TextBox txtBusinessName;
        private System.Windows.Forms.TextBox txtDealNum;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtIidentity;
        private System.Windows.Forms.Label labelCuProNum;
        private System.Windows.Forms.Label label1;
    }
}
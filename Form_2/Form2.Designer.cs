namespace Form_2
{
    partial class Form2
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripChange = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextId = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSearchId = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelStatus = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textSex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBorn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonClean = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNew,
            this.toolStripDel,
            this.toolStripChange,
            this.toolStripSeparator1,
            this.toolStripTextId,
            this.toolStripSearchId,
            this.toolStripSeparator2,
            this.toolStripLabelStatus});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(409, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripNew
            // 
            this.toolStripNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNew.Image = global::Form_2.Properties.Resources.New;
            this.toolStripNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNew.Name = "toolStripNew";
            this.toolStripNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripNew.Text = "toolStripNew";
            this.toolStripNew.Click += new System.EventHandler(this.toolStripNew_Click);
            // 
            // toolStripDel
            // 
            this.toolStripDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDel.Image = global::Form_2.Properties.Resources.Del;
            this.toolStripDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDel.Name = "toolStripDel";
            this.toolStripDel.Size = new System.Drawing.Size(23, 22);
            this.toolStripDel.Text = "toolStripDel";
            this.toolStripDel.Click += new System.EventHandler(this.toolStripDel_Click);
            // 
            // toolStripChange
            // 
            this.toolStripChange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripChange.Image = global::Form_2.Properties.Resources.Update;
            this.toolStripChange.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripChange.Name = "toolStripChange";
            this.toolStripChange.Size = new System.Drawing.Size(23, 22);
            this.toolStripChange.Text = "toolStripChange";
            this.toolStripChange.Click += new System.EventHandler(this.toolStripChange_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextId
            // 
            this.toolStripTextId.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStripTextId.Name = "toolStripTextId";
            this.toolStripTextId.Size = new System.Drawing.Size(100, 25);
            this.toolStripTextId.Text = "请输入id";
            // 
            // toolStripSearchId
            // 
            this.toolStripSearchId.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSearchId.Image = global::Form_2.Properties.Resources.Search;
            this.toolStripSearchId.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSearchId.Name = "toolStripSearchId";
            this.toolStripSearchId.Size = new System.Drawing.Size(23, 22);
            this.toolStripSearchId.Text = "toolStripSearchId";
            this.toolStripSearchId.Click += new System.EventHandler(this.toolStripSearchId_Click);
            // 
            // toolStripLabelStatus
            // 
            this.toolStripLabelStatus.Name = "toolStripLabelStatus";
            this.toolStripLabelStatus.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "学号：";
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(80, 55);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 21);
            this.textId.TabIndex = 2;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(80, 82);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 21);
            this.textName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名：";
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(80, 109);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(100, 21);
            this.textAge.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "年龄：";
            // 
            // textSex
            // 
            this.textSex.Location = new System.Drawing.Point(80, 136);
            this.textSex.Name = "textSex";
            this.textSex.Size = new System.Drawing.Size(100, 21);
            this.textSex.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "性别：";
            // 
            // textBorn
            // 
            this.textBorn.Location = new System.Drawing.Point(285, 55);
            this.textBorn.Name = "textBorn";
            this.textBorn.Size = new System.Drawing.Size(100, 21);
            this.textBorn.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(228, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "出生年月：";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(285, 82);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(100, 21);
            this.textAddress.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "地址：";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(285, 109);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(100, 21);
            this.textPhone.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "电话：";
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(310, 134);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(75, 23);
            this.buttonClean.TabIndex = 15;
            this.buttonClean.Text = "重置数据库";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(360, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 307);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBorn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textSex);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textSex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBorn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripButton toolStripNew;
        private System.Windows.Forms.ToolStripButton toolStripDel;
        private System.Windows.Forms.ToolStripButton toolStripChange;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextId;
        private System.Windows.Forms.ToolStripButton toolStripSearchId;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
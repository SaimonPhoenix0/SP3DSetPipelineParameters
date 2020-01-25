namespace SP3DSetPipelineAttribute
{
    partial class FrmPipelineParameters
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOldDesignMinTemp = new System.Windows.Forms.TextBox();
            this.tbOldDesignMaxTemp = new System.Windows.Forms.TextBox();
            this.tbNewDesignMinTemp = new System.Windows.Forms.TextBox();
            this.tbNewDesignMaxTemp = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbOldDesignMinTemp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbOldDesignMaxTemp, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbNewDesignMinTemp, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbNewDesignMaxTemp, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnOk, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.07692F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(308, 228);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OldDesignMinTemp";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "OldDesignMaxTemp";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NewDesignMinTemp";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "NewDesignMaxTemp";
            // 
            // tbOldDesignMinTemp
            // 
            this.tbOldDesignMinTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOldDesignMinTemp.Location = new System.Drawing.Point(157, 11);
            this.tbOldDesignMinTemp.Name = "tbOldDesignMinTemp";
            this.tbOldDesignMinTemp.ReadOnly = true;
            this.tbOldDesignMinTemp.Size = new System.Drawing.Size(148, 20);
            this.tbOldDesignMinTemp.TabIndex = 4;
            // 
            // tbOldDesignMaxTemp
            // 
            this.tbOldDesignMaxTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOldDesignMaxTemp.Location = new System.Drawing.Point(157, 54);
            this.tbOldDesignMaxTemp.Name = "tbOldDesignMaxTemp";
            this.tbOldDesignMaxTemp.ReadOnly = true;
            this.tbOldDesignMaxTemp.Size = new System.Drawing.Size(148, 20);
            this.tbOldDesignMaxTemp.TabIndex = 5;
            // 
            // tbNewDesignMinTemp
            // 
            this.tbNewDesignMinTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewDesignMinTemp.Location = new System.Drawing.Point(157, 97);
            this.tbNewDesignMinTemp.Name = "tbNewDesignMinTemp";
            this.tbNewDesignMinTemp.Size = new System.Drawing.Size(148, 20);
            this.tbNewDesignMinTemp.TabIndex = 6;
            // 
            // tbNewDesignMaxTemp
            // 
            this.tbNewDesignMaxTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNewDesignMaxTemp.Location = new System.Drawing.Point(157, 140);
            this.tbNewDesignMaxTemp.Name = "tbNewDesignMaxTemp";
            this.tbNewDesignMaxTemp.Size = new System.Drawing.Size(148, 20);
            this.tbNewDesignMaxTemp.TabIndex = 7;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(230, 202);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FrmPipelineParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 228);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmPipelineParameters";
            this.Load += new System.EventHandler(this.FrmPipelineParameters_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbOldDesignMinTemp;
        private System.Windows.Forms.TextBox tbOldDesignMaxTemp;
        private System.Windows.Forms.TextBox tbNewDesignMinTemp;
        private System.Windows.Forms.TextBox tbNewDesignMaxTemp;
        private System.Windows.Forms.Button btnOk;
    }
}
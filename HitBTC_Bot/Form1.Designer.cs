﻿namespace HitBTC_Bot
{
    partial class Form1
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
            this.btn_Test_two = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbSymbolInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetSymbolnfo = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dgvCoinInfo = new System.Windows.Forms.DataGridView();
            this.tbHighPrice = new System.Windows.Forms.TextBox();
            this.btnCalcEMA = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnGetLastTen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoinInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Test_two
            // 
            this.btn_Test_two.Location = new System.Drawing.Point(12, 301);
            this.btn_Test_two.Name = "btn_Test_two";
            this.btn_Test_two.Size = new System.Drawing.Size(75, 23);
            this.btn_Test_two.TabIndex = 1;
            this.btn_Test_two.Text = "Test API";
            this.btn_Test_two.UseVisualStyleBackColor = true;
            this.btn_Test_two.Click += new System.EventHandler(this.btn_Test_two_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(856, 255);
            this.dataGridView1.TabIndex = 3;
            // 
            // tbSymbolInfo
            // 
            this.tbSymbolInfo.Location = new System.Drawing.Point(13, 365);
            this.tbSymbolInfo.Name = "tbSymbolInfo";
            this.tbSymbolInfo.Size = new System.Drawing.Size(165, 20);
            this.tbSymbolInfo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type Symbol";
            // 
            // btnGetSymbolnfo
            // 
            this.btnGetSymbolnfo.Location = new System.Drawing.Point(12, 392);
            this.btnGetSymbolnfo.Name = "btnGetSymbolnfo";
            this.btnGetSymbolnfo.Size = new System.Drawing.Size(166, 23);
            this.btnGetSymbolnfo.TabIndex = 6;
            this.btnGetSymbolnfo.Text = "Get Symbol Info";
            this.btnGetSymbolnfo.UseVisualStyleBackColor = true;
            this.btnGetSymbolnfo.Click += new System.EventHandler(this.btnGetSymbolnfo_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(198, 365);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(686, 71);
            this.dataGridView2.TabIndex = 7;
            // 
            // dgvCoinInfo
            // 
            this.dgvCoinInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCoinInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoinInfo.Location = new System.Drawing.Point(198, 466);
            this.dgvCoinInfo.Name = "dgvCoinInfo";
            this.dgvCoinInfo.Size = new System.Drawing.Size(686, 90);
            this.dgvCoinInfo.TabIndex = 8;
            // 
            // tbHighPrice
            // 
            this.tbHighPrice.Location = new System.Drawing.Point(198, 569);
            this.tbHighPrice.Name = "tbHighPrice";
            this.tbHighPrice.Size = new System.Drawing.Size(122, 20);
            this.tbHighPrice.TabIndex = 9;
            // 
            // btnCalcEMA
            // 
            this.btnCalcEMA.Location = new System.Drawing.Point(16, 436);
            this.btnCalcEMA.Name = "btnCalcEMA";
            this.btnCalcEMA.Size = new System.Drawing.Size(85, 23);
            this.btnCalcEMA.TabIndex = 10;
            this.btnCalcEMA.Text = "Get EMA";
            this.btnCalcEMA.UseVisualStyleBackColor = true;
            this.btnCalcEMA.Click += new System.EventHandler(this.btnCalcEMA_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Write one";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Write two";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 532);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "CaputeData";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnGetLastTen
            // 
            this.btnGetLastTen.Location = new System.Drawing.Point(16, 562);
            this.btnGetLastTen.Name = "btnGetLastTen";
            this.btnGetLastTen.Size = new System.Drawing.Size(75, 23);
            this.btnGetLastTen.TabIndex = 14;
            this.btnGetLastTen.Text = "last 10";
            this.btnGetLastTen.UseVisualStyleBackColor = true;
            this.btnGetLastTen.Click += new System.EventHandler(this.btnGetLastTen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 601);
            this.Controls.Add(this.btnGetLastTen);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCalcEMA);
            this.Controls.Add(this.tbHighPrice);
            this.Controls.Add(this.dgvCoinInfo);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnGetSymbolnfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSymbolInfo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Test_two);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoinInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Test_two;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbSymbolInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetSymbolnfo;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dgvCoinInfo;
        private System.Windows.Forms.TextBox tbHighPrice;
        private System.Windows.Forms.Button btnCalcEMA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnGetLastTen;
    }
}


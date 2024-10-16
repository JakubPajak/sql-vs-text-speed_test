namespace PDB_SpeedTest
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_submitAmount = new System.Windows.Forms.Button();
            this.txtBox_outputAmount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBox_inputAmount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.lbl_TimeTxt = new System.Windows.Forms.Label();
            this.lbl_TimeBin = new System.Windows.Forms.Label();
            this.lbl_TimeCSV = new System.Windows.Forms.Label();
            this.lbl_TimeSQL = new System.Windows.Forms.Label();
            this.lbl_InputWarning = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_TimeSQL, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_TimeTxt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_TimeCSV, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_TimeBin, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(50, 536);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.9992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0032F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1080, 278);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Plik (.csv)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(813, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Rozmiar pliku w bajtach";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Czas zapisu do pliku";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Plik (.bin)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Czas odczytu z pliku";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Plik (.txt)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Typ pliku";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "MS SQL";
            // 
            // btn_submitAmount
            // 
            this.btn_submitAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_submitAmount.Location = new System.Drawing.Point(1174, 435);
            this.btn_submitAmount.Margin = new System.Windows.Forms.Padding(4);
            this.btn_submitAmount.Name = "btn_submitAmount";
            this.btn_submitAmount.Size = new System.Drawing.Size(175, 56);
            this.btn_submitAmount.TabIndex = 12;
            this.btn_submitAmount.Text = "Zatwierdź";
            this.btn_submitAmount.UseVisualStyleBackColor = true;
            this.btn_submitAmount.Click += new System.EventHandler(this.btn_submitAmount_Click);
            // 
            // txtBox_outputAmount
            // 
            this.txtBox_outputAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBox_outputAmount.Location = new System.Drawing.Point(909, 445);
            this.txtBox_outputAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_outputAmount.Name = "txtBox_outputAmount";
            this.txtBox_outputAmount.Size = new System.Drawing.Size(221, 31);
            this.txtBox_outputAmount.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(619, 451);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(292, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Liczba rekordów do odczytu: ";
            // 
            // txtBox_inputAmount
            // 
            this.txtBox_inputAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtBox_inputAmount.Location = new System.Drawing.Point(352, 445);
            this.txtBox_inputAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_inputAmount.Name = "txtBox_inputAmount";
            this.txtBox_inputAmount.Size = new System.Drawing.Size(239, 31);
            this.txtBox_inputAmount.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(53, 448);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(305, 25);
            this.label11.TabIndex = 8;
            this.label11.Text = "Liczba rekordów do generacji: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(1386, 435);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 56);
            this.button1.TabIndex = 13;
            this.button1.Text = "Wczytaj dane z pliku";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // lbl_TimeTxt
            // 
            this.lbl_TimeTxt.AutoSize = true;
            this.lbl_TimeTxt.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.lbl_TimeTxt.Location = new System.Drawing.Point(273, 55);
            this.lbl_TimeTxt.Name = "lbl_TimeTxt";
            this.lbl_TimeTxt.Size = new System.Drawing.Size(56, 25);
            this.lbl_TimeTxt.TabIndex = 14;
            this.lbl_TimeTxt.Text = "ssss";
            // 
            // lbl_TimeBin
            // 
            this.lbl_TimeBin.AutoSize = true;
            this.lbl_TimeBin.Location = new System.Drawing.Point(273, 110);
            this.lbl_TimeBin.Name = "lbl_TimeBin";
            this.lbl_TimeBin.Size = new System.Drawing.Size(70, 25);
            this.lbl_TimeBin.TabIndex = 14;
            this.lbl_TimeBin.Text = "label7";
            // 
            // lbl_TimeCSV
            // 
            this.lbl_TimeCSV.AutoSize = true;
            this.lbl_TimeCSV.Location = new System.Drawing.Point(273, 165);
            this.lbl_TimeCSV.Name = "lbl_TimeCSV";
            this.lbl_TimeCSV.Size = new System.Drawing.Size(82, 25);
            this.lbl_TimeCSV.TabIndex = 15;
            this.lbl_TimeCSV.Text = "label12";
            // 
            // lbl_TimeSQL
            // 
            this.lbl_TimeSQL.AutoSize = true;
            this.lbl_TimeSQL.Location = new System.Drawing.Point(273, 220);
            this.lbl_TimeSQL.Name = "lbl_TimeSQL";
            this.lbl_TimeSQL.Size = new System.Drawing.Size(82, 25);
            this.lbl_TimeSQL.TabIndex = 16;
            this.lbl_TimeSQL.Text = "label13";
            // 
            // lbl_InputWarning
            // 
            this.lbl_InputWarning.AutoSize = true;
            this.lbl_InputWarning.Location = new System.Drawing.Point(1216, 495);
            this.lbl_InputWarning.Name = "lbl_InputWarning";
            this.lbl_InputWarning.Size = new System.Drawing.Size(70, 25);
            this.lbl_InputWarning.TabIndex = 14;
            this.lbl_InputWarning.Text = "label7";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.lbl_InputWarning);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_submitAmount);
            this.Controls.Add(this.txtBox_outputAmount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBox_inputAmount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_submitAmount;
        private System.Windows.Forms.TextBox txtBox_outputAmount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBox_inputAmount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label lbl_TimeTxt;
        private System.Windows.Forms.Label lbl_TimeCSV;
        private System.Windows.Forms.Label lbl_TimeBin;
        private System.Windows.Forms.Label lbl_TimeSQL;
        private System.Windows.Forms.Label lbl_InputWarning;
    }
}
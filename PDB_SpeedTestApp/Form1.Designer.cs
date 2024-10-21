namespace PDB_SpeedTestApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_ReadSQL = new Label();
            lbl_ReadCsv = new Label();
            lbl_CSVSize = new Label();
            lbl_TimeSQL = new Label();
            lbl_ReadBin = new Label();
            lbl_SQLSize = new Label();
            lbl_ReadTxt = new Label();
            lbl_TimeTxt = new Label();
            label11 = new Label();
            lbl_TimeCSV = new Label();
            lbl_BinSize = new Label();
            label9 = new Label();
            lbl_TxtSize = new Label();
            lbl_TimeBin = new Label();
            label8 = new Label();
            label10 = new Label();
            label4 = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtBox_inputAmount = new TextBox();
            txtBox_outputAmount = new TextBox();
            btn_submitAmount = new Button();
            lbl_InputWarning = new Label();
            submitWrite = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 316);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(252, 25);
            label2.TabIndex = 1;
            label2.Text = "Liczba rekordów do generacji: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(639, 312);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(245, 25);
            label3.TabIndex = 2;
            label3.Text = "Liczba rekordów do odczytu: ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(lbl_ReadSQL, 2, 4);
            tableLayoutPanel1.Controls.Add(lbl_ReadCsv, 2, 3);
            tableLayoutPanel1.Controls.Add(lbl_CSVSize, 3, 3);
            tableLayoutPanel1.Controls.Add(lbl_TimeSQL, 1, 4);
            tableLayoutPanel1.Controls.Add(lbl_ReadBin, 2, 2);
            tableLayoutPanel1.Controls.Add(lbl_SQLSize, 3, 4);
            tableLayoutPanel1.Controls.Add(lbl_ReadTxt, 2, 1);
            tableLayoutPanel1.Controls.Add(lbl_TimeTxt, 1, 1);
            tableLayoutPanel1.Controls.Add(label11, 3, 0);
            tableLayoutPanel1.Controls.Add(lbl_TimeCSV, 1, 3);
            tableLayoutPanel1.Controls.Add(lbl_BinSize, 3, 2);
            tableLayoutPanel1.Controls.Add(label9, 1, 0);
            tableLayoutPanel1.Controls.Add(lbl_TxtSize, 3, 1);
            tableLayoutPanel1.Controls.Add(lbl_TimeBin, 1, 2);
            tableLayoutPanel1.Controls.Add(label8, 2, 0);
            tableLayoutPanel1.Controls.Add(label10, 0, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(label7, 0, 4);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Location = new Point(126, 421);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(992, 237);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // lbl_ReadSQL
            // 
            lbl_ReadSQL.AutoSize = true;
            lbl_ReadSQL.Location = new Point(498, 188);
            lbl_ReadSQL.Margin = new Padding(2, 0, 2, 0);
            lbl_ReadSQL.Name = "lbl_ReadSQL";
            lbl_ReadSQL.Size = new Size(69, 25);
            lbl_ReadSQL.TabIndex = 12;
            lbl_ReadSQL.Text = "label14";
            // 
            // lbl_ReadCsv
            // 
            lbl_ReadCsv.AutoSize = true;
            lbl_ReadCsv.Location = new Point(498, 141);
            lbl_ReadCsv.Margin = new Padding(2, 0, 2, 0);
            lbl_ReadCsv.Name = "lbl_ReadCsv";
            lbl_ReadCsv.Size = new Size(69, 25);
            lbl_ReadCsv.TabIndex = 13;
            lbl_ReadCsv.Text = "label15";
            // 
            // lbl_CSVSize
            // 
            lbl_CSVSize.AutoSize = true;
            lbl_CSVSize.Location = new Point(746, 141);
            lbl_CSVSize.Margin = new Padding(2, 0, 2, 0);
            lbl_CSVSize.Name = "lbl_CSVSize";
            lbl_CSVSize.Size = new Size(69, 25);
            lbl_CSVSize.TabIndex = 14;
            lbl_CSVSize.Text = "label17";
            // 
            // lbl_TimeSQL
            // 
            lbl_TimeSQL.AutoSize = true;
            lbl_TimeSQL.Location = new Point(250, 188);
            lbl_TimeSQL.Margin = new Padding(2, 0, 2, 0);
            lbl_TimeSQL.Name = "lbl_TimeSQL";
            lbl_TimeSQL.Size = new Size(69, 25);
            lbl_TimeSQL.TabIndex = 10;
            lbl_TimeSQL.Text = "label15";
            // 
            // lbl_ReadBin
            // 
            lbl_ReadBin.AutoSize = true;
            lbl_ReadBin.Location = new Point(498, 94);
            lbl_ReadBin.Margin = new Padding(2, 0, 2, 0);
            lbl_ReadBin.Name = "lbl_ReadBin";
            lbl_ReadBin.Size = new Size(69, 25);
            lbl_ReadBin.TabIndex = 11;
            lbl_ReadBin.Text = "label13";
            // 
            // lbl_SQLSize
            // 
            lbl_SQLSize.AutoSize = true;
            lbl_SQLSize.Location = new Point(746, 188);
            lbl_SQLSize.Margin = new Padding(2, 0, 2, 0);
            lbl_SQLSize.Name = "lbl_SQLSize";
            lbl_SQLSize.Size = new Size(69, 25);
            lbl_SQLSize.TabIndex = 12;
            lbl_SQLSize.Text = "label14";
            // 
            // lbl_ReadTxt
            // 
            lbl_ReadTxt.AutoSize = true;
            lbl_ReadTxt.Location = new Point(498, 47);
            lbl_ReadTxt.Margin = new Padding(2, 0, 2, 0);
            lbl_ReadTxt.Name = "lbl_ReadTxt";
            lbl_ReadTxt.Size = new Size(69, 25);
            lbl_ReadTxt.TabIndex = 10;
            lbl_ReadTxt.Text = "label12";
            // 
            // lbl_TimeTxt
            // 
            lbl_TimeTxt.AutoSize = true;
            lbl_TimeTxt.Location = new Point(250, 47);
            lbl_TimeTxt.Margin = new Padding(2, 0, 2, 0);
            lbl_TimeTxt.Name = "lbl_TimeTxt";
            lbl_TimeTxt.Size = new Size(69, 25);
            lbl_TimeTxt.TabIndex = 7;
            lbl_TimeTxt.Text = "label12";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(746, 0);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(199, 25);
            label11.TabIndex = 8;
            label11.Text = "Rozmiar pliku w bajtach";
            // 
            // lbl_TimeCSV
            // 
            lbl_TimeCSV.AutoSize = true;
            lbl_TimeCSV.Location = new Point(250, 141);
            lbl_TimeCSV.Margin = new Padding(2, 0, 2, 0);
            lbl_TimeCSV.Name = "lbl_TimeCSV";
            lbl_TimeCSV.Size = new Size(69, 25);
            lbl_TimeCSV.TabIndex = 8;
            lbl_TimeCSV.Text = "label13";
            // 
            // lbl_BinSize
            // 
            lbl_BinSize.AutoSize = true;
            lbl_BinSize.Location = new Point(746, 94);
            lbl_BinSize.Margin = new Padding(2, 0, 2, 0);
            lbl_BinSize.Name = "lbl_BinSize";
            lbl_BinSize.Size = new Size(69, 25);
            lbl_BinSize.TabIndex = 11;
            lbl_BinSize.Text = "label13";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(250, 0);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(173, 25);
            label9.TabIndex = 8;
            label9.Text = "Czas zapisu do pliku";
            // 
            // lbl_TxtSize
            // 
            lbl_TxtSize.AutoSize = true;
            lbl_TxtSize.Location = new Point(746, 47);
            lbl_TxtSize.Margin = new Padding(2, 0, 2, 0);
            lbl_TxtSize.Name = "lbl_TxtSize";
            lbl_TxtSize.Size = new Size(69, 25);
            lbl_TxtSize.TabIndex = 10;
            lbl_TxtSize.Text = "label12";
            // 
            // lbl_TimeBin
            // 
            lbl_TimeBin.AutoSize = true;
            lbl_TimeBin.Location = new Point(250, 94);
            lbl_TimeBin.Margin = new Padding(2, 0, 2, 0);
            lbl_TimeBin.Name = "lbl_TimeBin";
            lbl_TimeBin.Size = new Size(69, 25);
            lbl_TimeBin.TabIndex = 7;
            lbl_TimeBin.Text = "label12";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(498, 0);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(172, 25);
            label8.TabIndex = 7;
            label8.Text = "Czas odczytu z pliku";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(2, 141);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(83, 25);
            label10.TabIndex = 9;
            label10.Text = "Plik (.csv)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 0);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 4;
            label4.Text = "Typ pliku";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2, 188);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(75, 25);
            label7.TabIndex = 6;
            label7.Text = "MS SQL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 47);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(78, 25);
            label5.TabIndex = 4;
            label5.Text = "Plik (.txt)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 94);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 25);
            label6.TabIndex = 5;
            label6.Text = "Plik (.bin)";
            // 
            // txtBox_inputAmount
            // 
            txtBox_inputAmount.Location = new Point(378, 316);
            txtBox_inputAmount.Margin = new Padding(2);
            txtBox_inputAmount.Name = "txtBox_inputAmount";
            txtBox_inputAmount.Size = new Size(92, 31);
            txtBox_inputAmount.TabIndex = 4;
            // 
            // txtBox_outputAmount
            // 
            txtBox_outputAmount.Location = new Point(886, 312);
            txtBox_outputAmount.Margin = new Padding(2);
            txtBox_outputAmount.Name = "txtBox_outputAmount";
            txtBox_outputAmount.Size = new Size(99, 31);
            txtBox_outputAmount.TabIndex = 5;
            // 
            // btn_submitAmount
            // 
            btn_submitAmount.Location = new Point(1004, 312);
            btn_submitAmount.Margin = new Padding(2);
            btn_submitAmount.Name = "btn_submitAmount";
            btn_submitAmount.Size = new Size(115, 36);
            btn_submitAmount.TabIndex = 6;
            btn_submitAmount.Text = "Zatwierdź";
            btn_submitAmount.UseVisualStyleBackColor = true;
            btn_submitAmount.Click += btn_submitAmount_Click_1;
            // 
            // lbl_InputWarning
            // 
            lbl_InputWarning.AutoSize = true;
            lbl_InputWarning.Location = new Point(925, 365);
            lbl_InputWarning.Margin = new Padding(2, 0, 2, 0);
            lbl_InputWarning.Name = "lbl_InputWarning";
            lbl_InputWarning.Size = new Size(69, 25);
            lbl_InputWarning.TabIndex = 9;
            lbl_InputWarning.Text = "label14";
            // 
            // submitWrite
            // 
            submitWrite.Location = new Point(486, 313);
            submitWrite.Margin = new Padding(2);
            submitWrite.Name = "submitWrite";
            submitWrite.Size = new Size(115, 36);
            submitWrite.TabIndex = 10;
            submitWrite.Text = "Zatwierdź";
            submitWrite.UseVisualStyleBackColor = true;
            submitWrite.Click += submitWrite_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1457, 788);
            Controls.Add(submitWrite);
            Controls.Add(lbl_InputWarning);
            Controls.Add(btn_submitAmount);
            Controls.Add(txtBox_outputAmount);
            Controls.Add(txtBox_inputAmount);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label9;
        private Label label10;
        private Label label4;
        private Label label7;
        private Label label5;
        private Label label6;
        private Label label8;
        private Label label11;
        private TextBox txtBox_inputAmount;
        private TextBox txtBox_outputAmount;
        private Button btn_submitAmount;
        private Label lbl_TimeSQL;
        private Label lbl_TimeTxt;
        private Label lbl_TimeCSV;
        private Label lbl_TimeBin;
        private Label lbl_InputWarning;
        private Label lbl_CSVSize;
        private Label lbl_SQLSize;
        private Label lbl_BinSize;
        private Label lbl_TxtSize;
        private Label lbl_ReadSQL;
        private Label lbl_ReadCsv;
        private Label lbl_ReadBin;
        private Label lbl_ReadTxt;
        private Button submitWrite;
    }
}

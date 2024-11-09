namespace PDB_SpeedTestApp
{
    partial class ReadWriteSpeedTest
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
            tableLayoutPanel12 = new TableLayoutPanel();
            sqlSpeedBar2 = new ProgressBar();
            sqlSpeedLb2 = new Label();
            tableLayoutPanel11 = new TableLayoutPanel();
            csvSpeedBar2 = new ProgressBar();
            csvSpeedLb2 = new Label();
            tableLayoutPanel10 = new TableLayoutPanel();
            binSpeedBar2 = new ProgressBar();
            binSpeedLb2 = new Label();
            tableLayoutPanel9 = new TableLayoutPanel();
            txtSpeedLb2 = new Label();
            txtSpeedBar2 = new ProgressBar();
            tableLayoutPanel8 = new TableLayoutPanel();
            sqlSpeedLb = new Label();
            sqlSpeedBar = new ProgressBar();
            tableLayoutPanel7 = new TableLayoutPanel();
            csvSpeedBar = new ProgressBar();
            csvSpeedLb = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            binSpeedBar = new ProgressBar();
            binSpeedLb = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtSpeedBar = new ProgressBar();
            txtSpeedLb = new Label();
            lbl_ReadSQL = new Label();
            lbl_TimeSQL = new Label();
            lbl_TimeTxt = new Label();
            lbl_ReadCsv = new Label();
            lbl_TimeCSV = new Label();
            label8 = new Label();
            label9 = new Label();
            lbl_ReadBin = new Label();
            lbl_TimeBin = new Label();
            label10 = new Label();
            label4 = new Label();
            lbl_ReadTxt = new Label();
            label7 = new Label();
            label5 = new Label();
            label6 = new Label();
            label11 = new Label();
            lbl_TxtSize = new Label();
            lbl_BinSize = new Label();
            lbl_CSVSize = new Label();
            lbl_SQLSize = new Label();
            label12 = new Label();
            label14 = new Label();
            txtBox_inputAmount = new TextBox();
            txtBox_outputAmount = new TextBox();
            btn_submitAmount = new Button();
            submitWrite = new Button();
            lbl_InputWarning = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(450, 148);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(556, 39);
            label1.TabIndex = 0;
            label1.Text = "Test szybkości odczytu oraz zapisu plików";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(262, 299);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(227, 22);
            label2.TabIndex = 1;
            label2.Text = "Liczba rekordów do generacji: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(763, 299);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(212, 22);
            label3.TabIndex = 2;
            label3.Text = "Liczba rekordów do odczytu: ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel12, 4, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel11, 4, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel10, 4, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel9, 4, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel8, 2, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 2, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 2, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 1);
            tableLayoutPanel1.Controls.Add(lbl_ReadSQL, 3, 4);
            tableLayoutPanel1.Controls.Add(lbl_TimeSQL, 1, 4);
            tableLayoutPanel1.Controls.Add(lbl_TimeTxt, 1, 1);
            tableLayoutPanel1.Controls.Add(lbl_ReadCsv, 3, 3);
            tableLayoutPanel1.Controls.Add(lbl_TimeCSV, 1, 3);
            tableLayoutPanel1.Controls.Add(label8, 3, 0);
            tableLayoutPanel1.Controls.Add(label9, 1, 0);
            tableLayoutPanel1.Controls.Add(lbl_ReadBin, 3, 2);
            tableLayoutPanel1.Controls.Add(lbl_TimeBin, 1, 2);
            tableLayoutPanel1.Controls.Add(label10, 0, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl_ReadTxt, 3, 1);
            tableLayoutPanel1.Controls.Add(label7, 0, 4);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(label11, 5, 0);
            tableLayoutPanel1.Controls.Add(lbl_TxtSize, 5, 1);
            tableLayoutPanel1.Controls.Add(lbl_BinSize, 5, 2);
            tableLayoutPanel1.Controls.Add(lbl_CSVSize, 5, 3);
            tableLayoutPanel1.Controls.Add(lbl_SQLSize, 5, 4);
            tableLayoutPanel1.Controls.Add(label12, 2, 0);
            tableLayoutPanel1.Controls.Add(label14, 4, 0);
            tableLayoutPanel1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tableLayoutPanel1.Location = new Point(178, 421);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1100, 237);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Controls.Add(sqlSpeedBar2, 0, 0);
            tableLayoutPanel12.Controls.Add(sqlSpeedLb2, 0, 1);
            tableLayoutPanel12.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tableLayoutPanel12.Location = new Point(736, 192);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 2;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel12.Size = new Size(158, 41);
            tableLayoutPanel12.TabIndex = 18;
            // 
            // sqlSpeedBar2
            // 
            sqlSpeedBar2.Location = new Point(3, 3);
            sqlSpeedBar2.Name = "sqlSpeedBar2";
            sqlSpeedBar2.Size = new Size(150, 14);
            sqlSpeedBar2.TabIndex = 12;
            // 
            // sqlSpeedLb2
            // 
            sqlSpeedLb2.AutoSize = true;
            sqlSpeedLb2.Location = new Point(3, 20);
            sqlSpeedLb2.Name = "sqlSpeedLb2";
            sqlSpeedLb2.Size = new Size(68, 21);
            sqlSpeedLb2.TabIndex = 14;
            sqlSpeedLb2.Text = "10 MB/s";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 1;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(csvSpeedBar2, 0, 0);
            tableLayoutPanel11.Controls.Add(csvSpeedLb2, 0, 1);
            tableLayoutPanel11.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tableLayoutPanel11.Location = new Point(736, 145);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 2;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Size = new Size(158, 40);
            tableLayoutPanel11.TabIndex = 18;
            // 
            // csvSpeedBar2
            // 
            csvSpeedBar2.Location = new Point(3, 3);
            csvSpeedBar2.Name = "csvSpeedBar2";
            csvSpeedBar2.Size = new Size(150, 14);
            csvSpeedBar2.TabIndex = 15;
            // 
            // csvSpeedLb2
            // 
            csvSpeedLb2.AutoSize = true;
            csvSpeedLb2.Location = new Point(3, 20);
            csvSpeedLb2.Name = "csvSpeedLb2";
            csvSpeedLb2.Size = new Size(61, 20);
            csvSpeedLb2.TabIndex = 16;
            csvSpeedLb2.Text = "label17";
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(binSpeedBar2, 0, 0);
            tableLayoutPanel10.Controls.Add(binSpeedLb2, 0, 1);
            tableLayoutPanel10.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tableLayoutPanel10.Location = new Point(736, 98);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 2;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(158, 40);
            tableLayoutPanel10.TabIndex = 18;
            // 
            // binSpeedBar2
            // 
            binSpeedBar2.Location = new Point(3, 3);
            binSpeedBar2.Name = "binSpeedBar2";
            binSpeedBar2.Size = new Size(150, 14);
            binSpeedBar2.TabIndex = 16;
            // 
            // binSpeedLb2
            // 
            binSpeedLb2.AutoSize = true;
            binSpeedLb2.Location = new Point(3, 20);
            binSpeedLb2.Name = "binSpeedLb2";
            binSpeedLb2.Size = new Size(61, 20);
            binSpeedLb2.TabIndex = 17;
            binSpeedLb2.Text = "label16";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(txtSpeedLb2, 0, 1);
            tableLayoutPanel9.Controls.Add(txtSpeedBar2, 0, 0);
            tableLayoutPanel9.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tableLayoutPanel9.Location = new Point(736, 51);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 2;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new Size(158, 40);
            tableLayoutPanel9.TabIndex = 18;
            // 
            // txtSpeedLb2
            // 
            txtSpeedLb2.AutoSize = true;
            txtSpeedLb2.Location = new Point(3, 20);
            txtSpeedLb2.Name = "txtSpeedLb2";
            txtSpeedLb2.Size = new Size(61, 20);
            txtSpeedLb2.TabIndex = 15;
            txtSpeedLb2.Text = "label15";
            // 
            // txtSpeedBar2
            // 
            txtSpeedBar2.Location = new Point(3, 3);
            txtSpeedBar2.Name = "txtSpeedBar2";
            txtSpeedBar2.Size = new Size(150, 14);
            txtSpeedBar2.TabIndex = 17;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(sqlSpeedLb, 0, 1);
            tableLayoutPanel8.Controls.Add(sqlSpeedBar, 0, 0);
            tableLayoutPanel8.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tableLayoutPanel8.Location = new Point(370, 192);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(158, 41);
            tableLayoutPanel8.TabIndex = 18;
            // 
            // sqlSpeedLb
            // 
            sqlSpeedLb.AutoSize = true;
            sqlSpeedLb.Location = new Point(3, 20);
            sqlSpeedLb.Name = "sqlSpeedLb";
            sqlSpeedLb.Size = new Size(61, 21);
            sqlSpeedLb.TabIndex = 17;
            sqlSpeedLb.Text = "label17";
            // 
            // sqlSpeedBar
            // 
            sqlSpeedBar.Location = new Point(3, 3);
            sqlSpeedBar.Name = "sqlSpeedBar";
            sqlSpeedBar.Size = new Size(150, 14);
            sqlSpeedBar.TabIndex = 15;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(csvSpeedBar, 0, 0);
            tableLayoutPanel7.Controls.Add(csvSpeedLb, 0, 1);
            tableLayoutPanel7.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tableLayoutPanel7.Location = new Point(370, 145);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(158, 40);
            tableLayoutPanel7.TabIndex = 18;
            // 
            // csvSpeedBar
            // 
            csvSpeedBar.Location = new Point(3, 3);
            csvSpeedBar.Name = "csvSpeedBar";
            csvSpeedBar.Size = new Size(150, 14);
            csvSpeedBar.TabIndex = 16;
            // 
            // csvSpeedLb
            // 
            csvSpeedLb.AutoSize = true;
            csvSpeedLb.Location = new Point(3, 20);
            csvSpeedLb.Name = "csvSpeedLb";
            csvSpeedLb.Size = new Size(61, 20);
            csvSpeedLb.TabIndex = 16;
            csvSpeedLb.Text = "label16";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(binSpeedBar, 0, 0);
            tableLayoutPanel3.Controls.Add(binSpeedLb, 0, 1);
            tableLayoutPanel3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tableLayoutPanel3.Location = new Point(370, 98);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(158, 40);
            tableLayoutPanel3.TabIndex = 15;
            // 
            // binSpeedBar
            // 
            binSpeedBar.Location = new Point(3, 3);
            binSpeedBar.Name = "binSpeedBar";
            binSpeedBar.Size = new Size(150, 14);
            binSpeedBar.TabIndex = 17;
            // 
            // binSpeedLb
            // 
            binSpeedLb.AutoSize = true;
            binSpeedLb.Location = new Point(3, 20);
            binSpeedLb.Name = "binSpeedLb";
            binSpeedLb.Size = new Size(61, 20);
            binSpeedLb.TabIndex = 15;
            binSpeedLb.Text = "label15";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(txtSpeedBar, 0, 0);
            tableLayoutPanel2.Controls.Add(txtSpeedLb, 0, 1);
            tableLayoutPanel2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tableLayoutPanel2.Location = new Point(370, 51);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(158, 40);
            tableLayoutPanel2.TabIndex = 15;
            // 
            // txtSpeedBar
            // 
            txtSpeedBar.Location = new Point(3, 3);
            txtSpeedBar.Name = "txtSpeedBar";
            txtSpeedBar.Size = new Size(150, 14);
            txtSpeedBar.TabIndex = 11;
            txtSpeedBar.Text = "hello";
            // 
            // txtSpeedLb
            // 
            txtSpeedLb.AutoSize = true;
            txtSpeedLb.BackColor = Color.Transparent;
            txtSpeedLb.Location = new Point(3, 20);
            txtSpeedLb.Name = "txtSpeedLb";
            txtSpeedLb.Size = new Size(59, 20);
            txtSpeedLb.TabIndex = 13;
            txtSpeedLb.Text = "5 MB/s";
            txtSpeedLb.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_ReadSQL
            // 
            lbl_ReadSQL.AutoSize = true;
            lbl_ReadSQL.Location = new Point(552, 189);
            lbl_ReadSQL.Margin = new Padding(2, 0, 2, 0);
            lbl_ReadSQL.Name = "lbl_ReadSQL";
            lbl_ReadSQL.Size = new Size(76, 28);
            lbl_ReadSQL.TabIndex = 12;
            lbl_ReadSQL.Text = "label14";
            // 
            // lbl_TimeSQL
            // 
            lbl_TimeSQL.AutoSize = true;
            lbl_TimeSQL.Location = new Point(186, 189);
            lbl_TimeSQL.Margin = new Padding(2, 0, 2, 0);
            lbl_TimeSQL.Name = "lbl_TimeSQL";
            lbl_TimeSQL.Size = new Size(76, 28);
            lbl_TimeSQL.TabIndex = 10;
            lbl_TimeSQL.Text = "label15";
            // 
            // lbl_TimeTxt
            // 
            lbl_TimeTxt.AutoSize = true;
            lbl_TimeTxt.Location = new Point(186, 48);
            lbl_TimeTxt.Margin = new Padding(2, 0, 2, 0);
            lbl_TimeTxt.Name = "lbl_TimeTxt";
            lbl_TimeTxt.Size = new Size(76, 28);
            lbl_TimeTxt.TabIndex = 7;
            lbl_TimeTxt.Text = "label12";
            // 
            // lbl_ReadCsv
            // 
            lbl_ReadCsv.AutoSize = true;
            lbl_ReadCsv.Location = new Point(552, 142);
            lbl_ReadCsv.Margin = new Padding(2, 0, 2, 0);
            lbl_ReadCsv.Name = "lbl_ReadCsv";
            lbl_ReadCsv.Size = new Size(76, 28);
            lbl_ReadCsv.TabIndex = 13;
            lbl_ReadCsv.Text = "label15";
            // 
            // lbl_TimeCSV
            // 
            lbl_TimeCSV.AutoSize = true;
            lbl_TimeCSV.Location = new Point(186, 142);
            lbl_TimeCSV.Margin = new Padding(2, 0, 2, 0);
            lbl_TimeCSV.Name = "lbl_TimeCSV";
            lbl_TimeCSV.Size = new Size(76, 28);
            lbl_TimeCSV.TabIndex = 8;
            lbl_TimeCSV.Text = "label13";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(552, 1);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(163, 28);
            label8.TabIndex = 7;
            label8.Text = "Czas odczytu[ms]";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(186, 1);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(153, 28);
            label9.TabIndex = 8;
            label9.Text = "Czas zapisu [ms]";
            // 
            // lbl_ReadBin
            // 
            lbl_ReadBin.AutoSize = true;
            lbl_ReadBin.Location = new Point(552, 95);
            lbl_ReadBin.Margin = new Padding(2, 0, 2, 0);
            lbl_ReadBin.Name = "lbl_ReadBin";
            lbl_ReadBin.Size = new Size(76, 28);
            lbl_ReadBin.TabIndex = 11;
            lbl_ReadBin.Text = "label13";
            // 
            // lbl_TimeBin
            // 
            lbl_TimeBin.AutoSize = true;
            lbl_TimeBin.Location = new Point(186, 95);
            lbl_TimeBin.Margin = new Padding(2, 0, 2, 0);
            lbl_TimeBin.Name = "lbl_TimeBin";
            lbl_TimeBin.Size = new Size(76, 28);
            lbl_TimeBin.TabIndex = 7;
            lbl_TimeBin.Text = "label12";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 142);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(91, 28);
            label10.TabIndex = 9;
            label10.Text = "Plik (.csv)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 1);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 4;
            label4.Text = "Typ pliku";
            // 
            // lbl_ReadTxt
            // 
            lbl_ReadTxt.AutoSize = true;
            lbl_ReadTxt.Location = new Point(552, 48);
            lbl_ReadTxt.Margin = new Padding(2, 0, 2, 0);
            lbl_ReadTxt.Name = "lbl_ReadTxt";
            lbl_ReadTxt.Size = new Size(76, 28);
            lbl_ReadTxt.TabIndex = 10;
            lbl_ReadTxt.Text = "label12";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 189);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 28);
            label7.TabIndex = 6;
            label7.Text = "MS SQL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 48);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 28);
            label5.TabIndex = 4;
            label5.Text = "Plik (.txt)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 95);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(92, 28);
            label6.TabIndex = 5;
            label6.Text = "Plik (.bin)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(918, 1);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(159, 28);
            label11.TabIndex = 8;
            label11.Text = "Rozmiar pliku [B]";
            // 
            // lbl_TxtSize
            // 
            lbl_TxtSize.AutoSize = true;
            lbl_TxtSize.Location = new Point(918, 48);
            lbl_TxtSize.Margin = new Padding(2, 0, 2, 0);
            lbl_TxtSize.Name = "lbl_TxtSize";
            lbl_TxtSize.Size = new Size(76, 28);
            lbl_TxtSize.TabIndex = 10;
            lbl_TxtSize.Text = "label12";
            // 
            // lbl_BinSize
            // 
            lbl_BinSize.AutoSize = true;
            lbl_BinSize.Location = new Point(918, 95);
            lbl_BinSize.Margin = new Padding(2, 0, 2, 0);
            lbl_BinSize.Name = "lbl_BinSize";
            lbl_BinSize.Size = new Size(76, 28);
            lbl_BinSize.TabIndex = 11;
            lbl_BinSize.Text = "label13";
            // 
            // lbl_CSVSize
            // 
            lbl_CSVSize.AutoSize = true;
            lbl_CSVSize.Location = new Point(918, 142);
            lbl_CSVSize.Margin = new Padding(2, 0, 2, 0);
            lbl_CSVSize.Name = "lbl_CSVSize";
            lbl_CSVSize.Size = new Size(76, 28);
            lbl_CSVSize.TabIndex = 14;
            lbl_CSVSize.Text = "label17";
            // 
            // lbl_SQLSize
            // 
            lbl_SQLSize.AutoSize = true;
            lbl_SQLSize.Location = new Point(918, 189);
            lbl_SQLSize.Margin = new Padding(2, 0, 2, 0);
            lbl_SQLSize.Name = "lbl_SQLSize";
            lbl_SQLSize.Size = new Size(76, 28);
            lbl_SQLSize.TabIndex = 12;
            lbl_SQLSize.Text = "label14";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(370, 1);
            label12.Name = "label12";
            label12.Size = new Size(151, 28);
            label12.TabIndex = 16;
            label12.Text = "Prędkość zapisu";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(736, 1);
            label14.Name = "label14";
            label14.Size = new Size(166, 28);
            label14.TabIndex = 17;
            label14.Text = "Prędkość odczytu";
            // 
            // txtBox_inputAmount
            // 
            txtBox_inputAmount.Location = new Point(500, 299);
            txtBox_inputAmount.Margin = new Padding(2);
            txtBox_inputAmount.Name = "txtBox_inputAmount";
            txtBox_inputAmount.Size = new Size(92, 31);
            txtBox_inputAmount.TabIndex = 4;
            // 
            // txtBox_outputAmount
            // 
            txtBox_outputAmount.Location = new Point(994, 299);
            txtBox_outputAmount.Margin = new Padding(2);
            txtBox_outputAmount.Name = "txtBox_outputAmount";
            txtBox_outputAmount.Size = new Size(99, 31);
            txtBox_outputAmount.TabIndex = 5;
            // 
            // btn_submitAmount
            // 
            btn_submitAmount.Location = new Point(1101, 299);
            btn_submitAmount.Margin = new Padding(2);
            btn_submitAmount.Name = "btn_submitAmount";
            btn_submitAmount.Size = new Size(115, 36);
            btn_submitAmount.TabIndex = 6;
            btn_submitAmount.Text = "Zatwierdź";
            btn_submitAmount.UseVisualStyleBackColor = true;
            btn_submitAmount.Click += btn_submitAmount_Click_1;
            // 
            // submitWrite
            // 
            submitWrite.Location = new Point(600, 299);
            submitWrite.Margin = new Padding(2);
            submitWrite.Name = "submitWrite";
            submitWrite.Size = new Size(115, 36);
            submitWrite.TabIndex = 10;
            submitWrite.Text = "Zatwierdź";
            submitWrite.UseVisualStyleBackColor = true;
            submitWrite.Click += submitWrite_Click;
            // 
            // lbl_InputWarning
            // 
            lbl_InputWarning.AutoSize = true;
            lbl_InputWarning.Location = new Point(450, 364);
            lbl_InputWarning.Margin = new Padding(2, 0, 2, 0);
            lbl_InputWarning.Name = "lbl_InputWarning";
            lbl_InputWarning.Size = new Size(69, 25);
            lbl_InputWarning.TabIndex = 9;
            lbl_InputWarning.Text = "label14";
            // 
            // ReadWriteSpeedTest
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
            Name = "ReadWriteSpeedTest";
            Text = "ReadWriteSpeedTest";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
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
        private Label lbl_CSVSize;
        private Label lbl_SQLSize;
        private Label lbl_BinSize;
        private Label lbl_TxtSize;
        private Label lbl_ReadSQL;
        private Label lbl_ReadCsv;
        private Label lbl_ReadBin;
        private Label lbl_ReadTxt;
        private Button submitWrite;
        private Label lbl_InputWarning;
        private ProgressBar txtSpeedBar;
        private ProgressBar sqlSpeedBar2;
        private Label txtSpeedLb;
        private Label sqlSpeedLb2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label12;
        private Label label14;
        private TableLayoutPanel tableLayoutPanel12;
        private TableLayoutPanel tableLayoutPanel11;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel9;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel3;
        private ProgressBar sqlSpeedBar;
        private ProgressBar csvSpeedBar;
        private ProgressBar binSpeedBar;
        private Label sqlSpeedLb;
        private Label csvSpeedLb;
        private Label binSpeedLb;
        private ProgressBar csvSpeedBar2;
        private Label csvSpeedLb2;
        private ProgressBar binSpeedBar2;
        private Label binSpeedLb2;
        private Label txtSpeedLb2;
        private ProgressBar txtSpeedBar2;
    }
}

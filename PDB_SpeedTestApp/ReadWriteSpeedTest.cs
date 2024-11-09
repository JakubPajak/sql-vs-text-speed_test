using PDB_SpeedTestApp.Helpers;
using PDB_SpeedTestApp.Services;
using PDB_SpeedTestApp.Services.ReadServices;
using PDB_SpeedTestApp.Services.WriteServices;

namespace PDB_SpeedTestApp
{
    public partial class ReadWriteSpeedTest : Form
    {
        private readonly AppDbContext _context;

        public ReadWriteSpeedTest(AppDbContext context)
        {
            _context = context;
            InitializeComponent();

            lbl_TimeBin.Text = "";
            lbl_TimeCSV.Text = "";
            lbl_TimeTxt.Text = "";
            lbl_TimeSQL.Text = "";

            lbl_ReadBin.Text = "";
            lbl_ReadCsv.Text = "";
            lbl_ReadTxt.Text = "";
            lbl_ReadSQL.Text = "";

            lbl_TxtSize.Text = "";
            lbl_BinSize.Text = "";
            lbl_CSVSize.Text = "";
            lbl_SQLSize.Text = "";

            // czyszczenie labeli predkosci
            binSpeedLb.Text = "";
            csvSpeedLb.Text = "";
            txtSpeedLb.Text = "";
            sqlSpeedLb.Text = "";

            binSpeedLb2.Text = "";
            csvSpeedLb2.Text = "";
            txtSpeedLb2.Text = "";
            sqlSpeedLb2.Text = "";

            lbl_InputWarning.Text = "";
            var cleanDatabase = new CleanDatabase(_context);
            cleanDatabase.CleanTheDatabase();
        }

        private void submitWrite_Click(object sender, EventArgs e)
        {
            int amount = txtBox_inputAmount.Text.Length > 0 ? int.Parse(txtBox_inputAmount.Text) : 0;

            var writeHelper = new InvokeWriteServices(_context, amount);
            Dictionary<string, double> elapsedTimeForFiles_Write = writeHelper.InvokeReadServices();
            int[] speed = new int[4];
            //var readHelper = new InvokeReadServicesHelper(_context);
            //Dictionary<string, double> elapsedTimeForFiles_Read = readHelper.InvokeReadServices();

            GetFileSizeService getFileSizeService = new GetFileSizeService();
            var sizes = getFileSizeService.GetFileSize();

            if (amount == 0.0)
            {
                lbl_InputWarning.Text = "UWAGA! Prosz� wprowadzi� poprawn� ilo�� danych do generacji (n > 0).";
                lbl_InputWarning.ForeColor = System.Drawing.Color.Red;
            }

            lbl_TimeBin.Text = elapsedTimeForFiles_Write["bin"].ToString();
            lbl_TimeCSV.Text = elapsedTimeForFiles_Write["csv"].ToString();
            lbl_TimeTxt.Text = elapsedTimeForFiles_Write["txt"].ToString();
            lbl_TimeSQL.Text = elapsedTimeForFiles_Write["sql"].ToString();

            //lbl_ReadBin.Text = elapsedTimeForFiles_Read["bin"].ToString();
            //lbl_ReadCsv.Text = elapsedTimeForFiles_Read["csv"].ToString();
            //lbl_ReadTxt.Text = elapsedTimeForFiles_Read["txt"].ToString();
            //lbl_ReadSQL.Text = elapsedTimeForFiles_Read["sql"].ToString();


            if (sizes.Count == 4)
            {
                lbl_BinSize.Text = sizes[0].ToString();
                lbl_CSVSize.Text = sizes[1].ToString();
                lbl_TxtSize.Text = sizes[2].ToString();
                lbl_SQLSize.Text = sizes[3].ToString();
            }

            // funkcja do obliczania predkosc zapisu kB/s
            speed[0] = (int)(sizes[0] / elapsedTimeForFiles_Write["bin"]);
            binSpeedBar.Value = speed[0];
            binSpeedLb.Text = speed[0].ToString() + "kB/s";

            speed[1] = (int)(sizes[1] / elapsedTimeForFiles_Write["csv"]);
            csvSpeedBar.Value = speed[1];
            csvSpeedLb.Text = speed[1].ToString() + "kB/s";

            speed[2] =  (int)(sizes[2] / elapsedTimeForFiles_Write["txt"]);
            txtSpeedBar.Value = speed[2];
            txtSpeedLb.Text = speed[2].ToString() + "kB/s";

            speed[3] = (int)(sizes[3] / elapsedTimeForFiles_Write["sql"]);
            sqlSpeedBar.Value = speed[3];
            sqlSpeedLb.Text = speed[3].ToString() + "kB/s";
        }

        private void btn_submitAmount_Click_1(object sender, EventArgs e)
        {
            int amount = txtBox_outputAmount.Text.Length > 0 ? int.Parse(txtBox_outputAmount.Text) : 0;
            int[] speed = new int[4];

            var readHelper = new InvokeReadServicesHelper(_context, amount);
            Dictionary<string, double> elapsedTimeForFiles_Read = readHelper.InvokeReadServices();

            GetFileSizeService getFileSizeService = new GetFileSizeService();
            var sizes = getFileSizeService.GetFileSize();
            //if (amount == 0.0)
            //{
            //    lbl_InputWarning.Text = "UWAGA! Prosz� wprowadzi� poprawn� ilo�� danych do odczytu ( >0 ).";
            //    lbl_InputWarning.ForeColor = System.Drawing.Color.Red;
            //}

            lbl_ReadBin.Text = elapsedTimeForFiles_Read["bin"].ToString();
            lbl_ReadCsv.Text = elapsedTimeForFiles_Read["csv"].ToString();
            lbl_ReadTxt.Text = elapsedTimeForFiles_Read["txt"].ToString();
            lbl_ReadSQL.Text = elapsedTimeForFiles_Read["sql"].ToString();

            // funkcja do obliczania predkosc zapisu kB/s
            // / 1000 bo MB/s a nie kB/s
            speed[0] = (int)(sizes[0] / elapsedTimeForFiles_Read["bin"]/1000);
            binSpeedBar2.Value = speed[0];
            binSpeedLb2.Text = speed[0].ToString() + "MB/s";

            speed[1] = (int)(sizes[1] / elapsedTimeForFiles_Read["csv"]/1000);
            csvSpeedBar2.Value = speed[1];
            csvSpeedLb2.Text = speed[1].ToString() + "MB/s";

            speed[2] = (int)(sizes[2] / elapsedTimeForFiles_Read["txt"]/1000);
            txtSpeedBar2.Value = speed[2];
            txtSpeedLb2.Text = speed[2].ToString() + "MB/s";

            speed[3] = (int)(sizes[3] / elapsedTimeForFiles_Read["sql"]/1000);
            sqlSpeedBar2.Value = speed[3];
            sqlSpeedLb2.Text = speed[3].ToString() + "MB/s";
        }
    }
}
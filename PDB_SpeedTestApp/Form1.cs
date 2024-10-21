using PDB_SpeedTestApp.Helpers;
using PDB_SpeedTestApp.Services;
using PDB_SpeedTestApp.Services.ReadServices;
using PDB_SpeedTestApp.Services.WriteServices;

namespace PDB_SpeedTestApp
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _context;

        public Form1(AppDbContext context)
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

            lbl_InputWarning.Text = "";
            var cleanDatabase = new CleanDatabase(_context);
            cleanDatabase.CleanTheDatabase();
        }

        private void submitWrite_Click(object sender, EventArgs e)
        {
            int amount = txtBox_inputAmount.Text.Length > 0 ? int.Parse(txtBox_inputAmount.Text) : 0;

            var writeHelper = new InvokeWriteServices(_context, amount);
            Dictionary<string, double> elapsedTimeForFiles_Write = writeHelper.InvokeReadServices();

            //var readHelper = new InvokeReadServicesHelper(_context);
            //Dictionary<string, double> elapsedTimeForFiles_Read = readHelper.InvokeReadServices();

            GetFileSizeService getFileSizeService = new GetFileSizeService();
            var sizes = getFileSizeService.GetFileSize();

            if (amount == 0.0)
            {
                lbl_InputWarning.Text = "UWAGA! Proszê wprowadziæ poprawn¹ iloœæ danych do generacji ( >0 ).";
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
        }

        private void btn_submitAmount_Click_1(object sender, EventArgs e)
        {
            int amount = txtBox_outputAmount.Text.Length > 0 ? int.Parse(txtBox_outputAmount.Text) : 0;

            var readHelper = new InvokeReadServicesHelper(_context, amount);
            Dictionary<string, double> elapsedTimeForFiles_Read = readHelper.InvokeReadServices();

            //if (amount == 0.0)
            //{
            //    lbl_InputWarning.Text = "UWAGA! Proszê wprowadziæ poprawn¹ iloœæ danych do odczytu ( >0 ).";
            //    lbl_InputWarning.ForeColor = System.Drawing.Color.Red;
            //}

            lbl_ReadBin.Text = elapsedTimeForFiles_Read["bin"].ToString();
            lbl_ReadCsv.Text = elapsedTimeForFiles_Read["csv"].ToString();
            lbl_ReadTxt.Text = elapsedTimeForFiles_Read["txt"].ToString();
            lbl_ReadSQL.Text = elapsedTimeForFiles_Read["sql"].ToString();


        }
    }
}

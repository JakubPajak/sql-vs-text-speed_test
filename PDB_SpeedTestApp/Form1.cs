using PDB_SpeedTestApp.Services;
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
            lbl_InputWarning.Text = "";
        }

        private void btn_submitAmount_Click_1(object sender, EventArgs e)
        {
            WriteToTextFileService writeToTextFileService = new WriteToTextFileService();
            WriteToBinFileService writeToBinFileService = new WriteToBinFileService();
            WriteToCsvFileService writeToCsvFileService = new WriteToCsvFileService();
            WriteToDbService writeToDbService = new WriteToDbService(_context);

            int amount = txtBox_inputAmount.Text.Length > 0 ? int.Parse(txtBox_inputAmount.Text) : 0;

            double elapsedTime = 0.0;

            if (amount == 0.0)
            {
                lbl_InputWarning.Text = "UWAGA! Prosz� wprowadzi� poprawn� ilo�� danych do generacji ( >0 ).";
                lbl_InputWarning.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                elapsedTime = writeToTextFileService.WriteToTextFile(amount);
                if (elapsedTime != 0.0)
                {
                    lbl_TimeTxt.Text = elapsedTime.ToString();
                }

                elapsedTime = writeToBinFileService.WriteToBinaryFile(amount);
                if (elapsedTime != 0.0)
                {
                    lbl_TimeBin.Text = elapsedTime.ToString();
                }

                elapsedTime = writeToCsvFileService.WriteToCsvFile(amount);
                if (elapsedTime != 0.0)
                {
                    lbl_TimeCSV.Text = elapsedTime.ToString();
                }

                elapsedTime = writeToDbService.WriteToDatabase(amount);
                if (elapsedTime != 0.0)
                {
                    lbl_TimeSQL.Text = elapsedTime.ToString();
                }
            }
        }
    }
}

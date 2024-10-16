using PDB_SpeedTest.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDB_SpeedTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            lbl_TimeBin.Text = "";
            lbl_TimeCSV.Text = "";
            lbl_TimeTxt.Text = "";
            lbl_TimeSQL.Text = "";
            lbl_InputWarning.Text = "";
        }

        private void btn_submitAmount_Click(object sender, EventArgs e)
        {
            WriteToTextFileService writeToTextFileService = new WriteToTextFileService();
            WriteToBinFileService writeToBinFileService = new WriteToBinFileService();
            WriteToCsvFileService writeToCsvFileService = new WriteToCsvFileService();

            int amount = txtBox_inputAmount.Text.Length > 0 ? int.Parse(txtBox_inputAmount.Text) : 0;
            
            double elapsedTime = 0.0;

            if (amount == 0)
            {
                lbl_InputWarning.Text = "UWAGA! Proszę wprowadzić poprawną ilość danych do generacji ( >0 ).";
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
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestCommand
{
    public partial class ClaimForm : Form
    {
        public ClaimForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                      
            
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            string strInputFile,strRecFile,strLine = null;
            string strcode = null;
            FileStream oInputFileStream = null;
            StreamReader oInputFileReader = null;
            try
            {
                strInputFile = txtBoxInputFile.Text;
                strRecFile = txtBoxRecFile.Text;
                if (System.IO.File.Exists(strInputFile))
                {

                    oInputFileStream = new FileStream(strInputFile, FileMode.Open, FileAccess.Read);
                    oInputFileReader = new StreamReader(oInputFileStream);
                    while (!oInputFileReader.EndOfStream)
                    {
                        strLine = oInputFileReader.ReadLine();
                        strcode = strLine.Substring(16, 4);
                        if(string.Compare(strcode,"BPID")==0)
                        {
                            string str1 = strLine.Substring(40, 4);

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please check the inputs");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void GetRecData(string skey)
        {
            try
            {

            }
            catch(Exception)
            {

            }
        }
    }
}

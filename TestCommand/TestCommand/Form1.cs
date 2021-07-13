using System;
using System.Collections;
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

        public struct StructClaim
        {
            public string REC_TYPE;
            public string BPID_TYPE;
            public string RECIPIENT;
            public string DOC_TEMPLATE;           
        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            string strDataFile,strCodeFile,strLine = null;
            string strREC_TYPE, str_BPID_TYPE = null;
            FileStream oInputFileStream = null;
            StreamReader oInputFileReader = null;
            Dictionary<string, Tuple<string, string>> oDict = null;
            Tuple<string, string> oTuple;
            try
            {
                strDataFile = txtBoxInputFile.Text; 
                strCodeFile = txtBoxRecFile.Text;
                
                if (System.IO.File.Exists(strCodeFile))
                {
                    oDict = ReadDataFromCodeFile(strCodeFile);
                }
                
                   
                
                if (System.IO.File.Exists(strDataFile))
                {
                    
                    oInputFileStream = new FileStream(strDataFile, FileMode.Open, FileAccess.Read);
                    oInputFileReader = new StreamReader(oInputFileStream);
                    StructClaim structClaim = new StructClaim();
                    ArrayList oDataList = new ArrayList();
                    
                    while (!oInputFileReader.EndOfStream)
                    {
                        strLine = oInputFileReader.ReadLine();
                        strREC_TYPE = strLine.Substring(16, 4);                        
                        if(string.Compare(strREC_TYPE,"BPID")==0)
                        {
                             str_BPID_TYPE = strLine.Substring(40, 4);
                            if (oDict != null)
                            {
                                 oTuple = oDict[str_BPID_TYPE];
                                structClaim.REC_TYPE = strREC_TYPE;
                                structClaim.BPID_TYPE = str_BPID_TYPE;
                                structClaim.RECIPIENT = oTuple.Item1;
                                structClaim.DOC_TEMPLATE = oTuple.Item2;
                                oDataList.Add(structClaim);

                            }

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

        private Dictionary<string,Tuple<string,string>> ReadDataFromCodeFile(string strFileName)
        {
            string strLine = null;
            FileStream oInputFileStream = null;
            StreamReader oInputFileReader = null;
            Dictionary<string, Tuple<string, string>> oDict;
            string[] strArray;
            try
            {
                oInputFileStream = new FileStream(strFileName, FileMode.Open, FileAccess.Read);
                oInputFileReader = new StreamReader(oInputFileStream);
                
                oDict = new Dictionary<string, Tuple<string, string>>();
                while (!oInputFileReader.EndOfStream)
                {
                    strLine = oInputFileReader.ReadLine();
                    strArray = strLine.Split(',');
                    oDict.Add(strArray[0], new Tuple<string, string>(strArray[1], strArray[2]));

                }
                return oDict;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
       
    }
}

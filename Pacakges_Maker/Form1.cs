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

namespace Pacakges_Maker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFileOpenAndMake_Click(object sender, EventArgs e)
        {
            if (txtMonoandroidVerstion.Text.Length == 0)
                MessageBox.Show("Please Input MonoandroidVersion [ex: monoandroid71]", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MakePackages();
            
        }

        private void MakePackages()
        {
            OpenFileDialog ofdlg = new OpenFileDialog();
            ofdlg.Filter = "VisualStudio (.csproj)|*.csproj";

            if (ofdlg.ShowDialog() == DialogResult.OK)
            {
                string strLine = "";
                string strSubLine = "";
                bool bDotUse = true;

                txtInfo.Text = "<?xml version=\"1.0\" encoding=\"utf-8\"?>";
                txtInfo.Text += "\r\n<packages>";

                using (StreamReader reader = new StreamReader(ofdlg.FileName))
                {
                    string strTempLine = "";

                    while ((strLine = reader.ReadLine()) != null)
                    {
                        bDotUse = true;
                        strTempLine = "";

                        if (strLine.ToUpper().Contains("HINTPATH") &&
                            strLine.ToUpper().Contains("PACKAGES"))
                        {
                            int nIndex = strLine.IndexOf("packages");
                            strSubLine = strLine.Substring(nIndex + 9, strLine.IndexOf("lib") - (nIndex + 9) - 1);




                            byte[] byteString = Encoding.Default.GetBytes(strSubLine);
                            strTempLine += "  <packages id=\"";

                            int nByteIndex = 0;
                            int nInt = 0;

                            foreach (char a in byteString)
                            {

                                if ((nByteIndex + 1 < byteString.Length &&
                                      (char)byteString[nByteIndex] == '.' &&
                                      Int32.TryParse(((char)byteString[nByteIndex + 1]).ToString(), out nInt)) && bDotUse)
                                {
                                    bDotUse = false;
                                    strTempLine += "\" version=\"";
                                }
                                else
                                {
                                    strTempLine += a.ToString();
                                }
                                nByteIndex++;
                            }
                            strTempLine += "\" targetFramework=\"" + txtMonoandroidVerstion.Text + "\" />";
                        }

                        if (!txtInfo.Text.Contains(strTempLine))
                            txtInfo.Text += "\r\n " + strTempLine;
                    }
                    txtInfo.Text += "\r\n</packages>";
                }
            }
        }
    }
}

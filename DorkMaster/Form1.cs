using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace DorkMaster
{
    public partial class Form1 : Form
    {
  
        int wordLineCount = 0;
        public string DfEpcVDdti = Path.Combine(Application.StartupPath + "/Log");
        private Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            this.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadTxtFromFile("Patterns.txt", txtPatterns);
            LoadTxtFromFile("Keywords.txt", txtKeyword);
            LoadTxtFromFile("PageFormat.txt", txtFormat);
            LoadTxtFromFile("PageType.txt", txtType);
            LoadTxtFromFile("SearchFunctions.txt", txtFunction);
            LoadTxtFromFile("Sites.txt", txtSites);
        }
        private void JoinForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        this.Show();
    }
       
        private void LoadTxtFromFile(string fileName, TextBox textbox)
        {
            string ycpnpWaIEj = Path.Combine(DfEpcVDdti, fileName);
            if (File.Exists(ycpnpWaIEj))
            {
                textbox.Text = File.ReadAllText(ycpnpWaIEj);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int mjkGAQglcb = (int)numericUpDown1.Value;
            int attempts = 0;
            numericUpDown1.Maximum = 1000000;

            if (mjkGAQglcb <= 0)
            {
                DisplayError("Please Enter a valid Number for Dork Amount ");
                return;
            }

            if (string.IsNullOrEmpty(txtPatterns.Text))
            {
                DisplayError("Please enter a pattern | use /ResetButton");
                return;
            }

            List<string> patterns = GetLines(txtPatterns);
            List<string> sites = GetLines(txtSites);
            List<string> keywords = GetLines(txtKeyword);
            List<string> pageTypes = GetLines(txtType);
            List<string> pageFormats = GetLines(txtFormat);
            List<string> searchFunctions = GetLines(txtFunction);

            List<string> impi6GM00f = new List<string>();
            HashSet<string> rDDlpeQjjK = new HashSet<string>();

            int vMKLRVKIMH = 0;
            Random rand = new Random();
            while (vMKLRVKIMH < mjkGAQglcb)
            {
                string pattern = patterns[rand.Next(patterns.Count)];
                string keyword = GetRandomLineIfNotEmpty(txtKeyword, "keyword");
                string pageType = GetRandomLineIfNotEmpty(txtType, "pageType");
                string pageParameter = GetRandomLineIfNotEmpty(txtFormat, "pageFormat");
                string searchFunction = GetRandomLineIfNotEmpty(txtFunction, "searchFunction");
                string site = GetRandomLineIfNotEmpty(txtSites, "site");


                string dork = pattern.Replace("(NB)", site)
                    .Replace("(KW)", keyword)
                    .Replace("(PT)", pageType)
                    .Replace("(PF)", pageParameter)
                    .Replace("(SF)", searchFunction);

                if (!rDDlpeQjjK.Contains(dork))
                {
                    rDDlpeQjjK.Add(dork);
                    vMKLRVKIMH++;
                    attempts = 0;
                }
                else
                {
                    attempts++;
                    if (attempts >= 10)
                    {
                        DisplayError("Failed to Generate required Number of Dorks.");
                        return;
                    }
                }
            }

            impi6GM00f = rDDlpeQjjK.ToList();

            SaveDorksToFile("DorkList.txt", impi6GM00f);
            DisplayDork("Dorks saved to DorkList.txt");
            SaveTxtToFile("Patterns.txt", txtPatterns.Text);
            SaveTxtToFile("Keywords.txt", txtKeyword.Text);
            SaveTxtToFile("PageFormat.txt", txtFormat.Text);
            SaveTxtToFile("PageType.txt", txtType.Text);
            SaveTxtToFile("SearchFunctions.txt", txtFunction.Text);
            SaveTxtToFile("Sites.txt", txtSites.Text);

            txtDorkList.Text = string.Join(Environment.NewLine, impi6GM00f);
        }

        private void SaveTxtToFile(string NtDQSHfUbm, string DmSEtzwJhj)
        {
            try
            {
                string bgUNONTcXe = Path.Combine(DfEpcVDdti, NtDQSHfUbm);
                File.WriteAllText(bgUNONTcXe, DmSEtzwJhj);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the file: " + ex.Message);
            }
        }
        private string GetRandomLineIfNotEmpty(TextBox textBox, string mXcNyOwdpj)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                List<string> lines = GetLines(textBox);
                return lines[rand.Next(lines.Count)];
            }
            else
            {
                return "";
            }
        }
        private List<string> GetLines(TextBox textBox)
        {
            return textBox.Lines.Where(line => !string.IsNullOrWhiteSpace(line)).ToList();
        }

        private void SaveDorksToFile(string fileName, List<string> dorks)
        {
            List<string> impi6GM00f = new List<string>();

            try
            {
                string filePath = Path.Combine(DfEpcVDdti, fileName);

                if (!Directory.Exists(DfEpcVDdti))
                {
                    Directory.CreateDirectory(DfEpcVDdti);
                }

                File.WriteAllLines(filePath, dorks);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the dorks: " + ex.Message);
            }
        }

        private void DisplayDork(string hOAfIwuQQW)
        {
            txtMessage.ScrollBars = ScrollBars.Horizontal;
            txtMessage.TextAlign = HorizontalAlignment.Center;
            txtMessage.Font = new Font(txtMessage.Font.FontFamily, 10);

            txtMessage.AppendText(hOAfIwuQQW + "\n");

            Task.Delay(5000).ContinueWith((t) =>
            {
                txtMessage.Invoke(new Action(() => { txtMessage.Text = ""; }));
            });
        }

        private void DisplayError(string cGNYhjZQpG)
        {
            txtMessage.ScrollBars = ScrollBars.Horizontal;
            txtMessage.TextAlign = HorizontalAlignment.Center;
            txtMessage.Font = new Font(txtMessage.Font.FontFamily, 10);

            txtMessage.AppendText(cGNYhjZQpG + "\n");

            Task.Delay(5000).ContinueWith((t) =>
            {
                txtMessage.Invoke(new Action(() => { txtMessage.Text = ""; }));
            });
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int t = rand.Next(0, 255), b = rand.Next(0, 255), g = rand.Next(0, 255);
            lblDorkMaster.ForeColor = Color.FromArgb(t, g, b);
        }


        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDorkList.Text))
            {
                txtMessage.TextAlign = HorizontalAlignment.Center;
                txtMessage.Font = new Font(txtMessage.Font.FontFamily, 10);

                txtMessage.AppendText("Dork list Text is Empty!\n");
                await Task.Delay(5000);
                txtMessage.Text = null;
            }
            else
            {
                SaveFileDialog sf = new SaveFileDialog();
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(sf.FileName + ".txt", false);
                    sw.WriteLine(txtDorkList.Text);
                    sw.Close();
                    MessageBox.Show(sf.FileName + " Saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void lblTelegramLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/DarkChipers");
        }

        private void btnImportKey_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text files (*.txt)|*.txt";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string text = File.ReadAllText(openFile.FileName);
                    txtKeyword.Text = text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading the file: " + ex.Message);
                }
            }
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text files (*.txt)|*.txt";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(openFile.FileName);
                txtType.Text = text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Text files (*.txt)|*.txt";
            of.FilterIndex = 1;
            of.RestoreDirectory = true;
            if (of.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(of.FileName);
                txtPatterns.Text = text;
            }
        }

        private void btnFormats_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Text files (*.txt)|*.txt";
            of.FilterIndex = 1;
            of.RestoreDirectory = true;
            if (of.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(of.FileName);
                txtFormat.Text = text;
            }
        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Text files (*.txt)|*.txt";
            of.FilterIndex = 1;
            of.RestoreDirectory = true;
            if (of.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(of.FileName);
                txtFunction.Text = text;
            }
        }

        private void btnSite_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Text files (*.txt)|*.txt";
            of.FilterIndex = 1;
            of.RestoreDirectory = true;
            if (of.ShowDialog() == DialogResult.OK)
            {
                string text = File.ReadAllText(of.FileName);
                txtSites.Text = text;
            }
        }

        private void btnResetPatterns_Click(object sender, EventArgs e)
        {
            txtPatterns.Text = "(KW).(PF)?(PT)=\r\n(KW).(PF)?(PT)= (NB)\r\n(SF).(PF)?(PT) + (KW)=\r\n(SF) (KW).(PF)?(PT)=\r\n(SF) =(KW).(PF)?(PT)=\r\n(SF) (KW).(PF)?(PT)= (NB)\r\n(SF) (KW) + .(PF)?(PT)=\r\n(SF) (KW) + .(PF)?(PT)= (NB)\r\n(SF) (KW).(PF)?(PT)=\r\n(KW).(PF)?(PT)= (NB)\r\n(NB)= (KW) + .(PF)?(PT)=";
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath);
        }

        private void lblGithubLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/2Brody/dork-generator-DorkMaster");
        }
    }
}
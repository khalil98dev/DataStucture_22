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

namespace RunAllSqlScriptsAtOnce
{
    public partial class Form1 : Form
    {
        private string _Path { get; set; }

        public string Path { get { return _Path; }

            set { _Path = value;




            }


        }

        public string[] Files { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        void _SetFolderPath()
        {
            FolderBrowserDialog GetFolderPath = new FolderBrowserDialog();

            if (GetFolderPath.ShowDialog() == DialogResult.OK)
            {
                Path = GetFolderPath.SelectedPath;
                lblPath.Text = Path;
            }
        }
        void _AddCheckboxsToPannel()
        {
            foreach (string file in Files)
            {
                CheckBox FileBox = new CheckBox();

                FileBox.Text = file.ToString();
                FileBox.Checked = true;
                FileBox.Width = 400;
                pGetAllScriptes.Controls.Add(FileBox);

            }
        }
      void _AppendFiles()
          {
                Files = Directory.GetFiles(Path,"*.sql",SearchOption.AllDirectories);
          }


        

        private void button1_Click(object sender, EventArgs e)
        {
            _SetFolderPath();
            if (!Directory.Exists(Path))
            {
                DialogResult Result = MessageBox.Show("Folder maybe deleted or moved, please select On other Folder oath",
                    "Folder does not esist", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
                if (Result == DialogResult.Yes)
                    _SetFolderPath();
                else
                    return;

            }
            _AppendFiles();

            if (Files.Length > 0)
            {
                _AddCheckboxsToPannel();
            }
        }
        void _RunSQLScript(string FilePath)
        {
            string sql = $"SQLCMD -E -dmaster -i{FilePath}";
            System.Diagnostics.Process.Start("CMD.exe",sql);
        }

        void _GenerateFile(StringBuilder FileText)
        {
           
            String Path = string.Concat(this.Path, @"\Run.bat");

            using (StreamWriter File = new StreamWriter(Path))
            {
                File.Write(FileText.ToString());
               
              
            }


         
        }
        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder script = new StringBuilder(); 

      
            foreach(Control fileName in pGetAllScriptes.Controls)
            {
                CheckBox checkBox = (CheckBox)fileName; 
                if (checkBox.Checked)
                {
                    script.Append($"SQLCMD -E -dmaster -i{checkBox.Text}\n");

                }

            }
            script.Append("\nPAUSE");
            _GenerateFile(script); 



            DialogResult Result =  MessageBox.Show("The Script was generate,Do you want to run the Application? ", "Run", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (Result == DialogResult.Yes) {

                System.Diagnostics.Process.Start($"{this.Path}\\Run.bat");

            }    
        }
    } 
}

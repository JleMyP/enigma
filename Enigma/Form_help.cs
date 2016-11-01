using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace Enigma {
    public partial class Form_help :Form {

        Dictionary<string, string> dict = new Dictionary<string, string>();
        DirectoryInfo dir = new DirectoryInfo(Application.StartupPath + "\\help");

        public Form_help() {
            InitializeComponent();
            FileInfo[] files = dir.GetFiles("*.txt");
            int p = 20;
            foreach (FileInfo f in files) {
                string name = f.Name.Substring(0, f.Name.Length - 4);
                dict[name.Split(new char[] { ' ' }, 2)[1]] = name;
                LinkLabel l = new LinkLabel();
                l.LinkColor = Color.FromName("Info");
                l.AutoSize = true;
                l.Location = new Point(name.Split('.').Length * 15, p);
                l.Text = name;
                l.Click += new EventHandler(label_ogl_Click);
                groupBox1.Controls.Add(l);
                p += 20;
            }
        }
        

        public void selectHelp(string name){
            if (!File.Exists(string.Format("help\\{0}.txt", name))) name = dict[name];
            if (label_head.Text == name) return;
            label_head.Text = name;
            string text = File.ReadAllText(string.Format("help\\{0}.txt", name), Encoding.Default);
            textBox1.Text = text;
            FileInfo[] f = dir.GetFiles(name.Split(' ')[0] + "*.??g?");
            if (f.Length != 0) {
                pictureBox1.BackgroundImage = Image.FromFile("help\\" + f[0].Name);
                pictureBox1.Visible = true;
                textBox1.Top = 360;
                textBox1.Height = 230;
            } else {
                pictureBox1.Visible = false;
                textBox1.Top = 40;
                textBox1.Height = 560;
            }
        }


        private void label_ogl_Click(object sender, EventArgs e) {
            selectHelp(((LinkLabel)sender).Text);
        }
    }
}

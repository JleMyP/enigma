/*
    Мартынов Тимофей, кт-202
    9.07.2016 
    timtim96@bk.ru
*/


using System;
using System.Xml;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;



namespace Enigma {
    public partial class Main_Form: Form {

        Dictionary<string, Machine> machines = new Dictionary<string, Machine>();

        Machine machine;
        Form_view form_view;
        Form_help form_help;

        List<ComboBox> box_poses;
        List<Label> label_poses; 
        Random rand = new Random();
        Color[] colors = new Color[26];

        //http://www.cryptomuseum.com/crypto/enigma/tree.htm

        string[][] keys = new string[][] {
            new string[] {"Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P" },
            new string[] {"A", "S", "D", "F", "G", "H", "J", "K", "L" },
            new string[] {"Z", "X", "C", "V", "B", "N", "M" }
        };

        char replace_key = '\0';
        int key_size = 28;



        public Main_Form() {
            InitializeComponent();

            machines["Enigma D"] = new Machine("Enigma D",
                new string[][] {
                    new string[] { "Rotor I", "LPGSZMHAEOQKVXRFYBUTNICJDW", "Z" },
                    new string[] { "Rotor II", "SLVGBTFXJQOHEWIRZYAMKPCNDU", "F" },
                    new string[] { "Rotor III", "CJGDPSHKTURAWZXFMYNQOBVLIE", "O"}
                },
                new string[][] {
                    new string[] { "Reflector", "IMETCGFRAYSQBZXWLHKDVUPOJN" }
                }, false
            );

            machines["Enigma Zahlwerk"] = new Machine("Enigma Zahlwerk",
                new string[][] {
                    new string[] { "Rotor I", "LPGSZMHAEOQKVXRFYBUTNICJDW", "SUVWZABCEFGIKLOPQ" },
                    new string[] { "Rotor II", "SLVGBTFXJQOHEWIRZYAMKPCNDU", "STVYZACDFGHKMNQ" },
                    new string[] { "Rotor III", "CJGDPSHKTURAWZXFMYNQOBVLIE", "UWXAEFHKMNR" }
                },
                new string[][] {
                    new string[] { "Reflector", "IMETCGFRAYSQBZXWLHKDVUPOJN" }
                }, false
            );

            machines["Enigma I"] = new Machine("Enigma I",
                new string[][] {
                    new string[] { "Rotor I", "EKMFLGDQVZNTOWYHXUSPAIBRCJ", "Q" },
                    new string[] { "Rotor II", "AJDKSIRUXBLHWTMCQGZNPYFVOE", "E" },
                    new string[] { "Rotor III", "BDFHJLCPRTXVZNYEIWGAKMUSQO", "V"},
                    new string[] { "Rotor IV",  "ESOVPZJAYQUIRHXLNFTGKDCMWB", "J"},
                    new string[] { "Rotor V",   "VZBRGITYUPSDNHLXAWMJQOFECK", "Z"}
                },
                new string[][] {
                    new string[] { "Reflector B", "YRUHQSLDPXNGOKMIEBFZCWVJAT" },
                    new string[] { "Reflector C", "FVPJIAOYEDRZXWGCTKUQSBNMHL" }
                }
            );

            machines["Enigma M3"] = new Machine("Enigma M3",
                new string[][] {
                    new string[] { "Rotor I", "EKMFLGDQVZNTOWYHXUSPAIBRCJ", "Q" },
                    new string[] { "Rotor II", "AJDKSIRUXBLHWTMCQGZNPYFVOE", "E" },
                    new string[] { "Rotor III", "BDFHJLCPRTXVZNYEIWGAKMUSQO", "V"},
                    new string[] { "Rotor IV",  "ESOVPZJAYQUIRHXLNFTGKDCMWB", "J"},
                    new string[] { "Rotor V",   "VZBRGITYUPSDNHLXAWMJQOFECK", "Z"},
                    new string[] { "Rotor VI", "JPGVOUMFYQBENHZRDKASXLICTW", "ZM"},
                    new string[] { "Rotor VII", "NZJHGRCXMYSWBOUFAIVLPEKQDT", "ZM"},
                    new string[] { "Rotor VIII", "FKQHTLXOCBJSPDZRAMEWNIUYGV", "ZM"}
                },
                new string[][] {
                    new string[] { "Reflector B", "YRUHQSLDPXNGOKMIEBFZCWVJAT" },
                    new string[] { "Reflector C", "FVPJIAOYEDRZXWGCTKUQSBNMHL" }
                }
            );

            machines["Enigma M4"] = new Machine("Enigma M4",
                new string[][] {
                    new string[] { "Rotor I", "EKMFLGDQVZNTOWYHXUSPAIBRCJ", "Q" },
                    new string[] { "Rotor II", "AJDKSIRUXBLHWTMCQGZNPYFVOE", "E" },
                    new string[] { "Rotor III", "BDFHJLCPRTXVZNYEIWGAKMUSQO", "V" },
                    new string[] { "Rotor IV",  "ESOVPZJAYQUIRHXLNFTGKDCMWB", "J" },
                    new string[] { "Rotor V",   "VZBRGITYUPSDNHLXAWMJQOFECK", "Z" },
                    new string[] { "Rotor VI", "JPGVOUMFYQBENHZRDKASXLICTW", "ZM" },
                    new string[] { "Rotor VII", "NZJHGRCXMYSWBOUFAIVLPEKQDT", "ZM" },
                    new string[] { "Rotor VIII", "FKQHTLXOCBJSPDZRAMEWNIUYGV", "ZM"}
                },
                new string[][] {
                    new string[] { "Reflector Beta", "LEYJVCNIXWPBQMDRTAKZGFUHOS" },
                    new string[] { "Reflector Gamma", "FSOKANUERHMBTIYCWLQPZXVGJD" },
                    new string[] { "Reflector B", "ENKQAUYWJICOPBLMDXZVFTHRGS" },
                    new string[] { "Reflector C", "RDOBJNTKVEHMLFCWZAXGYIPSUQ" }
                }
            );

            machines["Enigma KD"] = new Machine("Enigma KD",
                new string[][] {
                    new string[] { "Rotor I", "VEZIOJCXKYDUNTWAPLQGBHSFMR", "SUYAEHLNQ" },
                    new string[] { "Rotor II", "HGRBSJZETDLVPMQYCXAOKINFUW", "SUYAEHLNQ" },
                    new string[] { "Rotor III", "NWLHXGRBYOJSAZDVTPKFQMEUIC", "SUYAEHLNQ" }
                },
                new string[][] {
                    new string[] { "Reflector", "KOTVPNLMJIAGHFBEWYXCZDQSRU" }
                }, false
            );

            machine = machines["Enigma I"];

            comboBox_machines.Items.AddRange(machines.Keys.ToArray());
            comboBox_machines.SelectedItem = machine.name;
        }


        private void Form_Load(object sender = null, EventArgs e = null) {
            Width = Math.Max(panel1.Right + 10, 50 + 60 * machine.rotors_count);
            textBoxInput.Width = textBoxOutput.Width = Width - 140;
            button_clear.Left = button_save.Left = textBoxInput.Right + 15;

            if (machine.replace_enable && panel1.Height < pictureBoxComm.Bottom) {
                pictureBoxComm.Visible = button_help_comm.Visible = true;
                panel1.Height = pictureBoxComm.Bottom + 10;
            } else if (!machine.replace_enable && panel1.Height > pictureBoxComm.Bottom) {
                pictureBoxComm.Visible = button_help_comm.Visible = false;
                panel1.Height = pictureBoxKeyboard.Bottom + 10;
            }

            ClientSize = new Size(Width, panel1.Bottom + 10);
            bolt3.Top = bolt4.Top = panel1.Height - 23;

            if (box_poses != null)
                foreach (ComboBox b in box_poses) Controls.Remove(b);
            box_poses = new List<ComboBox>();

            if (label_poses != null)
                foreach (Label l in label_poses) Controls.Remove(l);
            label_poses = new List<Label>();


            for (int n = 0; n < machine.rotors_count; n++) {
                ComboBox b = new ComboBox();
                b.DropDownStyle = ComboBoxStyle.DropDownList;
                b.Size = new Size(36, 20);
                b.Location = new Point(50 + n * 60, 135);
                for (char a = 'A'; a <= 'Z'; a++) b.Items.Add(a);
                b.SelectedIndex = 0;
                b.SelectedIndexChanged += new EventHandler(comboBox_pos_SelectedIndexChanged);
                box_poses.Add(b);
                Controls.Add(b);

                Label l = new Label();
                l.AutoSize = true;
                l.Font = new Font("Times New Roman", 9, FontStyle.Bold);
                l.Text = machine.cur_rotors[n].name;
                l.Location = new Point(45 + n * 60 , 115);
                l.BackColor = Color.Transparent;
                l.ForeColor = Color.FromName("Info");
                label_poses.Add(l);
                Controls.Add(l);
            }

            comboBox_reflectors.Items.Clear();
            comboBox_reflectors.Items.AddRange(machine.dict_reflectors.Keys.ToArray());
            comboBox_reflectors.SelectedIndex = 0;
            comboBox_reflectors.Enabled = (machine.dict_reflectors.Count > 1);

            checkBox_panel.Enabled = machine.replace_enable;

            foreach (Control c in Controls) c.KeyDown += new KeyEventHandler(Key_callback);

            form_view = new Form_view(machine);
        }


        private void Key_callback(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) Application.Exit();
        }


        public void Step() {
            machine.Step();
            for (int i = 0; i < machine.rotors_count; i++)
                box_poses[i].SelectedItem = machine.cur_rotors[i].pos;
        }


        public void Back() {
            machine.Back();
            for (int i = 0; i < machine.rotors_count; i++)
                box_poses[i].SelectedItem = machine.cur_rotors[i].pos;
            if (textBoxInput.TextLength != 0) machine.CodeSymbol(textBoxInput.Text.Last());
        }


        public void show_path() {
            if (form_view.Controls.Count == 0) form_view = new Form_view(machine);
            form_view.drow();
            if (checkBoxAuto.Checked) {
                form_view.Show();
                buttonShow.Text = "скрыть путь";
            }
            form_view.Location = new Point(Right + 20, Top);
        }


        public void show_help(string name) {
            if (form_help == null || form_help.Controls.Count == 0) form_help = new Form_help();
            form_help.selectHelp(name);
            form_help.Show();
        }


        private void pictureBoxComm_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            Font f = new Font("Times New Roman", key_size / 2, FontStyle.Regular);
            SolidBrush f_brush = new SolidBrush(Color.Black);
            int px = 0, py = 0;
            float w;
            Color color;
            foreach (string[] s in keys) {
                foreach (string c in s) {
                    if (colors[c[0] - 'A'].Name != "0") color = colors[c[0] - 'A'];
                    else color = Color.Gray;
                    w = g.MeasureString(c, f).Width;
                    g.FillEllipse(new SolidBrush(color), new Rectangle(px, py, key_size, key_size));
                    g.DrawString(c, f, f_brush, px + (key_size - w) / 2, py + (key_size - f.Height) / 2);
                    px += (int)(key_size * 1.25);
                }
                py += (int)(key_size * 1.25);
                px -= (int)(key_size * 0.5) + (int)((s.Length - 1) * key_size * 1.25);
            }
        }


        private void pictureBoxkeyboard_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            Font f = new Font("Times New Roman", key_size / 2, FontStyle.Regular);
            SolidBrush f_brush = new SolidBrush(Color.Black);
            SolidBrush sel_brush = new SolidBrush(Color.Yellow);
            SolidBrush brush = new SolidBrush(Color.LightGreen);

            int px = 0, py = 0;
            float w;
            foreach (string[] s in keys) {
                foreach (string c in s) {
                    SolidBrush b = (textBoxInput.TextLength > 0 && c[0] == textBoxInput.Text.Last()) ? sel_brush : brush;
                    g.FillEllipse(b, px, py, key_size, key_size);
                    w = g.MeasureString(c, f).Width;
                    g.DrawString(c, f, f_brush, px + (key_size - w) / 2, py + (key_size - f.Height) / 2);
                    px += (int)(key_size * 1.25);
                }
                px -= (int)(key_size * 0.5) + (int)((s.Length - 1) * key_size * 1.25);
                py += (int)(key_size * 1.25);
            }

            px += (int)(key_size * 0.5) + (int)((keys.Last().Length - 1) * key_size * 1.25);
            py -= (int)(key_size * 1.25);
            g.FillEllipse(brush, px, py, key_size, key_size);
            g.DrawLines(Pens.Black, new Point[] {
                new Point(px + key_size / 2, (int)(py + key_size * 0.3)), new Point(px + 10, py + key_size / 2), new Point(px + key_size - 10, py + key_size / 2),
                new Point(px + 10, py + key_size / 2), new Point(px + key_size / 2, (int)(py + key_size * 0.7))
            } );

            px += (int)(key_size * 1.25);
            g.FillEllipse((textBoxInput.TextLength > 0 && textBoxInput.Text.Last() == ' ') ? sel_brush : brush, px, py, key_size, key_size);
            g.DrawString("_", f, f_brush, px + key_size / 4, py + (key_size - f.Height) / 2);
        }


        private void pictureBoxLight_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            Font f = new Font("Times New Roman", key_size / 2, FontStyle.Regular);
            SolidBrush brush = new SolidBrush(Color.Black);

            int px = 0, py = 0;
            float w;
            foreach (string[] s in keys) {
                foreach (string c in s) {
                    Color color = (!string.IsNullOrEmpty(machine.path) && textBoxInput.TextLength > 0 && c[0] == machine.path.Last()) ? Color.Yellow : Color.Pink;
                    g.FillEllipse(new SolidBrush(color), new Rectangle(px, py, key_size, key_size));
                    w = g.MeasureString(c, f).Width;
                    g.DrawString(c, f, brush, px + (key_size - w) / 2, py + (key_size - f.Height) / 2);
                    px += (int)(key_size * 1.25);
                }
                py += (int)(key_size * 1.25);
                px -= (int)(key_size * 0.5) + (int)((s.Length - 1) * key_size * 1.25);
            }
        }


        private void comboBox_pos_SelectedIndexChanged(object sender, EventArgs e) {
            machine.cur_rotors[box_poses.IndexOf((ComboBox)sender)].pos = (char)((ComboBox)sender).SelectedItem;
        }
        

        private void button_clear_Click(object sender, EventArgs e) {
            textBoxOutput.Text = textBoxInput.Text = "";
        }


        private void checkBox_panel_CheckedChanged(object sender, EventArgs e) {
            if (!checkBox_panel.Checked && pictureBoxComm.Visible) {
                pictureBoxComm.Visible = button_help_comm.Visible = false;
                panel1.Height = pictureBoxKeyboard.Bottom + 10;
            } else if (checkBox_panel.Checked && !pictureBoxComm.Visible) {
                pictureBoxComm.Visible = button_help_comm.Visible = true;
                panel1.Height = pictureBoxComm.Bottom + 10;
            }
            ClientSize = new Size(ClientSize.Width, panel1.Bottom + 10);
            bolt3.Top = bolt4.Top = panel1.Height - 23;
        }


        private void pictureBox_keyboard_MouseClick(object sender, MouseEventArgs e) {
            int row = (int)(e.Y / (key_size * 1.25));
            int coll = (int)((e.X - row * key_size * 0.75) / (key_size * 1.25));

            if (row == keys.Length - 1 && coll == keys.Last().Length && textBoxInput.TextLength > 0) {
                if (textBoxInput.Text.Last() != ' ') {
                    Back();
                    pictureBoxLight.Refresh();
                }
                textBoxInput.Text = textBoxInput.Text.Substring(0, textBoxInput.TextLength - 1);
                textBoxOutput.Text = textBoxOutput.Text.Substring(0, textBoxOutput.TextLength - 1);
            } else if (row == keys.Length - 1 && coll == keys.Last().Length + 1) {
                textBoxInput.Text += ' ';
                textBoxOutput.Text += ' ';
            }

            if (e.X - row * key_size * 0.75 < 0 || coll >= keys[row].Length) return;

            string symbol = keys[row][coll];
            textBoxInput.Text += symbol;
            Step();
            textBoxOutput.Text += machine.CodeSymbol(symbol[0]).ToString();
            textBoxInput.SelectionStart = textBoxInput.TextLength;
            textBoxOutput.SelectionStart = textBoxOutput.TextLength;
            textBoxInput.ScrollToCaret();
            textBoxOutput.ScrollToCaret();


            pictureBoxLight.Refresh();
            pictureBoxKeyboard.Refresh();
            show_path();
        }


        private void pictureBoxComm_MouseClick(object sender, MouseEventArgs e) {
            int row = (int)(e.Y / (key_size * 1.25));
            int coll = (int)((e.X - row * key_size * 0.75) / (key_size * 1.25));
            if (e.X - row * key_size * 0.75 < 0 || coll >= keys[row].Length) return;
            char symbol = keys[row][coll][0];

            if (!machine.replace.Keys.Contains(symbol)) {
                if (replace_key == '\0') {
                    replace_key = symbol;
                    colors[symbol - 'A'] = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                    pictureBoxComm.Refresh();
                } else if (symbol == replace_key) {
                    colors[symbol - 'A'] = Color.FromName("0");
                    replace_key = '\0';
                    pictureBoxComm.Refresh();
                } else {
                    machine.replace[symbol] = replace_key;
                    colors[symbol - 'A'] = colors[replace_key - 'A'];
                    machine.replace[replace_key] = symbol;
                    replace_key = '\0';
                    pictureBoxComm.Refresh();
                }
            } else {
                replace_key = machine.replace[symbol];
                machine.replace.Remove(symbol);
                machine.replace.Remove(replace_key);
                colors[symbol - 'A'] = Color.FromName("0");
                pictureBoxComm.Refresh();
            }
        }

        
        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e) {
            if ('a' <= e.KeyChar && e.KeyChar <= 'z') e.KeyChar -= (char)('a' - 'A');
            if (e.KeyChar == (char)Keys.Back && textBoxInput.TextLength > 0) {
                if (textBoxInput.Text.Last() != ' ') {
                    Back();
                }
                textBoxInput.Text = textBoxInput.Text.Substring(0, textBoxInput.TextLength - 1);
                textBoxOutput.Text = textBoxOutput.Text.Substring(0, textBoxOutput.TextLength - 1);
                show_path();
            } else if ('A' <= e.KeyChar && e.KeyChar <= 'Z') {
                Step();
                textBoxInput.Text += e.KeyChar;
                textBoxOutput.Text += machine.CodeSymbol(e.KeyChar).ToString();
                show_path();
            } else if (e.KeyChar == ' ') {
                textBoxInput.Text += ' ';
                textBoxOutput.Text += ' ';
            }
            textBoxInput.SelectionStart = textBoxInput.TextLength;
            textBoxOutput.SelectionStart = textBoxOutput.TextLength;
            textBoxInput.ScrollToCaret();
            textBoxOutput.ScrollToCaret();
            e.Handled = true;
            pictureBoxLight.Refresh();
            pictureBoxKeyboard.Refresh();
        }


        private void checkBoxAuto_CheckedChanged(object sender, EventArgs e) {
        }


        private void comboBox_reflectors_SelectedIndexChanged(object sender, EventArgs e) {
            if (machine.reflector.name != comboBox_reflectors.Text) {
                machine.reflector = machine.dict_reflectors[comboBox_reflectors.SelectedItem.ToString()];
                if (form_view != null && form_view.Controls.Count != 0) form_view.Close();
                form_view = new Form_view(machine);
            }
        }


        private void comboBox_machines_SelectedIndexChanged(object sender, EventArgs e) {
            machine = machines[comboBox_machines.Text];

            colors = new Color[26];
            if (form_view != null && form_view.Controls.Count != 0) form_view.Close();
            textBoxOutput.Text = textBoxInput.Text = "";
            Form_Load();
        }


        private void buttonShow_Click(object sender, EventArgs e) {
            if (form_view.IsHandleCreated) {
                form_view.Dispose();
                buttonShow.Text = "показать путь";
            } else {
                if (form_view.Controls.Count == 0) form_view = new Form_view(machine);
                if (machine.path == null) return;
                form_view.drow();
                form_view.Show();
                form_view.Location = new Point(Right + 20, Top);
                buttonShow.Text = "скрыть путь";
            }
        }


        private void button_save_Click(object sender, EventArgs e) {
            XmlTextWriter xml = null;
            string path;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK) path = saveFileDialog1.FileName;
            else return;

            try {
                xml = new XmlTextWriter(path, Encoding.UTF8);
                xml.WriteStartDocument();
                xml.WriteStartElement("machine");
                    xml.WriteString("\n\t");
                    xml.WriteStartElement("name");
                    xml.WriteValue(machine.name);
                    xml.WriteEndElement();
                    xml.WriteString("\n\t");

                    xml.WriteStartElement("Rotors");
                    xml.WriteValue(string.Join("", machine.cur_rotors.Select(r => r.pos)));
                    xml.WriteEndElement();
                    xml.WriteString("\n\t");

                    xml.WriteStartElement("Reflector");
                    xml.WriteValue("\n\t\t");
                        xml.WriteStartElement("name");
                        xml.WriteValue(machine.reflector.name);
                        xml.WriteEndElement();
                    xml.WriteValue("\n\t");
                    xml.WriteEndElement();
                    xml.WriteString("\n\t");

                    xml.WriteStartElement("Comm");
                    xml.WriteValue(string.Join(", ", machine.replace.Keys.Select(c => string.Format("{0}-{1}", c, machine.replace[c]))));
                    xml.WriteEndElement();
                    xml.WriteString("\n\t");

                    xml.WriteStartElement("Input");
                    xml.WriteStartAttribute("value");
                    xml.WriteValue(textBoxInput.Text);
                    xml.WriteEndAttribute();
                    xml.WriteEndElement();
                    xml.WriteString("\n\t");

                    xml.WriteStartElement("Output");
                    xml.WriteStartAttribute("value");
                    xml.WriteValue(textBoxOutput.Text);
                    xml.WriteEndAttribute();
                    xml.WriteEndElement();
                    xml.WriteString("\n");

                xml.WriteEndElement();
                xml.WriteEndDocument();
                
                MessageBox.Show("данные сохранены", "УСПЕХ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch {
                MessageBox.Show("во время записи в файл произошла ошибка", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } finally {
                if (xml != null) xml.Close();
            }
        }


        private void button_help_machine_Click(object sender, EventArgs e) {
            show_help("Intro");
        }
        
        private void button_help_reflector_Click(object sender, EventArgs e) {
            show_help("Рефлектор");
        }
        
        private void button_help_light_Click(object sender, EventArgs e) {
            show_help("Световая панель");
        }

        private void button_help_keyboard_Click(object sender, EventArgs e) {
            show_help("Клавиатура");
        }

        private void button_help_comm_Click(object sender, EventArgs e) {
            show_help("Коммутационная панель");
        }

        private void button_help_rotors_Click(object sender, EventArgs e) {
            show_help("Роторы");
        }
    }
}
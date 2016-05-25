using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Enigma {
    public partial class Form_view: Form {
        Machine machine;

        public Label[] io = new Label[26];
        public Label[][] rotors = new Label[10][];
        public Label[] reflector = new Label[26];

        Pen clr1 = new Pen(Color.Yellow, 2);
        Pen clr2 = new Pen(Color.Green, 2);
        Pen clr3 = new Pen(Color.Red, 2);


        public Form_view(Machine machine) {
            InitializeComponent();

            this.machine = machine;
            Size = new Size(130 + machine.rotors_count * 80, Size.Height);
            pictureBox1.Width = ClientSize.Width;

            for (char c = 'A'; c <= 'Z'; c++) {
                Label l = new Label();
                l.Location = new Point(10, 50 + (c - 'A') * 20);
                l.Size = new Size(15, 15);
                l.Text = c.ToString();
                Controls.Add(io[c - 'A'] = l);
            }
            
            for(int r = 0; r < machine.rotors_count; r++) {
                Label name = new Label();
                name.Location = new Point(50 + r * 80, 30);
                name.Size = new Size(50, 15);
                name.Text = machine.cur_rotors[r].name;
                Controls.Add(name);

                rotors[r] = new Label[26];
                for(int x = 0; x < 26; x++) {
                    Label l = new Label();
                    l.Location = new Point(50 + r * 80, 50 + x * 20);
                    l.Size = new Size(50, 15);
                    l.Text = string.Format("{0} <-> {1}", (char)(x + 65), machine.cur_rotors[r].lst[x]);
                    Controls.Add(rotors[r][x] = l);
                }
            }

            Label ref_name = new Label();
            ref_name.Location = new Point(40 + machine.rotors_count * 80, 30);
            ref_name.Size = new Size(70, 15);
            ref_name.Text = machine.reflector.name;
            Controls.Add(ref_name);

            for(char c = 'A'; c <= 'Z'; c++) {
                Label l = new Label();
                l.Location = new Point(50 + machine.rotors_count * 80, 50 + (c - 65) * 20);
                l.Size = new Size(50, 15);
                l.Text = string.Format("{0} <-> {1}", c, machine.reflector.dict[c]);
                Controls.Add(reflector[c - 'A'] = l);
            }

            Controls.Remove(pictureBox1);
            Controls.Add(pictureBox1);
        }

        public void mark(Control l, Color back, Color fore) {
            l.BackColor = back;
            l.ForeColor = fore;
        }

        public void drow() {
            label1.Text = "Путь: " + machine.path;

            foreach (Control c in Controls) mark(c, Color.Transparent, Color.FromName("Info"));
            
            mark(io[machine.path[0] - 'A'], clr1.Color, Color.Black);
            mark(io[machine.path.Last() - 'A'], clr2.Color, Color.Black);

            for (int i = 0; i < machine.rotors_count; i++) {
                mark(rotors[i][string.Join("", machine.cur_rotors[i].lst).IndexOf(machine.path[i + 1])], clr1.Color, Color.Black);
                mark(rotors[machine.rotors_count - 1 - i][machine.path[machine.rotors_count + 2 + i] - 'A'], clr2.Color, Color.Black);
            }

            mark(reflector[machine.reflector.dict[machine.path[machine.rotors_count + 1]] - 'A'], clr1.Color, Color.Black);
            mark(reflector[machine.path[machine.rotors_count + 1] - 'A'], clr2.Color, Color.Black);

            pictureBox1.Refresh();
        }
        

        private void pictureBox1_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;

            int y1 = (machine.path[0] - 'A') * 20 + 10;
            int y2 = (machine.cur_rotors[0].lst_r[machine.path[1] - 'A'] - 'A') * 20 + 10;
            g.DrawLines(clr1, new Point[] {
                new Point(25, y1), new Point(35, y1), new Point(35, y2), new Point(45, y2)
            });
            g.DrawLines(clr1, new Point[] {
                new Point(40, y2 - 5), new Point(45, y2), new Point(40, y2 + 5)
            });
            
            y1 = (machine.path.Last() - 'A') * 20 + 10;
            y2 = (machine.path[machine.path.Length - 2] - 'A') * 20 + 10;
            g.DrawLines(clr2, new Point[] {
                new Point(25, y1), new Point(30, y1), new Point(30, y2), new Point(35, y2)
            });
            g.DrawLines(clr2, new Point[] {
                new Point(40, y2 - 5), new Point(35, y2), new Point(40, y2 + 5)
            });

            for (int r = 0; r < machine.rotors_count; r++) {
                int x = 100 + r * 80;
                y1 = (machine.cur_rotors[r].lst_r[machine.path[r + 1] - 'A'] - 'A') * 20 + 10;
                if (r == machine.rotors_count - 1) {
                    y2 = (machine.reflector.dict[machine.path[machine.rotors_count + 1]] - 'A') * 20 + 10;
                    int y3 = (machine.path[machine.rotors_count + 1] - 'A') * 20 + 10;
                    g.DrawLines(clr3, new Point[] {
                        new Point(x + 80, y2), new Point(x + 85, y2), new Point(x + 85, y3), new Point(x + 80, y3)
                    });
                } else y2 = (machine.cur_rotors[r + 1].lst_r[machine.path[r + 2] - 'A'] - 'A') * 20 + 10;
                g.DrawLines(new Pen(Color.Yellow, 2), new Point[] {
                    new Point(x, y1), new Point(x + 15, y1), new Point(x + 15, y2), new Point(x + 25, y2)
                });

                x = 100 + (machine.rotors_count - 1 - r) * 80;
                y1 = (machine.path[machine.rotors_count + 2 + r] - 'A') * 20 + 15;
                y2 = (machine.path[machine.rotors_count + 1 + r] - 'A') * 20 + 15;
                g.DrawLines(new Pen(Color.Green, 2), new Point[] {
                    new Point(x, y1), new Point(x + 5, y1), new Point(x + 5, y2), new Point(x + 25, y2)
                });
            }
        }
        

        private void Form_view_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Escape) Close();
        }
    }
}

namespace Enigma {
    partial class Main_Form {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.comboBox_reflectors = new System.Windows.Forms.ComboBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.checkBox_panel = new System.Windows.Forms.CheckBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.checkBoxAuto = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_machines = new System.Windows.Forms.ComboBox();
            this.button_save = new System.Windows.Forms.Button();
            this.button_help_light = new System.Windows.Forms.Button();
            this.button_help_machine = new System.Windows.Forms.Button();
            this.button_help_keyboard = new System.Windows.Forms.Button();
            this.button_help_comm = new System.Windows.Forms.Button();
            this.button_help_reflector = new System.Windows.Forms.Button();
            this.pictureBoxComm = new System.Windows.Forms.PictureBox();
            this.pictureBoxLight = new System.Windows.Forms.PictureBox();
            this.pictureBoxKeyboard = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bolt1 = new System.Windows.Forms.PictureBox();
            this.bolt3 = new System.Windows.Forms.PictureBox();
            this.bolt2 = new System.Windows.Forms.PictureBox();
            this.bolt4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button_help_rotors = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeyboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolt4)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_reflectors
            // 
            this.comboBox_reflectors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox_reflectors, "comboBox_reflectors");
            this.comboBox_reflectors.FormattingEnabled = true;
            this.comboBox_reflectors.Name = "comboBox_reflectors";
            this.comboBox_reflectors.SelectedIndexChanged += new System.EventHandler(this.comboBox_reflectors_SelectedIndexChanged);
            // 
            // textBoxOutput
            // 
            resources.ApplyResources(this.textBoxOutput, "textBoxOutput");
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            // 
            // button_clear
            // 
            resources.ApplyResources(this.button_clear, "button_clear");
            this.button_clear.Name = "button_clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // checkBox_panel
            // 
            resources.ApplyResources(this.checkBox_panel, "checkBox_panel");
            this.checkBox_panel.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_panel.Checked = true;
            this.checkBox_panel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_panel.ForeColor = System.Drawing.SystemColors.Info;
            this.checkBox_panel.Name = "checkBox_panel";
            this.checkBox_panel.UseVisualStyleBackColor = false;
            this.checkBox_panel.CheckedChanged += new System.EventHandler(this.checkBox_panel_CheckedChanged);
            // 
            // textBoxInput
            // 
            resources.ApplyResources(this.textBoxInput, "textBoxInput");
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInput_KeyPress);
            // 
            // buttonShow
            // 
            resources.ApplyResources(this.buttonShow, "buttonShow");
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // checkBoxAuto
            // 
            resources.ApplyResources(this.checkBoxAuto, "checkBoxAuto");
            this.checkBoxAuto.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAuto.Checked = true;
            this.checkBoxAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAuto.ForeColor = System.Drawing.SystemColors.Info;
            this.checkBoxAuto.Name = "checkBoxAuto";
            this.checkBoxAuto.UseVisualStyleBackColor = false;
            this.checkBoxAuto.CheckedChanged += new System.EventHandler(this.checkBoxAuto_CheckedChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Name = "label2";
            // 
            // comboBox_machines
            // 
            this.comboBox_machines.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBox_machines, "comboBox_machines");
            this.comboBox_machines.FormattingEnabled = true;
            this.comboBox_machines.Name = "comboBox_machines";
            this.comboBox_machines.SelectedIndexChanged += new System.EventHandler(this.comboBox_machines_SelectedIndexChanged);
            // 
            // button_save
            // 
            resources.ApplyResources(this.button_save, "button_save");
            this.button_save.Name = "button_save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_help_light
            // 
            resources.ApplyResources(this.button_help_light, "button_help_light");
            this.button_help_light.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button_help_light.Name = "button_help_light";
            this.button_help_light.UseVisualStyleBackColor = true;
            this.button_help_light.Click += new System.EventHandler(this.button_help_light_Click);
            // 
            // button_help_machine
            // 
            resources.ApplyResources(this.button_help_machine, "button_help_machine");
            this.button_help_machine.Name = "button_help_machine";
            this.button_help_machine.UseVisualStyleBackColor = true;
            this.button_help_machine.Click += new System.EventHandler(this.button_help_machine_Click);
            // 
            // button_help_keyboard
            // 
            resources.ApplyResources(this.button_help_keyboard, "button_help_keyboard");
            this.button_help_keyboard.Name = "button_help_keyboard";
            this.button_help_keyboard.UseVisualStyleBackColor = true;
            this.button_help_keyboard.Click += new System.EventHandler(this.button_help_keyboard_Click);
            // 
            // button_help_comm
            // 
            resources.ApplyResources(this.button_help_comm, "button_help_comm");
            this.button_help_comm.Name = "button_help_comm";
            this.button_help_comm.UseVisualStyleBackColor = true;
            this.button_help_comm.Click += new System.EventHandler(this.button_help_comm_Click);
            // 
            // button_help_reflector
            // 
            resources.ApplyResources(this.button_help_reflector, "button_help_reflector");
            this.button_help_reflector.Name = "button_help_reflector";
            this.button_help_reflector.UseVisualStyleBackColor = true;
            this.button_help_reflector.Click += new System.EventHandler(this.button_help_reflector_Click);
            // 
            // pictureBoxComm
            // 
            this.pictureBoxComm.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBoxComm, "pictureBoxComm");
            this.pictureBoxComm.Name = "pictureBoxComm";
            this.pictureBoxComm.TabStop = false;
            this.pictureBoxComm.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxComm_Paint);
            this.pictureBoxComm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxComm_MouseClick);
            // 
            // pictureBoxLight
            // 
            this.pictureBoxLight.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBoxLight, "pictureBoxLight");
            this.pictureBoxLight.Name = "pictureBoxLight";
            this.pictureBoxLight.TabStop = false;
            this.pictureBoxLight.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxLight_Paint);
            // 
            // pictureBoxKeyboard
            // 
            this.pictureBoxKeyboard.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBoxKeyboard, "pictureBoxKeyboard");
            this.pictureBoxKeyboard.Name = "pictureBoxKeyboard";
            this.pictureBoxKeyboard.TabStop = false;
            this.pictureBoxKeyboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxkeyboard_Paint);
            this.pictureBoxKeyboard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_keyboard_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // bolt1
            // 
            this.bolt1.BackColor = System.Drawing.Color.Transparent;
            this.bolt1.BackgroundImage = global::Enigma.Properties.Resources.болт;
            resources.ApplyResources(this.bolt1, "bolt1");
            this.bolt1.Name = "bolt1";
            this.bolt1.TabStop = false;
            // 
            // bolt3
            // 
            this.bolt3.BackColor = System.Drawing.Color.Transparent;
            this.bolt3.BackgroundImage = global::Enigma.Properties.Resources.болт;
            resources.ApplyResources(this.bolt3, "bolt3");
            this.bolt3.Name = "bolt3";
            this.bolt3.TabStop = false;
            // 
            // bolt2
            // 
            this.bolt2.BackColor = System.Drawing.Color.Transparent;
            this.bolt2.BackgroundImage = global::Enigma.Properties.Resources.болт;
            resources.ApplyResources(this.bolt2, "bolt2");
            this.bolt2.Name = "bolt2";
            this.bolt2.TabStop = false;
            // 
            // bolt4
            // 
            this.bolt4.BackColor = System.Drawing.Color.Transparent;
            this.bolt4.BackgroundImage = global::Enigma.Properties.Resources.болт;
            resources.ApplyResources(this.bolt4, "bolt4");
            this.bolt4.Name = "bolt4";
            this.bolt4.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Enigma.Properties.Resources.P_GHoyVtWBo;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBoxLight);
            this.panel1.Controls.Add(this.button_help_comm);
            this.panel1.Controls.Add(this.button_help_keyboard);
            this.panel1.Controls.Add(this.bolt2);
            this.panel1.Controls.Add(this.bolt3);
            this.panel1.Controls.Add(this.bolt1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bolt4);
            this.panel1.Controls.Add(this.button_help_light);
            this.panel1.Controls.Add(this.pictureBoxKeyboard);
            this.panel1.Controls.Add(this.pictureBoxComm);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Name = "label3";
            // 
            // button_help_rotors
            // 
            resources.ApplyResources(this.button_help_rotors, "button_help_rotors");
            this.button_help_rotors.Name = "button_help_rotors";
            this.button_help_rotors.UseVisualStyleBackColor = true;
            this.button_help_rotors.Click += new System.EventHandler(this.button_help_rotors_Click);
            // 
            // Main_Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Enigma.Properties.Resources.wood_29;
            this.Controls.Add(this.button_help_rotors);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_help_reflector);
            this.Controls.Add(this.button_help_machine);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.comboBox_machines);
            this.Controls.Add(this.checkBoxAuto);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.checkBox_panel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.comboBox_reflectors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxComm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeyboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolt4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_reflectors;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox_panel;
        private System.Windows.Forms.PictureBox pictureBoxKeyboard;
        private System.Windows.Forms.PictureBox pictureBoxLight;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.PictureBox pictureBoxComm;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.CheckBox checkBoxAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_machines;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_help_light;
        private System.Windows.Forms.Button button_help_machine;
        private System.Windows.Forms.Button button_help_keyboard;
        private System.Windows.Forms.Button button_help_comm;
        private System.Windows.Forms.Button button_help_reflector;
        private System.Windows.Forms.PictureBox bolt1;
        private System.Windows.Forms.PictureBox bolt3;
        private System.Windows.Forms.PictureBox bolt2;
        private System.Windows.Forms.PictureBox bolt4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_help_rotors;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
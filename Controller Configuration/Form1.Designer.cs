namespace Controller_Configuration
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label5 = new Label();
            btnRefresh = new Button();
            tB_BaudRate = new TextBox();
            btnConnectSer = new Button();
            comboBoxPorts = new ComboBox();
            groupBox2 = new GroupBox();
            btnCopy = new Button();
            btnClear = new Button();
            listBox1 = new ListBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btn_get_wifi = new Button();
            label6 = new Label();
            tb_wifi_password = new TextBox();
            btn_save_wifi = new Button();
            tb_wifi_name = new TextBox();
            groupBox5 = new GroupBox();
            btn_off_relay = new Button();
            btn_send_telegram = new Button();
            btn_relay_on = new Button();
            btn_relay_off = new Button();
            groupBox4 = new GroupBox();
            btn_get_kwh_setting = new Button();
            tb_kwh_minimum = new TextBox();
            label3 = new Label();
            btn_save_kwh_setting = new Button();
            tb_pulse_kwh = new TextBox();
            label4 = new Label();
            groupBox6 = new GroupBox();
            btn_get_telegram = new Button();
            tb_recipient_userid = new TextBox();
            label7 = new Label();
            btn_save_telegram = new Button();
            tb_token_telegram = new TextBox();
            label8 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(tB_BaudRate);
            groupBox1.Controls.Add(btnConnectSer);
            groupBox1.Controls.Add(comboBoxPorts);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(502, 126);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Serial Configuration";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(17, 40);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 18;
            label1.Text = "Serial Port :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(17, 78);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 17;
            label5.Text = "Baud Rate :";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(385, 36);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // tB_BaudRate
            // 
            tB_BaudRate.Location = new Point(112, 76);
            tB_BaudRate.Name = "tB_BaudRate";
            tB_BaudRate.Size = new Size(141, 27);
            tB_BaudRate.TabIndex = 4;
            tB_BaudRate.Text = "115200";
            tB_BaudRate.TextChanged += tB_BaudRate_TextChanged;
            // 
            // btnConnectSer
            // 
            btnConnectSer.Location = new Point(382, 78);
            btnConnectSer.Name = "btnConnectSer";
            btnConnectSer.Size = new Size(97, 29);
            btnConnectSer.TabIndex = 2;
            btnConnectSer.Text = "Connect";
            btnConnectSer.UseVisualStyleBackColor = true;
            btnConnectSer.Click += btnConnectSer_Click;
            // 
            // comboBoxPorts
            // 
            comboBoxPorts.FormattingEnabled = true;
            comboBoxPorts.Location = new Point(112, 36);
            comboBoxPorts.Name = "comboBoxPorts";
            comboBoxPorts.Size = new Size(243, 28);
            comboBoxPorts.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCopy);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new Point(520, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(786, 458);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Logs";
            // 
            // btnCopy
            // 
            btnCopy.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCopy.Location = new Point(10, 423);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(94, 29);
            btnCopy.TabIndex = 2;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(686, 423);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(10, 39);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(770, 384);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.MouseDown += listBox1_MouseDown;
            listBox1.MouseMove += listBox1_MouseMove;
            listBox1.MouseUp += listBox1_MouseUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 3;
            label2.Text = "Wi-Fi Name";
            label2.Click += label2_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_get_wifi);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(tb_wifi_password);
            groupBox3.Controls.Add(btn_save_wifi);
            groupBox3.Controls.Add(tb_wifi_name);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(12, 144);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(502, 112);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Wifi Setting";
            // 
            // btn_get_wifi
            // 
            btn_get_wifi.Location = new Point(385, 35);
            btn_get_wifi.Name = "btn_get_wifi";
            btn_get_wifi.Size = new Size(97, 27);
            btn_get_wifi.TabIndex = 16;
            btn_get_wifi.Text = "Get Data";
            btn_get_wifi.UseVisualStyleBackColor = true;
            btn_get_wifi.Click += btn_get_wifi_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.ForeColor = Color.CornflowerBlue;
            label6.Location = new Point(6, 70);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 15;
            label6.Text = "Wi-Fi password";
            label6.Click += label6_Click_1;
            // 
            // tb_wifi_password
            // 
            tb_wifi_password.Location = new Point(129, 67);
            tb_wifi_password.Name = "tb_wifi_password";
            tb_wifi_password.Size = new Size(226, 27);
            tb_wifi_password.TabIndex = 14;
            // 
            // btn_save_wifi
            // 
            btn_save_wifi.Location = new Point(385, 67);
            btn_save_wifi.Name = "btn_save_wifi";
            btn_save_wifi.Size = new Size(97, 27);
            btn_save_wifi.TabIndex = 10;
            btn_save_wifi.Text = "Save";
            btn_save_wifi.UseVisualStyleBackColor = true;
            btn_save_wifi.Click += button4_Click;
            // 
            // tb_wifi_name
            // 
            tb_wifi_name.Location = new Point(129, 35);
            tb_wifi_name.Name = "tb_wifi_name";
            tb_wifi_name.Size = new Size(226, 27);
            tb_wifi_name.TabIndex = 4;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(button1);
            groupBox5.Controls.Add(btn_off_relay);
            groupBox5.Controls.Add(btn_send_telegram);
            groupBox5.Controls.Add(btn_relay_on);
            groupBox5.Location = new Point(520, 474);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(786, 118);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Device Control";
            // 
            // btn_off_relay
            // 
            btn_off_relay.BackColor = Color.DarkSlateGray;
            btn_off_relay.Font = new Font("Microsoft Sans Serif", 15F);
            btn_off_relay.ForeColor = Color.Cornsilk;
            btn_off_relay.Location = new Point(187, 33);
            btn_off_relay.Name = "btn_off_relay";
            btn_off_relay.RightToLeft = RightToLeft.Yes;
            btn_off_relay.Size = new Size(171, 64);
            btn_off_relay.TabIndex = 3;
            btn_off_relay.Text = "RELAY-OFF";
            btn_off_relay.UseVisualStyleBackColor = false;
            btn_off_relay.Click += button1_Click;
            // 
            // btn_send_telegram
            // 
            btn_send_telegram.BackColor = Color.DodgerBlue;
            btn_send_telegram.Font = new Font("Microsoft Sans Serif", 15F);
            btn_send_telegram.ForeColor = Color.Cornsilk;
            btn_send_telegram.Location = new Point(364, 33);
            btn_send_telegram.Name = "btn_send_telegram";
            btn_send_telegram.RightToLeft = RightToLeft.Yes;
            btn_send_telegram.Size = new Size(257, 64);
            btn_send_telegram.TabIndex = 2;
            btn_send_telegram.Text = "SEND TELEGRAM";
            btn_send_telegram.UseVisualStyleBackColor = false;
            btn_send_telegram.Click += btn_send_telegram_Click;
            // 
            // btn_relay_on
            // 
            btn_relay_on.BackColor = Color.DarkTurquoise;
            btn_relay_on.Font = new Font("Microsoft Sans Serif", 15F);
            btn_relay_on.ForeColor = Color.Cornsilk;
            btn_relay_on.Location = new Point(10, 33);
            btn_relay_on.Name = "btn_relay_on";
            btn_relay_on.RightToLeft = RightToLeft.Yes;
            btn_relay_on.Size = new Size(171, 64);
            btn_relay_on.TabIndex = 1;
            btn_relay_on.Text = "RELAY-ON";
            btn_relay_on.UseVisualStyleBackColor = false;
            btn_relay_on.Click += btn_relay_on_Click;
            // 
            // btn_relay_off
            // 
            btn_relay_off.Location = new Point(0, 0);
            btn_relay_off.Name = "btn_relay_off";
            btn_relay_off.Size = new Size(75, 23);
            btn_relay_off.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btn_get_kwh_setting);
            groupBox4.Controls.Add(tb_kwh_minimum);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(btn_save_kwh_setting);
            groupBox4.Controls.Add(tb_pulse_kwh);
            groupBox4.Controls.Add(label4);
            groupBox4.Location = new Point(12, 262);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(502, 111);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kwh Setting";
            // 
            // btn_get_kwh_setting
            // 
            btn_get_kwh_setting.Location = new Point(385, 35);
            btn_get_kwh_setting.Name = "btn_get_kwh_setting";
            btn_get_kwh_setting.Size = new Size(97, 27);
            btn_get_kwh_setting.TabIndex = 13;
            btn_get_kwh_setting.Text = "Get Data";
            btn_get_kwh_setting.UseVisualStyleBackColor = true;
            btn_get_kwh_setting.Click += btn_get_kwh_setting_Click;
            // 
            // tb_kwh_minimum
            // 
            tb_kwh_minimum.Location = new Point(224, 71);
            tb_kwh_minimum.Name = "tb_kwh_minimum";
            tb_kwh_minimum.Size = new Size(131, 27);
            tb_kwh_minimum.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(6, 74);
            label3.Name = "label3";
            label3.Size = new Size(212, 20);
            label3.TabIndex = 11;
            label3.Text = "Kwh Minimum (Notification)";
            // 
            // btn_save_kwh_setting
            // 
            btn_save_kwh_setting.Location = new Point(385, 71);
            btn_save_kwh_setting.Name = "btn_save_kwh_setting";
            btn_save_kwh_setting.Size = new Size(97, 27);
            btn_save_kwh_setting.TabIndex = 10;
            btn_save_kwh_setting.Text = "Save";
            btn_save_kwh_setting.UseVisualStyleBackColor = true;
            btn_save_kwh_setting.Click += btn_save_kwh_setting_Click;
            // 
            // tb_pulse_kwh
            // 
            tb_pulse_kwh.Location = new Point(129, 35);
            tb_pulse_kwh.Name = "tb_pulse_kwh";
            tb_pulse_kwh.Size = new Size(226, 27);
            tb_pulse_kwh.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(6, 35);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 3;
            label4.Text = "Pulse (Kwh)";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btn_get_telegram);
            groupBox6.Controls.Add(tb_recipient_userid);
            groupBox6.Controls.Add(label7);
            groupBox6.Controls.Add(btn_save_telegram);
            groupBox6.Controls.Add(tb_token_telegram);
            groupBox6.Controls.Add(label8);
            groupBox6.Location = new Point(12, 379);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(502, 111);
            groupBox6.TabIndex = 8;
            groupBox6.TabStop = false;
            groupBox6.Text = "Telegram Setting";
            // 
            // btn_get_telegram
            // 
            btn_get_telegram.Location = new Point(385, 38);
            btn_get_telegram.Name = "btn_get_telegram";
            btn_get_telegram.Size = new Size(97, 27);
            btn_get_telegram.TabIndex = 13;
            btn_get_telegram.Text = "Get Data";
            btn_get_telegram.UseVisualStyleBackColor = true;
            btn_get_telegram.Click += btn_get_telegram_Click;
            // 
            // tb_recipient_userid
            // 
            tb_recipient_userid.Location = new Point(142, 71);
            tb_recipient_userid.Name = "tb_recipient_userid";
            tb_recipient_userid.Size = new Size(213, 27);
            tb_recipient_userid.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.ForeColor = SystemColors.MenuHighlight;
            label7.Location = new Point(6, 74);
            label7.Name = "label7";
            label7.Size = new Size(130, 20);
            label7.TabIndex = 11;
            label7.Text = "Recipient User ID";
            // 
            // btn_save_telegram
            // 
            btn_save_telegram.Location = new Point(385, 71);
            btn_save_telegram.Name = "btn_save_telegram";
            btn_save_telegram.Size = new Size(97, 27);
            btn_save_telegram.TabIndex = 10;
            btn_save_telegram.Text = "Save";
            btn_save_telegram.UseVisualStyleBackColor = true;
            btn_save_telegram.Click += btn_save_telegram_Click;
            // 
            // tb_token_telegram
            // 
            tb_token_telegram.Location = new Point(92, 35);
            tb_token_telegram.Name = "tb_token_telegram";
            tb_token_telegram.Size = new Size(263, 27);
            tb_token_telegram.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label8.ForeColor = SystemColors.MenuHighlight;
            label8.Location = new Point(6, 35);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 3;
            label8.Text = "Bot Token";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Segoe UI", 15F);
            button1.ForeColor = Color.Cornsilk;
            button1.Location = new Point(627, 33);
            button1.Name = "button1";
            button1.Size = new Size(153, 64);
            button1.TabIndex = 4;
            button1.Text = "REBOOT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 603);
            Controls.Add(groupBox6);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Device Configuration";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBoxPorts;
        private Button btnConnectSer;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnClear;
        private ListBox listBox1;
        private GroupBox groupBox3;
        private TextBox tb_wifi_name;
        private Button btn_save_wifi;
        private TextBox tB_BaudRate;
        private Button btnCopy;
        private Button btnRefresh;
        private TextBox tb_wifi_password;
        private Label label6;
        private GroupBox groupBox5;
        private Button btn_relay_off;
        private GroupBox groupBox4;
        private Label label3;
        private Button btn_save_kwh_setting;
        private TextBox tb_pulse_kwh;
        private Label label4;
        private TextBox tb_kwh_minimum;
        private GroupBox groupBox6;
        private TextBox tb_recipient_userid;
        private Label label7;
        private Button btn_save_telegram;
        private TextBox tb_token_telegram;
        private Label label8;
        private Button btn_get_wifi;
        private Button btn_get_kwh_setting;
        private Button btn_get_telegram;
        private ContextMenuStrip contextMenuStrip1;
        private Button btn_send_telegram;
        private Button btn_relay_on;
        private Label label1;
        private Label label5;
        private Button btn_off_relay;
        private Button button1;
    }
}

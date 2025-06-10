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
            btn_show_passwod = new Button();
            btn_get_wifi = new Button();
            label6 = new Label();
            tb_wifi_password = new TextBox();
            btn_save_wifi = new Button();
            tb_wifi_name = new TextBox();
            groupBox5 = new GroupBox();
            btn_relay_normal = new Button();
            btn_reboot = new Button();
            btn_off_relay = new Button();
            btn_send_telegram = new Button();
            btn_relay_on = new Button();
            btn_relay_off = new Button();
            groupBox4 = new GroupBox();
            label15 = new Label();
            tb_menit = new TextBox();
            label14 = new Label();
            tb_jam = new TextBox();
            label13 = new Label();
            tb_tdl = new TextBox();
            label12 = new Label();
            tb_time_sampling = new TextBox();
            label11 = new Label();
            btn_topup = new Button();
            btn_reset_0 = new Button();
            label10 = new Label();
            tb_daily_limit = new TextBox();
            label9 = new Label();
            btn_get_kwh_setting = new Button();
            tb_kwh_minimum = new TextBox();
            label3 = new Label();
            btn_save_kwh_setting = new Button();
            tb_pulse_kwh = new TextBox();
            label4 = new Label();
            lbl_sisa_kwh = new Label();
            groupBox6 = new GroupBox();
            btn_get_telegram = new Button();
            tb_recipient_userid = new TextBox();
            label7 = new Label();
            btn_save_telegram = new Button();
            tb_token_telegram = new TextBox();
            label8 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
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
            groupBox1.Size = new Size(565, 126);
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
            btnRefresh.Location = new Point(462, 36);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(97, 29);
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
            btnConnectSer.Location = new Point(462, 78);
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
            comboBoxPorts.Size = new Size(344, 28);
            comboBoxPorts.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCopy);
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new Point(583, 12);
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
            groupBox3.Controls.Add(btn_show_passwod);
            groupBox3.Controls.Add(btn_get_wifi);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(tb_wifi_password);
            groupBox3.Controls.Add(btn_save_wifi);
            groupBox3.Controls.Add(tb_wifi_name);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(12, 144);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(565, 112);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Wifi Setting";
            // 
            // btn_show_passwod
            // 
            btn_show_passwod.Location = new Point(398, 66);
            btn_show_passwod.Name = "btn_show_passwod";
            btn_show_passwod.Size = new Size(58, 29);
            btn_show_passwod.TabIndex = 17;
            btn_show_passwod.Text = "Show";
            btn_show_passwod.UseVisualStyleBackColor = true;
            btn_show_passwod.Click += btn_show_passwod_Click;
            btn_show_passwod.MouseDown += btn_show_passwod_MouseDown;
            btn_show_passwod.MouseUp += btn_show_passwod_MouseUp;
            // 
            // btn_get_wifi
            // 
            btn_get_wifi.Location = new Point(462, 35);
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
            tb_wifi_password.PasswordChar = '*';
            tb_wifi_password.Size = new Size(267, 27);
            tb_wifi_password.TabIndex = 14;
            // 
            // btn_save_wifi
            // 
            btn_save_wifi.Location = new Point(462, 66);
            btn_save_wifi.Name = "btn_save_wifi";
            btn_save_wifi.Size = new Size(97, 29);
            btn_save_wifi.TabIndex = 10;
            btn_save_wifi.Text = "Save";
            btn_save_wifi.UseVisualStyleBackColor = true;
            btn_save_wifi.Click += button4_Click;
            // 
            // tb_wifi_name
            // 
            tb_wifi_name.Location = new Point(129, 35);
            tb_wifi_name.Name = "tb_wifi_name";
            tb_wifi_name.Size = new Size(327, 27);
            tb_wifi_name.TabIndex = 4;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(btn_relay_normal);
            groupBox5.Controls.Add(btn_reboot);
            groupBox5.Controls.Add(btn_off_relay);
            groupBox5.Controls.Add(btn_send_telegram);
            groupBox5.Controls.Add(btn_relay_on);
            groupBox5.Location = new Point(583, 473);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(786, 118);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "Device Control";
            // 
            // btn_relay_normal
            // 
            btn_relay_normal.BackColor = Color.DarkViolet;
            btn_relay_normal.Font = new Font("Microsoft Sans Serif", 9F);
            btn_relay_normal.ForeColor = Color.Cornsilk;
            btn_relay_normal.Location = new Point(10, 67);
            btn_relay_normal.Name = "btn_relay_normal";
            btn_relay_normal.RightToLeft = RightToLeft.Yes;
            btn_relay_normal.Size = new Size(256, 45);
            btn_relay_normal.TabIndex = 5;
            btn_relay_normal.Text = "Relay Back To Normal";
            btn_relay_normal.UseVisualStyleBackColor = false;
            btn_relay_normal.Click += btn_relay_normal_Click;
            // 
            // btn_reboot
            // 
            btn_reboot.BackColor = Color.Crimson;
            btn_reboot.Font = new Font("Segoe UI", 15F);
            btn_reboot.ForeColor = Color.Cornsilk;
            btn_reboot.Location = new Point(448, 26);
            btn_reboot.Name = "btn_reboot";
            btn_reboot.Size = new Size(153, 86);
            btn_reboot.TabIndex = 4;
            btn_reboot.Text = "REBOOT";
            btn_reboot.UseVisualStyleBackColor = false;
            btn_reboot.Click += button1_Click_1;
            // 
            // btn_off_relay
            // 
            btn_off_relay.BackColor = Color.DarkSlateGray;
            btn_off_relay.Font = new Font("Microsoft Sans Serif", 9F);
            btn_off_relay.ForeColor = Color.Cornsilk;
            btn_off_relay.Location = new Point(145, 24);
            btn_off_relay.Name = "btn_off_relay";
            btn_off_relay.RightToLeft = RightToLeft.Yes;
            btn_off_relay.Size = new Size(121, 44);
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
            btn_send_telegram.Location = new Point(272, 26);
            btn_send_telegram.Name = "btn_send_telegram";
            btn_send_telegram.RightToLeft = RightToLeft.Yes;
            btn_send_telegram.Size = new Size(170, 86);
            btn_send_telegram.TabIndex = 2;
            btn_send_telegram.Text = "SEND TELEGRAM";
            btn_send_telegram.UseVisualStyleBackColor = false;
            btn_send_telegram.Click += btn_send_telegram_Click;
            // 
            // btn_relay_on
            // 
            btn_relay_on.BackColor = Color.DarkTurquoise;
            btn_relay_on.Font = new Font("Microsoft Sans Serif", 9F);
            btn_relay_on.ForeColor = Color.Cornsilk;
            btn_relay_on.Location = new Point(10, 24);
            btn_relay_on.Name = "btn_relay_on";
            btn_relay_on.RightToLeft = RightToLeft.Yes;
            btn_relay_on.Size = new Size(129, 44);
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
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(tb_menit);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(tb_jam);
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(tb_tdl);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(tb_time_sampling);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(btn_topup);
            groupBox4.Controls.Add(btn_reset_0);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(tb_daily_limit);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(btn_get_kwh_setting);
            groupBox4.Controls.Add(tb_kwh_minimum);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(btn_save_kwh_setting);
            groupBox4.Controls.Add(tb_pulse_kwh);
            groupBox4.Controls.Add(label4);
            groupBox4.Controls.Add(lbl_sisa_kwh);
            groupBox4.Location = new Point(12, 262);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(565, 212);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kwh Setting";
            groupBox4.Enter += groupBox4_Enter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label15.ForeColor = SystemColors.MenuHighlight;
            label15.Location = new Point(398, 105);
            label15.Name = "label15";
            label15.Size = new Size(47, 19);
            label15.TabIndex = 28;
            label15.Text = "Menit";
            // 
            // tb_menit
            // 
            tb_menit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tb_menit.Location = new Point(398, 127);
            tb_menit.Name = "tb_menit";
            tb_menit.Size = new Size(51, 27);
            tb_menit.TabIndex = 27;
            tb_menit.TextAlign = HorizontalAlignment.Right;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label14.ForeColor = SystemColors.MenuText;
            label14.Location = new Point(383, 130);
            label14.Name = "label14";
            label14.Size = new Size(13, 20);
            label14.TabIndex = 26;
            label14.Text = ":";
            label14.TextAlign = ContentAlignment.TopRight;
            // 
            // tb_jam
            // 
            tb_jam.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tb_jam.Location = new Point(329, 127);
            tb_jam.Name = "tb_jam";
            tb_jam.Size = new Size(51, 27);
            tb_jam.TabIndex = 25;
            tb_jam.TextAlign = HorizontalAlignment.Right;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label13.ForeColor = SystemColors.MenuHighlight;
            label13.Location = new Point(336, 105);
            label13.Name = "label13";
            label13.Size = new Size(36, 19);
            label13.TabIndex = 24;
            label13.Text = "Jam";
            label13.Click += label13_Click;
            // 
            // tb_tdl
            // 
            tb_tdl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tb_tdl.Location = new Point(167, 179);
            tb_tdl.Name = "tb_tdl";
            tb_tdl.Size = new Size(157, 27);
            tb_tdl.TabIndex = 23;
            tb_tdl.TextAlign = HorizontalAlignment.Right;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label12.ForeColor = Color.SeaGreen;
            label12.Location = new Point(167, 157);
            label12.Name = "label12";
            label12.Size = new Size(157, 19);
            label12.TabIndex = 22;
            label12.Text = "Tarif Dasar Listrik (Rp)";
            label12.Click += label12_Click;
            // 
            // tb_time_sampling
            // 
            tb_time_sampling.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tb_time_sampling.Location = new Point(6, 179);
            tb_time_sampling.Name = "tb_time_sampling";
            tb_time_sampling.Size = new Size(155, 27);
            tb_time_sampling.TabIndex = 21;
            tb_time_sampling.TextAlign = HorizontalAlignment.Right;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label11.ForeColor = Color.Indigo;
            label11.Location = new Point(6, 157);
            label11.Name = "label11";
            label11.Size = new Size(138, 19);
            label11.TabIndex = 20;
            label11.Text = "Waktu Sampling (s)";
            // 
            // btn_topup
            // 
            btn_topup.BackColor = Color.YellowGreen;
            btn_topup.ForeColor = Color.Snow;
            btn_topup.Location = new Point(462, 26);
            btn_topup.Name = "btn_topup";
            btn_topup.Size = new Size(97, 34);
            btn_topup.TabIndex = 19;
            btn_topup.Text = "Topup";
            btn_topup.UseVisualStyleBackColor = false;
            btn_topup.Click += btn_topup_Click;
            // 
            // btn_reset_0
            // 
            btn_reset_0.BackColor = Color.Red;
            btn_reset_0.ForeColor = Color.White;
            btn_reset_0.Location = new Point(465, 158);
            btn_reset_0.Name = "btn_reset_0";
            btn_reset_0.Size = new Size(97, 39);
            btn_reset_0.TabIndex = 18;
            btn_reset_0.Text = "Reset 0";
            btn_reset_0.UseVisualStyleBackColor = false;
            btn_reset_0.Click += btn_reset_0_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = SystemColors.MenuText;
            label10.Location = new Point(167, 23);
            label10.Name = "label10";
            label10.Size = new Size(79, 20);
            label10.TabIndex = 16;
            label10.Text = "Sisa Kwh :";
            label10.TextAlign = ContentAlignment.TopRight;
            // 
            // tb_daily_limit
            // 
            tb_daily_limit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tb_daily_limit.Location = new Point(167, 127);
            tb_daily_limit.Name = "tb_daily_limit";
            tb_daily_limit.Size = new Size(157, 27);
            tb_daily_limit.TabIndex = 15;
            tb_daily_limit.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label9.ForeColor = SystemColors.MenuHighlight;
            label9.Location = new Point(167, 105);
            label9.Name = "label9";
            label9.Size = new Size(130, 19);
            label9.TabIndex = 14;
            label9.Text = "Batas Harian (Wh)";
            label9.Click += label9_Click;
            // 
            // btn_get_kwh_setting
            // 
            btn_get_kwh_setting.Location = new Point(465, 92);
            btn_get_kwh_setting.Name = "btn_get_kwh_setting";
            btn_get_kwh_setting.Size = new Size(97, 27);
            btn_get_kwh_setting.TabIndex = 13;
            btn_get_kwh_setting.Text = "Get Data";
            btn_get_kwh_setting.UseVisualStyleBackColor = true;
            btn_get_kwh_setting.Click += btn_get_kwh_setting_Click;
            // 
            // tb_kwh_minimum
            // 
            tb_kwh_minimum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tb_kwh_minimum.Location = new Point(6, 127);
            tb_kwh_minimum.Name = "tb_kwh_minimum";
            tb_kwh_minimum.Size = new Size(155, 27);
            tb_kwh_minimum.TabIndex = 12;
            tb_kwh_minimum.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(6, 105);
            label3.Name = "label3";
            label3.Size = new Size(155, 19);
            label3.TabIndex = 11;
            label3.Text = "Batas Notifikasi (Kwh)";
            // 
            // btn_save_kwh_setting
            // 
            btn_save_kwh_setting.Location = new Point(465, 125);
            btn_save_kwh_setting.Name = "btn_save_kwh_setting";
            btn_save_kwh_setting.Size = new Size(97, 27);
            btn_save_kwh_setting.TabIndex = 10;
            btn_save_kwh_setting.Text = "Save";
            btn_save_kwh_setting.UseVisualStyleBackColor = true;
            btn_save_kwh_setting.Click += btn_save_kwh_setting_Click;
            // 
            // tb_pulse_kwh
            // 
            tb_pulse_kwh.BackColor = SystemColors.ButtonHighlight;
            tb_pulse_kwh.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Bold);
            tb_pulse_kwh.Location = new Point(6, 47);
            tb_pulse_kwh.Name = "tb_pulse_kwh";
            tb_pulse_kwh.Size = new Size(143, 47);
            tb_pulse_kwh.TabIndex = 4;
            tb_pulse_kwh.Text = "0";
            tb_pulse_kwh.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label4.ForeColor = Color.SaddleBrown;
            label4.Location = new Point(5, 23);
            label4.Name = "label4";
            label4.Size = new Size(108, 19);
            label4.TabIndex = 3;
            label4.Text = "Isi Ulang (Kwh)";
            // 
            // lbl_sisa_kwh
            // 
            lbl_sisa_kwh.AutoSize = true;
            lbl_sisa_kwh.Font = new Font("Segoe UI Semilight", 18F, FontStyle.Bold);
            lbl_sisa_kwh.ForeColor = SystemColors.MenuText;
            lbl_sisa_kwh.Location = new Point(167, 50);
            lbl_sisa_kwh.Name = "lbl_sisa_kwh";
            lbl_sisa_kwh.Size = new Size(35, 41);
            lbl_sisa_kwh.TabIndex = 17;
            lbl_sisa_kwh.Text = "0";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(btn_get_telegram);
            groupBox6.Controls.Add(tb_recipient_userid);
            groupBox6.Controls.Add(label7);
            groupBox6.Controls.Add(btn_save_telegram);
            groupBox6.Controls.Add(tb_token_telegram);
            groupBox6.Controls.Add(label8);
            groupBox6.Location = new Point(12, 480);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(565, 111);
            groupBox6.TabIndex = 8;
            groupBox6.TabStop = false;
            groupBox6.Text = "Telegram Setting";
            // 
            // btn_get_telegram
            // 
            btn_get_telegram.Location = new Point(462, 35);
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
            tb_recipient_userid.Size = new Size(314, 27);
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
            btn_save_telegram.Location = new Point(462, 71);
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
            tb_token_telegram.Size = new Size(364, 27);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 603);
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
        private Button btn_reboot;
        private Label label9;
        private TextBox tb_daily_limit;
        private Label label10;
        private Label lbl_sisa_kwh;
        private Button btn_reset_0;
        private Button btn_topup;
        private Label label11;
        private TextBox tb_time_sampling;
        private Label label12;
        private TextBox tb_tdl;
        private Button btn_relay_normal;
        private Label label14;
        private TextBox tb_jam;
        private Label label13;
        private TextBox tb_menit;
        private Label label15;
        private Button btn_show_passwod;
    }
}

namespace Controller_Configuration
{
    using System;
    using System.IO.Ports;
    using System.Text;
    using System.Windows.Forms;
    using System.Diagnostics;

    public partial class Form1 : Form
    {
        private SerialPort serialPort1 = new SerialPort();
        private bool isSerialConnected = false;
        private bool isDragging = false;

        public Form1()
        {
            InitializeComponent();
            ScanAndListPorts();
            serialPort1.DataReceived += SerialPort1_DataReceived; // Tambah event handler
            serialPort1.ReadTimeout = 50;  // Waktu timeout pembacaan (ms)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Load Form");
            this.enable_component(false);
        }

        private void ScanAndListPorts()
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                comboBoxPorts.Items.Clear();

                foreach (string port in ports)
                {
                    comboBoxPorts.Items.Add(port);
                }

                if (comboBoxPorts.Items.Count > 0)
                {
                    comboBoxPorts.SelectedIndex = 0;
                }
                else
                {
                    comboBoxPorts.Items.Add("No COM ports found");
                    comboBoxPorts.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error scanning ports: " + ex.Message);
            }
        }

        private void btnConnectSer_Click(object sender, EventArgs e)
        {
            try
            {
                // Pastikan comboBoxPorts tidak null dan memiliki item yang valid
                if (comboBoxPorts?.SelectedItem == null || comboBoxPorts.SelectedItem.ToString().StartsWith("No"))
                {
                    MessageBox.Show("Pilih COM port yang tersedia terlebih dahulu.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = comboBoxPorts.SelectedItem.ToString();

                    // Validasi BaudRate dari TextBox
                    if (!int.TryParse(tB_BaudRate?.Text, out int baudRate))
                    {
                        MessageBox.Show("Baud rate tidak valid.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    serialPort1.BaudRate = baudRate;

                    // Event handler untuk data masuk dari serial
                    //serialPort1.DataReceived += (s, evt) =>
                    //{
                    //    string incoming = serialPort1.ReadExisting();
                    //    Invoke(new Action(() => listBox1.Items.Add($"[Serial] {incoming}")));
                    //};

                    serialPort1.Open();
                    listBox1.Items.Add($"[✓] Connected to {serialPort1.PortName} @ {serialPort1.BaudRate} baud");
                    listBox1.TopIndex = listBox1.Items.Count - 1;

                    isSerialConnected = true;
                    btnConnectSer.Text = "Disconnect";
                    btnConnectSer.BackColor = System.Drawing.Color.Red;

                    this.enable_component(true);
                }
                else
                {
                    isSerialConnected = false;
                    btnConnectSer.Text = "Connect";
                    btnConnectSer.BackColor = SystemColors.Control;
                    listBox1.Items.Add("[!] Serial disconnected.");
                    listBox1.TopIndex = listBox1.Items.Count - 1;
                    serialPort1.Close();

                    this.enable_component(false);
                }
            }
            catch (Exception ex)
            {
                listBox1.Items.Add("[X] Error: " + ex.Message);
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
        }


        StringBuilder serialBuffer = new StringBuilder();

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string incomingData = serialPort1.ReadExisting();
            serialBuffer.Append(incomingData);

            // Cek apakah ada akhir baris
            while (serialBuffer.ToString().Contains("\n"))
            {
                string fullLine = "";
                int index = serialBuffer.ToString().IndexOf('\n');
                if (index >= 0)
                {
                    fullLine = serialBuffer.ToString(0, index + 1); // Ambil sampai \n
                    serialBuffer.Remove(0, index + 1); // Hapus yang sudah dibaca

                    this.BeginInvoke(new Action(() =>
                    {
                        string formatted = "[Recv] " + fullLine.Trim();
                        Debug.WriteLine(formatted);

                        string startTag = "<";
                        string endTag = ">";

                        int startIndex = formatted.IndexOf(startTag);
                        int endIndex = formatted.IndexOf(endTag);

                        if (startIndex != -1 && endIndex != -1 && endIndex > startIndex)
                        {
                            // Ambil substring antara < dan >
                            string data = formatted.Substring(startIndex + startTag.Length, endIndex - startIndex - startTag.Length);

                            // Pisahkan berdasarkan koma
                            string[] parts = data.Split(',');

                            string route_id = parts[0];
                            if (route_id == "1" && parts.Length >= 3)
                            {
                                tb_wifi_name.Text = parts[1];
                                tb_wifi_password.Text = parts[2];
                            }
                            else if (route_id == "2" && parts.Length >= 3)
                            {
                                tb_pulse_kwh.Text = parts[1];
                                tb_kwh_minimum.Text = parts[2];
                                tb_daily_limit.Text = parts[3];
                                lbl_sisa_kwh.Text = parts[4];
                                tb_time_sampling.Text = parts[5];
                                tb_tdl.Text = parts[6];
                            }
                            else if (route_id == "3" && parts.Length >= 3)
                            {
                                tb_token_telegram.Text = parts[1];
                                tb_recipient_userid.Text = parts[2];
                            }

                            Debug.WriteLine(data);
                        }
                        else
                        {
                            System.Diagnostics.Debug.WriteLine("Format tidak valid.");
                        }


                        listBox1.Items.Add(formatted);
                        listBox1.TopIndex = listBox1.Items.Count - 1;

                        // Update horizontal scrollbar
                        int maxWidth = 0;
                        using (Graphics g = listBox1.CreateGraphics())
                        {
                            foreach (var item in listBox1.Items)
                            {
                                int itemWidth = (int)g.MeasureString(item.ToString(), listBox1.Font).Width;
                                if (itemWidth > maxWidth)
                                    maxWidth = itemWidth;
                            }
                        }
                        listBox1.HorizontalExtent = maxWidth;
                    }));
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1 != null && serialPort1.IsOpen)
                {
                    //string dataToSend = $"<s>10001,{tb_wifi_name.Text},{tb_wifi_password.Text},{tb_Duty.Text},{tb_Duration.Text},{tb_QRPulse.Text},{tb_RateConversion.Text}<e>";

                    //if (!string.IsNullOrWhiteSpace(dataToSend))
                    //{
                    //    serialPort1.WriteLine(dataToSend);
                    //    listBox1.Items.Add($"[→] Sent: {dataToSend}");
                    //    listBox1.TopIndex = listBox1.Items.Count - 1;
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Input kosong. Masukkan teks untuk dikirim.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //}
                }
                else
                {
                    MessageBox.Show("Port serial belum terhubung.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                listBox1.Items.Add("[X] Error sending data: " + ex.Message);
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Properties.Settings.Default.wifi_name = tb_wifi_name.Text;
            //    Properties.Settings.Default.wifi_password = tb_wifi_password.Text;
            //    Properties.Settings.Default.Save();
            //}
            //catch (Exception exWifSave)
            //{
            //    Console.Write(exWifSave.Message);
            //}

            try
            {
                if (serialPort1 != null && serialPort1.IsOpen)
                {
                    string dataToSend = $"<1,{tb_wifi_name.Text},{tb_wifi_password.Text}>"; // get nvs data

                    if (!string.IsNullOrWhiteSpace(dataToSend))
                    {
                        serialPort1.WriteLine(dataToSend);
                        listBox1.Items.Add($"[→] Sent: {dataToSend}");
                        listBox1.TopIndex = listBox1.Items.Count - 1;
                    }
                    else
                    {
                        MessageBox.Show("Input kosong. Masukkan teks untuk dikirim.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Port serial belum terhubung.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                listBox1.Items.Add("[X] Error sending data: " + ex.Message);
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            // Check if the listBox has items
            //if (listBox1.Items.Count > 0)
            //{
            //    // Join all items as a string separated by newlines
            //    string allItems = string.Join(Environment.NewLine, listBox1.Items.Cast<object>().Select(item => item.ToString()));

            //    // Copy to clipboard
            //    Clipboard.SetText(allItems);
            //}
            //else
            //{
            //    MessageBox.Show("Tidak ada data atau kosong.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            if (listBox1.SelectedItems.Count > 0)
            {
                string selectedItems = string.Join(Environment.NewLine, listBox1.SelectedItems.Cast<object>().Select(item => item.ToString()));
                if (selectedItems.Length > 0)
                {
                    SafeClipboardSetText(selectedItems);
                }
            }
            else
            {
                MessageBox.Show("Harap pilih setidaknya satu item untuk disalin.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ScanAndListPorts();
        }

        private void tB_BaudRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int index = listBox1.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches)
                {
                    isDragging = true;
                    listBox1.SelectedIndices.Clear(); // Optional: clear old selection
                    listBox1.SelectedIndex = index;
                }
            }
        }

        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int index = listBox1.IndexFromPoint(e.Location);
                if (index != ListBox.NoMatches && !listBox1.SelectedIndices.Contains(index))
                {
                    listBox1.SelectedIndices.Add(index);
                }
            }
        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        public void SafeClipboardSetText(string text)
        {
            const int maxTries = 5;
            const int delayMs = 100;

            for (int i = 0; i < maxTries; i++)
            {
                try
                {
                    Clipboard.SetText(text);
                    return; // success
                }
                catch (System.Runtime.InteropServices.ExternalException)
                {
                    System.Threading.Thread.Sleep(delayMs);
                }
            }

            MessageBox.Show("Failed to copy to clipboard. Another app may be locking it.", "Clipboard Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_get_wifi_Click(object sender, EventArgs e)
        {
            string dataToSend = $"<1>";

            if (!string.IsNullOrWhiteSpace(dataToSend))
            {
                serialPort1.WriteLine(dataToSend);
                listBox1.Items.Add($"[→] Sent: {dataToSend}");
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("Input kosong. Masukkan teks untuk dikirim.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_get_kwh_setting_Click(object sender, EventArgs e)
        {
            string dataToSend = $"<2>";

            if (!string.IsNullOrWhiteSpace(dataToSend))
            {
                serialPort1.WriteLine(dataToSend);
                listBox1.Items.Add($"[→] Sent: {dataToSend}");
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("Input kosong. Masukkan teks untuk dikirim.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_save_kwh_setting_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Properties.Settings.Default.pulse_kwh = tb_pulse_kwh.Text;
            //    Properties.Settings.Default.kwh_minimum = tb_kwh_minimum.Text;
            //    Properties.Settings.Default.Save();
            //}
            //catch (Exception exWifSave)
            //{
            //    Console.Write(exWifSave.Message);
            //}

            string dataToSend = $"<2,{tb_kwh_minimum.Text},{tb_daily_limit.Text},{tb_time_sampling.Text},{tb_tdl.Text}>";

            if (!string.IsNullOrWhiteSpace(dataToSend))
            {
                serialPort1.WriteLine(dataToSend);
                listBox1.Items.Add($"[→] Sent: {dataToSend}");
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("Input kosong. Masukkan teks untuk dikirim.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_get_telegram_Click(object sender, EventArgs e)
        {
            string dataToSend = $"<3>";

            if (!string.IsNullOrWhiteSpace(dataToSend))
            {
                serialPort1.WriteLine(dataToSend);
                listBox1.Items.Add($"[→] Sent: {dataToSend}");
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("Input kosong. Masukkan teks untuk dikirim.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_save_telegram_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Properties.Settings.Default.token_telegram = tb_token_telegram.Text;
            //    Properties.Settings.Default.recipient_id = tb_recipient_userid.Text;
            //    Properties.Settings.Default.Save();
            //}
            //catch (Exception exWifSave)
            //{
            //    Console.Write(exWifSave.Message);
            //}

            string dataToSend = $"<3,{tb_token_telegram.Text},{tb_recipient_userid.Text}>";

            if (!string.IsNullOrWhiteSpace(dataToSend))
            {
                serialPort1.WriteLine(dataToSend);
                listBox1.Items.Add($"[→] Sent: {dataToSend}");
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("Input kosong. Masukkan teks untuk dikirim.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_relay_on_Click(object sender, EventArgs e)
        {
            string dataToSend = $"<11>";

            if (!string.IsNullOrWhiteSpace(dataToSend))
            {
                serialPort1.WriteLine(dataToSend);
                listBox1.Items.Add($"[→] Sent: {dataToSend}");
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("Input kosong. Masukkan teks untuk dikirim.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dataToSend = $"<12>"; // 12

            if (!string.IsNullOrWhiteSpace(dataToSend))
            {
                serialPort1.WriteLine(dataToSend);
                listBox1.Items.Add($"[→] Sent: {dataToSend}");
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("Input kosong. Masukkan teks untuk dikirim.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_send_telegram_Click(object sender, EventArgs e)
        {
            string dataToSend = $"<13>"; // 13

            if (!string.IsNullOrWhiteSpace(dataToSend))
            {
                serialPort1.WriteLine(dataToSend);
                listBox1.Items.Add($"[→] Sent: {dataToSend}");
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("Input kosong. Masukkan teks untuk dikirim.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void enable_component(bool enable = false)
        {
            tb_wifi_name.Enabled = enable;
            tb_wifi_password.Enabled = enable;
            btn_get_wifi.Enabled = enable;
            btn_save_wifi.Enabled = enable;

            tb_daily_limit.Enabled = enable;
            tb_kwh_minimum.Enabled = enable;
            tb_pulse_kwh.Enabled = enable;
            btn_save_kwh_setting.Enabled = enable;
            btn_get_kwh_setting.Enabled = enable;

            tb_token_telegram.Enabled = enable;
            tb_recipient_userid.Enabled = enable;
            btn_get_telegram.Enabled = enable;
            btn_save_telegram.Enabled = enable;

            btn_relay_on.Enabled = enable;
            btn_send_telegram.Enabled = enable;
            btn_off_relay.Enabled = enable;
            btn_reset_0.Enabled = enable;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string dataToSend = $"<14>"; // 13

            if (!string.IsNullOrWhiteSpace(dataToSend))
            {
                serialPort1.WriteLine(dataToSend);
                listBox1.Items.Add($"[→] Sent: {dataToSend}");
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
            else
            {
                MessageBox.Show("Input kosong. Masukkan teks untuk dikirim.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_reset_0_Click(object sender, EventArgs e)
        {
            string dataToSend = $"<20>"; // 13

            DialogResult result = MessageBox.Show(
                "Apakah Anda yakin ingin mengirim perintah reset?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                if (!string.IsNullOrWhiteSpace(dataToSend))
                {
                    serialPort1.WriteLine(dataToSend);
                    listBox1.Items.Add($"[→] Sent: {dataToSend}");
                    listBox1.TopIndex = listBox1.Items.Count - 1;

                    // ✅ Tambahkan delay di sini (2 detik)
                    Thread.Sleep(500);

                    // Lanjutkan kirim data setelah delay
                    dataToSend = $"<2>";

                    if (!string.IsNullOrWhiteSpace(dataToSend))
                    {
                        serialPort1.WriteLine(dataToSend);
                        listBox1.Items.Add($"[→] Sent: {dataToSend}");
                        listBox1.TopIndex = listBox1.Items.Count - 1;
                    }
                    else
                    {
                        MessageBox.Show("Input kosong. Masukkan teks untuk dikirim.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Input kosong. Masukkan teks untuk dikirim.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                listBox1.Items.Add("[!] Reset dibatalkan oleh pengguna.");
                listBox1.TopIndex = listBox1.Items.Count - 1;
            }
        }

        private void btn_topup_Click(object sender, EventArgs e)
        {
            string dataToSend = $"<4,{tb_pulse_kwh.Text}>";

            if (!string.IsNullOrWhiteSpace(dataToSend))
            {
                serialPort1.WriteLine(dataToSend);
                listBox1.Items.Add($"[→] Sent: {dataToSend}");
                listBox1.TopIndex = listBox1.Items.Count - 1;

                // ✅ Tambahkan delay di sini (2 detik)
                Thread.Sleep(500);

                // Lanjutkan kirim data setelah delay
                dataToSend = $"<2>";

                if (!string.IsNullOrWhiteSpace(dataToSend))
                {
                    serialPort1.WriteLine(dataToSend);
                    listBox1.Items.Add($"[→] Sent: {dataToSend}");
                    listBox1.TopIndex = listBox1.Items.Count - 1;
                }
                else
                {
                    MessageBox.Show("Input kosong. Masukkan teks untuk dikirim.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Input kosong. Masukkan teks untuk dikirim.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}

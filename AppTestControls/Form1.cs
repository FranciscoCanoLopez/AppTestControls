namespace AppTestControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Text = "True";
                textBox1.BackColor = Color.PaleGreen;
            }
            else
            {
                textBox1.Text = "False";
                textBox1.BackColor = Color.LightCoral;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string option = comboBox1.SelectedItem!.ToString()!;
            switch (option)
            {
                case "Long":
                    dateTimePicker1.Format = DateTimePickerFormat.Long;
                    break;
                case "Short":
                    dateTimePicker1.Format = DateTimePickerFormat.Short;
                    break;
                case "Time":
                    dateTimePicker1.Format = DateTimePickerFormat.Time;
                    break;
                default:
                    dateTimePicker1.Format = DateTimePickerFormat.Short;
                    break;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string? url = e.Link!.LinkData as string;
            if (url != null)
            {
                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo abrir el enlace: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Thread thread = new Thread(new ThreadStart(PerformTask));
            thread.Start();
        }
        private void PerformTask()
        {
            for (int i = 0; i <= 100; i++)
            {
                Thread.Sleep(100);
                UpdateProgress(i);
            }

            this.BeginInvoke(new Action(() =>
            {
                button1.Enabled = true;
            }));

            MessageBox.Show("Complete");
            
        }
        private void UpdateProgress(int value)
        {
            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke(new Action<int>(UpdateProgress), value);
            }
            else
            {
                progressBar1.Value = value;
            }
        }
    }
}

using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Dairy_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);

            timer1.Start();
            date_show.Text = DateTime.Now.ToLongDateString();
            date_show_an_milkimenu.Text = DateTime.Now.ToLongDateString();
            DateTime d = DateTime.Now;
            day_show.Text = d.DayOfWeek.ToString();
            day_show_an_milkmenu.Text = d.DayOfWeek.ToString();
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Time_show.Text = DateTime.Now.ToLongTimeString();
            time_show_an_milkimenu.Text = DateTime.Now.ToLongTimeString();
            findEveningMorning();
            timer1.Start();
        }

        private void findEveningMorning()
        {
            DateTime currentTime = DateTime.Now;
            TimeSpan timeOfDay = currentTime.TimeOfDay;

            TimeSpan eveningStart = new TimeSpan(18, 0, 0);
            TimeSpan morningStart = new TimeSpan(6, 0, 0);

            if (!isEvening(timeOfDay, eveningStart, morningStart))
            {
                TimeOfDay.Text = "Morning";
            }
            else
            {

                TimeOfDay.Text = "Evening";
            }
        }
        static bool isEvening(TimeSpan time, TimeSpan est, TimeSpan mend)
        {
            if (time >= est || time < mend)
                return true;

            return false;
        }
        private void actionOflogin()
        {

            panel3.Visible = true;
            pictureBox1.Visible = false;
            groupBox1.Visible = false;
            label2.Visible = false;

            account_menu.Enabled = true;
            setting_menu.Enabled = true;
            user_menu.Enabled = true;
            report_menu.Enabled = true;
            milk_menu.Enabled = true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string user_value = textBox1.ToString();
            string pass_value = textBox2.ToString();

            if (user_value.Equals(pass_value))
            {
                //  MessageBox.Show("Login Succesful");
                label5.Text = "Welcome " + (textBox1.Text).ToUpperInvariant() + " Sir";
                actionOflogin();
            }
            else
            {
                MessageBox.Show("Login Unsuccesful");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            tabControl1.TabPages[0].BackColor = Color.DarkGray;
            tabPage1.BackColor = Color.DarkGray;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void account_menu_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void nEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel7.Visible = false;
           
            tabControl1.SelectedTab = tabPage1;

        }
        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
          
            panel7.Visible = false;
            tabControl1.SelectedTab = tabPage3;
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
           
            panel7.Visible = false;
            tabControl1.SelectedTab = tabPage2;
        }

        private void rEPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel7.Visible = false;

            tabControl1.SelectedTab = tabPage4;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {


            tabControl1.SelectedTab = tabPage1;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {


            tabControl1.SelectedTab = tabPage2;


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedTab = tabPage3;


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {


            tabControl1.SelectedTab = tabPage4;
        }


        // Setting --> fat Price --> picture boxes, only pic7 and pic8
        private void pictureBox7_Click(object sender, EventArgs e)
        {

            tabControl2.SelectedTab = tabPage5;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {


            tabControl2.SelectedTab = tabPage6;
        }

        private void fATPRICEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            panel3.Visible = false;
            panel2.Visible = false;
            panel5.Visible = false;
            
            panel7.Visible = false;
        }

        private void sALARYToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bUYMILKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel5.Visible = true;
            panel7.Visible = false;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eDITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel5.Visible = false;
            panel7.Visible = true;
        }
    }
}

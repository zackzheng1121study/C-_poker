namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int point;
        int point_pc;
        Random random = new Random();



        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            point_pc = random.Next(13);
            pictureBox1.Image = imageList1.Images[point_pc];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            timer1.Interval = 10;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (point > point_pc)
            {
                label3.Text = "恭喜獲勝!";
            }
            else if (point < point_pc)
            {
                label3.Text = "你輸了QAQ";
            }
            else
            {
                label3.Text = "平手!";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            point = random.Next(13);
            pictureBox2.Image = imageList1.Images[point];

        }
    }
}
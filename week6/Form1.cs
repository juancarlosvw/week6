namespace week6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int jalan = 0;
        string text = "";
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtbox_setguess.Text);
            if(a > 1)
            {
                Form2 newform2 = new Form2(a);
                newform2.ShowDialog();
            }
            else
            {
                MessageBox.Show("INPUT LEBIH DARI 1");
            }
        }
    }
}
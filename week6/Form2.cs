using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace week6
{
    public partial class Form2 : Form
    {
        int jalan = 0;
        int baris = 0;
        int menang = 0;
        string nebak = "";
        string answer = "";
        string key = "";
        string[] hijausudah = { "", "", "", "", "" };
        int x1 =0;
        int y1 = 0;
        string jawabanakhir = "";
        public Form2(int jalan)
        {

            InitializeComponent();
            this.jalan = jalan;
            foreach(Button button in this.Controls.OfType<Button>())
            {
                string tomboltag = button.Tag.ToString();
                if (tomboltag == "keyboardd")
                {
                    button.Click += nambahkeyboard;
                }
            }
            string[] jawabanawal = File.ReadAllText("Wordle Word List.txt").Split(',');
            Random rndom = new Random();
            jawabanakhir = jawabanawal[rndom.Next(0, jawabanawal.Length)].ToUpper();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for(int i =0; i < 5; i++)
            {
                for(int x =0; x < jalan; x++)//baris
                {
                    Button newbutton = new Button();
                    newbutton.Enabled = true;
                    newbutton.Size = new Size(40, 40);
                    newbutton.Location = new Point(30 + (40 * i), 50 + (40 * x));
                    newbutton.Tag = x.ToString() + "," + i.ToString();
                    this.Controls.Add(newbutton);
                }
            }
        }

        private void nambahkeyboard(object sender, EventArgs e)
        {
            Button newbutton =  sender as Button;
            key = newbutton.Text;
            string[] katakata = File.ReadAllText("Wordle Word List.txt").Split(',');
            Random rndom = new Random();
            //kata = jawabanawal[rndom.Next(0, jawabanawal.Length)].ToUpper();
            bool iyotukata = false;
            foreach (string kata in katakata)
            {
                if (nebak.ToUpper() == kata.ToUpper())
                {
                    iyotukata = true;
                    break;
                }
            }
            
                if (nebak.Length != 5 && key != "ENTER" && key != "DELETE")
                {
                    nebak = nebak + key;
                    updatekeyboard(nebak);
                }
                if (nebak.Length != 0 && key == "DELETE")
                {
                    nebak = nebak.Substring(0, nebak.Length - 1);
                    updatekeyboard(nebak);
                }
                if (key == "ENTER" && iyotukata == true)
                {
                    cekhijau();
                    cekkuning();
                    cekmenang();
                }
                if (key == "ENTER" && iyotukata == false)
                {
                    MessageBox.Show("guduk kata ;v");
                }
            
            
        }

        private void updatekeyboard(string keyboard1)
        {
            for(int y= 0; y < 5;y++)
            {
                foreach (Button button2 in this.Controls.OfType<Button>())
                {
                    string indexkeyboard = button2.Tag.ToString();
                    if(indexkeyboard == baris.ToString()+"," +y.ToString()&&y<keyboard1.Length)
                    {
                        button2.Text = nebak[y].ToString();
                    }
                    else if(indexkeyboard == baris.ToString() + "," + y.ToString())
                    {
                        button2.Text = "";
                    }
                }
            }
           
        }

       private void cekhijau()
       {
            menang = 0;
            for(int i = 0; i < 5; i++)
            {
                foreach(Button button2 in this.Controls.OfType<Button>())
                {
                    string indexkeyboard = button2.Tag.ToString();
                    if (indexkeyboard == baris.ToString() + "," + i.ToString())
                    {
                        if (nebak[i] == jawabanakhir[i])
                        {
                            button2.BackColor = Color.Green;
                            hijausudah[i] = "SUDAHHHH";
                            menang++;
                        }
                        else
                        {
                            hijausudah[i] = "";
                        }
                        
                    }
                }
            }
       }

        private void cekkuning()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int y = 0; y < 5; y++)
                {
                    foreach (Button button2 in this.Controls.OfType<Button>())
                    {
                        string indexkeyboard = button2.Tag.ToString();
                        if (indexkeyboard == baris.ToString() + "," + i.ToString())
                        {
                            if (hijausudah[y] == "" && button2.BackColor != Color.Green && jawabanakhir[y] == nebak[i])
                            {
                                button2.BackColor = Color.Yellow;
                            }
                        }
                    }
                }
            }
            
        }
        private void cekmenang()
        {
            nebak = "";
            baris++;
            if (menang == 5)
            {
                MessageBox.Show("Menang");
            }
            else if (baris >= jalan && menang == 5)
            {
                MessageBox.Show("Menang");
            }
            else if (baris >= jalan)
            {
                MessageBox.Show("kalah, "+answer.ToUpper());
            }
        }
    }
}

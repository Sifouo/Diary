using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Diarys
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        public int length;
        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
                this.Dispose();
            
                
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                try
                {
                    string a = (string)listBox1.SelectedItem;
                    string temp = File.ReadAllText($"E:\\{a}.txt");
                    File.Delete($"E:\\{a}.txt");
                    listBox1.Items.Remove(a);

                    f2.re(a);
                    f2.Show();
                }
                catch (IOException )
                {
                    MessageBox.Show("That Diary doesnt exist anymore", "Invalid Option");
                }
            }

            else if (radioButton2.Checked)
            {
                string a = (string)listBox1.SelectedItem;
                f2.re(a);

                File.Delete($"E:\\{listBox1.SelectedItem}.txt");
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
            else if (radioButton3.Checked)
            {
                string a = (string)listBox1.SelectedItem;

                try
                {
                    f3.getD(a);
                    f3.Show();
                }
                catch (IOException )
                {
                    MessageBox.Show("That Diary doesnt exist anymore", "Invalid Option");
                }


            }
            else if (radioButton4.Checked)
            {
                f2.Show();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int i;
            for (i = 0; i < f2.getl(); i++)
                listBox1.Items.Add(f2.getInf(i));
        }
    }
}

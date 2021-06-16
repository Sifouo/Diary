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
    public partial class Form2 : Form
    {
        public string removeable;
        public void re(string a)
        {
            this.removeable = a;
            list1.Remove(this.removeable);
        }
        List<string> list1 = new List<string>();
        Diary d = new Diary();
        public Form2()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            d.name = textBox2.Text;
            d.diar = textBox1.Text;

            string name = textBox2.Text;

            File.AppendAllText($"E:\\{name}.txt", d.diar);
            list1.Add(name);
        }
        public string getInf(int inx)
        {
            var list = list1.ToArray();
            return list[inx];
        }
        public int getl()
        {
            var list = list1.ToArray();
            int length = list.Length;
            return length;
        }
    }
}

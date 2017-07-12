using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BazaDSoftBlue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kondensatoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            kondensatory f2 = new kondensatory();           
            f2.ShowDialog();

        }

        private void IndukcyjneButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Indukcyjne f3 = new Indukcyjne();
            f3.ShowDialog();
        }

        private void TranzIDioidyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            tranzystory f4 = new tranzystory();
            f4.ShowDialog();
        }

        private void UklScalButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            uklady f5 = new uklady();
            f5.ShowDialog();
        }

        private void ZlaczaButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            zlacza f6 = new zlacza();
            f6.ShowDialog();
        }

        private void ElMechButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            elementy f7= new elementy();
            f7.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            rezystory f8 = new rezystory();
            f8.ShowDialog();
        }
    }
}

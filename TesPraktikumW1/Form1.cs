using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace TesPraktikumW1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private ArrayList arrlistItem = new ArrayList();

        private void changeMode()
        {
            Buah.Enabled=TambahBuahBtn.Checked;
            TambahBuahGroup.Enabled=TambahBuahBtn.Checked;
            GroupTransaksi.Enabled=TransaksiBtn.Checked;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TambahBuahBtn_CheckedChanged(object sender, EventArgs e)
        {
            changeMode();
        }

        private void TransaksiBtn_CheckedChanged(object sender, EventArgs e)
        {
            changeMode();
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void TambahBuahBtn_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void GroupTransaksi_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TambahBtn_Click(object sender, EventArgs e)
        {
            string name = NamaBuah.Text;
            string category = InputKategori.Text;
            int harga = Convert.ToInt32(InputHarga.Text);

            if (name!=""&&category!=""&&harga>0)
            {
                Item newItem = new Item(name, category, harga);
                Buah.Items.Add(newItem.ToString());
                arrlistItem.Add(newItem);
                BuahComboBox.Items.Clear();
                for(int i =0; i < arrlistItem.Count; i++)
                {
                    string product = arrlistItem[i].ToString();
                    BuahComboBox.Items.Add(product);
                }
            }
        }
    }
}

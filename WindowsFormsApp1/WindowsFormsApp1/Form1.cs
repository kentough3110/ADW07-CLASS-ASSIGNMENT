using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        Form2 form2 = new Form2();
        private void btnStart_Click(object sender, EventArgs e)
        {
            int jumlahCells = Convert.ToInt32(txtboxJumlahCells.Text);
            if (jumlahCells < 5)
            {
                MessageBox.Show("Jumlah Cells tidak boleh kurang dari 5!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Form2.size = jumlahCells;
                form2.Show();
            }
        }
    }
}

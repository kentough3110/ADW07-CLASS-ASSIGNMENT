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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static int size = 0;
        List<Button> listButton = new List<Button>();
        int a = 0; 
        int b = 0; 
        int angka = 0; 
        int calcRed = 0; 
        int calcBlue = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            boardMaker();
        }
        public void boardMaker()
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    Button button = new Button();
                    button.Tag = "button" + angka;
                    button.BackColor = Color.White;
                    button.Size = new Size(60, 60);
                    button.Location = new Point(12 + a, 12 + b);
                    b += 60;
                    angka++;
                    listButton.Add(button);
                }
                b = 0;
                a += 60;
            }
            foreach (Button button in listButton)
            {
                this.Controls.Add(button);
                button.Click += button_Click;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button x = sender as Button;
            for (int i = 0; i < listButton.Count; i++)
            {
                if (listButton[i].Tag == x.Tag)
                {
                    if (listButton[i].BackColor == Color.White)
                    {
                        listButton[i].BackColor = Color.Red;
                    }
                    else if (listButton[i].BackColor == Color.Red)
                    {
                        listButton[i].BackColor = Color.Blue;
                    }
                    else if (listButton[i].BackColor == Color.Blue)
                    {
                        listButton[i].BackColor = Color.Red;
                    }

                    if (i < size == false)
                    {
                        if (listButton[i - size].BackColor == Color.White)
                        {

                        }
                        else if (listButton[i - size].BackColor == Color.Red)
                        {
                            listButton[i - size].BackColor = Color.Blue;
                        }
                        else if (listButton[i - size].BackColor == Color.Blue)
                        {
                            listButton[i - size].BackColor = Color.Red;
                        }
                    }

                    if (i >= ((size * size) - size) == false)
                    {
                        if (listButton[i + size].BackColor == Color.White)
                        {

                        }
                        else if (listButton[i + size].BackColor == Color.Red)
                        {
                            listButton[i + size].BackColor = Color.Blue;
                        }
                        else if (listButton[i + size].BackColor == Color.Blue)
                        {
                            listButton[i + size].BackColor = Color.Red;
                        }
                    }

                    if (i % size == 0 == false)
                    {
                        if (listButton[i - 1].BackColor == Color.White)
                        {

                        }
                        else if (listButton[i - 1].BackColor == Color.Red)
                        {
                            listButton[i - 1].BackColor = Color.Blue;
                        }
                        else if (listButton[i - 1].BackColor == Color.Blue)
                        {
                            listButton[i - 1].BackColor = Color.Red;
                        }

                    }

                    if (i % size == (size - 1) == false)
                    {
                        if (listButton[i + 1].BackColor == Color.White)
                        {

                        }
                        else if (listButton[i + 1].BackColor == Color.Red)
                        {
                            listButton[i + 1].BackColor = Color.Blue;
                        }
                        else if (listButton[i + 1].BackColor == Color.Blue)
                        {
                            listButton[i + 1].BackColor = Color.Red;
                        }
                    }
                }
            }
            calcBlue = 0;
            calcRed = 0;
            foreach (Button print in listButton)
            {
                if (print.BackColor == Color.Red)
                {
                    calcRed++;
                    labelRed.Text = calcRed.ToString();
                }
                else if (print.BackColor == Color.Blue)
                {
                    calcBlue++;
                    labelBlue.Text = calcBlue.ToString();
                }
            }
            if (calcBlue == (size * size))
            {
                MessageBox.Show("Blue Win");
            }
            if (calcRed == (size * size))
            {
                MessageBox.Show("Red Win");
            }
        }
    }
}
    

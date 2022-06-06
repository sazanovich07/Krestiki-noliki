using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Крестики_нолики
{

    public partial class Form1 : Form
    {
        int pc = 0;int flag = 0;int[] arr = { 2, 2, 2, 2, 2, 2, 2, 2, 2 };



        bool Check_x()
        {
            if (arr[0] == 1 && arr[1] == 1 && arr[2] == 1) { return true; }
            else if (arr[3] == 1 && arr[4] == 1 && arr[5] == 1) { return true; }
            else if (arr[6] == 1 && arr[7] == 1 && arr[8] == 1) { return true; }
            else if (arr[0] == 1 && arr[3] == 1 && arr[6] == 1) { return true; }
            else if (arr[1] == 1 && arr[4] == 1 && arr[7] == 1) { return true; }
            else if (arr[2] == 1 && arr[5] == 1 && arr[8] == 1) { return true; }
            else if (arr[0] == 1 && arr[4] == 1 && arr[8] == 1) { return true; }
            else if (arr[2] == 1 && arr[4] == 1 && arr[6] == 1) { return true; }
            else if (pictureBox1.Enabled == false && pictureBox2.Enabled == false
            && pictureBox3.Enabled == false && pictureBox4.Enabled == false
            && pictureBox5.Enabled == false && pictureBox6.Enabled == false
            && pictureBox7.Enabled == false && pictureBox8.Enabled == false
            && pictureBox9.Enabled == false)
            { MessageBox.Show("Ничья"); pobeda(); }
            return false;
        }
        bool Check_o()
        {
            if (arr[0] == 0 && arr[1] == 0 && arr[2] == 0) { return true; }
            else if (arr[3] == 0 && arr[4] == 0 && arr[5] == 0) { return true; }
            else if (arr[6] == 0 && arr[7] == 0 && arr[8] == 0) { return true; }
            else if (arr[0] == 0 && arr[3] == 0 && arr[6] == 0) { return true; }
            else if (arr[1] == 0 && arr[4] == 0 && arr[7] == 0) { return true; }
            else if (arr[2] == 0 && arr[5] == 0 && arr[8] == 0) { return true; }
            else if (arr[0] == 0 && arr[4] == 0 && arr[8] == 0) { return true; }
            else if (arr[2] == 0 && arr[4] == 0 && arr[6] == 0) { return true; }
            return false;
        }
        void Clicked(PictureBox btn)
        {   
            btn.Enabled = false;
            if (Check_x()) {MessageBox.Show("Выйграли крестики"); pobeda();}
            else if (Check_o()) {MessageBox.Show("Выйграли нолики"); pobeda();}
            if (flag == 1) flag = 0;
            else if (flag == 0) flag = 1;
        }
        void pobeda()
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox2.Image = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            pictureBox3.Image = new Bitmap(pictureBox3.Width, pictureBox3.Height);
            pictureBox4.Image = new Bitmap(pictureBox4.Width, pictureBox4.Height);
            pictureBox5.Image = new Bitmap(pictureBox5.Width, pictureBox5.Height);
            pictureBox6.Image = new Bitmap(pictureBox6.Width, pictureBox6.Height);
            pictureBox7.Image = new Bitmap(pictureBox7.Width, pictureBox7.Height);
            pictureBox8.Image = new Bitmap(pictureBox8.Width, pictureBox8.Height);
            pictureBox9.Image = new Bitmap(pictureBox9.Width, pictureBox9.Height);
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox2.BackColor = Color.WhiteSmoke;
            pictureBox3.BackColor = Color.WhiteSmoke;
            pictureBox4.BackColor = Color.WhiteSmoke;
            pictureBox5.BackColor = Color.WhiteSmoke;
            pictureBox6.BackColor = Color.WhiteSmoke;
            pictureBox7.BackColor = Color.WhiteSmoke;
            pictureBox8.BackColor = Color.WhiteSmoke;
            pictureBox9.BackColor = Color.WhiteSmoke;
            flag = 1; arr[0] = 2; arr[1] = 2; arr[2] = 2; arr[3] = 2; arr[4] = 2; arr[5] = 2; arr[6] = 2; arr[7] = 2; arr[8] = 2; pc = 0;
            pictureBox1.Enabled = true; pictureBox2.Enabled = true; pictureBox3.Enabled = true;
            pictureBox4.Enabled = true; pictureBox5.Enabled = true; pictureBox6.Enabled = true;
            pictureBox7.Enabled = true; pictureBox8.Enabled = true; pictureBox9.Enabled = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(Pens.Red, 10, 10, 70, 70);
            e.Graphics.DrawRectangle(Pens.Red, 10, 90, 70, 70);
            e.Graphics.DrawRectangle(Pens.Red, 10, 170, 70, 70);
            e.Graphics.DrawRectangle(Pens.Red, 90, 10, 70, 70);
            e.Graphics.DrawRectangle(Pens.Red, 90, 90, 70, 70);
            e.Graphics.DrawRectangle(Pens.Red, 90, 170, 70, 70);
            e.Graphics.DrawRectangle(Pens.Red, 170, 10, 70, 70);
            e.Graphics.DrawRectangle(Pens.Red, 170, 90, 70, 70);
            e.Graphics.DrawRectangle(Pens.Red, 170, 170, 70, 70);
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {                    
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            if (flag == 0)       
                using (var g = Graphics.FromImage(pictureBox1.Image))
                {
                    Pen p = Pens.Blue;
                    Point tlhc = new Point(0, 0);
                    Point brhc = new Point(pictureBox1.Image.Width, pictureBox1.Image.Height);
                    g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                    g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                    arr[0] = 1;               
                }
            else if(flag == 1)
            using (var g = Graphics.FromImage(pictureBox1.Image))
            {
                Pen p = Pens.Blue;
                g.DrawEllipse(p, 0, 0, 68, 68);
                arr[0] = 0;
            }
            pc += 2;Clicked(pictureBox1);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {            
            pictureBox2.Image = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            if (flag == 0)             
            using (var g = Graphics.FromImage(pictureBox2.Image))
            {
                Pen p = Pens.Blue;
                Point tlhc = new Point(0, 0);
                Point brhc = new Point(pictureBox2.Image.Width, pictureBox2.Image.Height);
                g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                arr[1] = 1;
                }
            else if (flag == 1)
                using (var g = Graphics.FromImage(pictureBox2.Image))
                {
                    Pen p = Pens.Blue;
                    g.DrawEllipse(p, 0, 0, 68, 68);
                    arr[1] = 0;
                }
            pc += 2; Clicked(pictureBox2);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {          
            pictureBox3.Image = new Bitmap(pictureBox3.Width, pictureBox3.Height);
            if (flag == 0)
            using (var g = Graphics.FromImage(pictureBox3.Image))
            {
                Pen p = Pens.Blue;
                Point tlhc = new Point(0, 0);
                Point brhc = new Point(pictureBox3.Image.Width, pictureBox3.Image.Height);
                g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                arr[2] = 1;
            }
            else if (flag == 1)
            using (var g = Graphics.FromImage(pictureBox3.Image))
            {
                Pen p = Pens.Blue;
                g.DrawEllipse(p, 0, 0, 68, 68);
                arr[2] = 0;
            }
            pc += 2; Clicked(pictureBox3);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {         
            pictureBox4.Image = new Bitmap(pictureBox4.Width, pictureBox4.Height);
            if (flag == 0)
            using (var g = Graphics.FromImage(pictureBox4.Image))
            {
                Pen p = Pens.Blue;
                Point tlhc = new Point(0, 0);
                Point brhc = new Point(pictureBox4.Image.Width, pictureBox4.Image.Height);
                g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                arr[3] = 1;
            }
            else if (flag == 1)
            using (var g = Graphics.FromImage(pictureBox4.Image))
            {
                Pen p = Pens.Blue;
                g.DrawEllipse(p, 0, 0, 68, 68);
                arr[3] = 0;
            }
            pc += 2; Clicked(pictureBox4);
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {           
            pictureBox5.Image = new Bitmap(pictureBox5.Width, pictureBox5.Height);
            if (flag == 0)
            using (var g = Graphics.FromImage(pictureBox5.Image))
            {
                Pen p = Pens.Blue;
                Point tlhc = new Point(0, 0);
                Point brhc = new Point(pictureBox5.Image.Width, pictureBox5.Image.Height);
                g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                arr[4] = 1;
            }
            else if (flag == 1)
            using (var g = Graphics.FromImage(pictureBox5.Image))
            {
                Pen p = Pens.Blue;
                g.DrawEllipse(p, 0, 0, 68, 68);
                arr[4] = 0;
            }
            pc += 2; Clicked(pictureBox5);
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {         
            pictureBox6.Image = new Bitmap(pictureBox6.Width, pictureBox6.Height);
            if (flag == 0)
                using (var g = Graphics.FromImage(pictureBox6.Image))
            {
                Pen p = Pens.Blue;
                Point tlhc = new Point(0, 0);
                Point brhc = new Point(pictureBox6.Image.Width, pictureBox6.Image.Height);
                g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                    arr[5] = 1;
                }
            else if (flag == 1)
                using (var g = Graphics.FromImage(pictureBox6.Image))
                {
                    Pen p = Pens.Blue;
                    g.DrawEllipse(p, 0, 0, 68, 68);
                    arr[5] = 0;
                }
            pc += 2;
            Clicked(pictureBox6);
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
             
            pictureBox7.Image = new Bitmap(pictureBox7.Width, pictureBox7.Height);
            if (flag == 0)
                using (var g = Graphics.FromImage(pictureBox7.Image))
            {
                Pen p = Pens.Blue;
                Point tlhc = new Point(0, 0);
                Point brhc = new Point(pictureBox7.Image.Width, pictureBox7.Image.Height);
                g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                    arr[6] = 1;
                }
            else if (flag == 1)
                using (var g = Graphics.FromImage(pictureBox7.Image))
                {
                    Pen p = Pens.Blue;
                    g.DrawEllipse(p, 0, 0, 68, 68);
                    arr[6] = 0;
                }
            pc += 2;
            Clicked(pictureBox7);
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
             
            pictureBox8.Image = new Bitmap(pictureBox8.Width, pictureBox8.Height);
            if (flag == 0)
                using (var g = Graphics.FromImage(pictureBox8.Image))
            {
                Pen p = Pens.Blue;
                Point tlhc = new Point(0, 0);
                Point brhc = new Point(pictureBox8.Image.Width, pictureBox8.Image.Height);
                g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                    arr[7] = 1;
                }
            else if (flag == 1)
                using (var g = Graphics.FromImage(pictureBox8.Image))
                {
                    Pen p = Pens.Blue;
                    g.DrawEllipse(p, 0, 0, 68, 68);
                    arr[7] = 0;
                }
            pc += 2;
            Clicked(pictureBox8);
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
             
            pictureBox9.Image = new Bitmap(pictureBox9.Width, pictureBox9.Height);
            if (flag == 0)
                using (var g = Graphics.FromImage(pictureBox9.Image))
            {
                Pen p = Pens.Blue;
                Point tlhc = new Point(0, 0);
                Point brhc = new Point(pictureBox9.Image.Width, pictureBox9.Image.Height);
                g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                    arr[8] = 1;
                }
            else if (flag == 1)
                using (var g = Graphics.FromImage(pictureBox9.Image))
                {
                    Pen p = Pens.Blue;
                    g.DrawEllipse(p, 0, 0, 68, 68);
                    arr[8] = 0;
                }
            pc += 2;Clicked(pictureBox9);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && pc == 0)
            {
                pictureBox5.Image = new Bitmap(pictureBox5.Width, pictureBox5.Height);
                using (var g = Graphics.FromImage(pictureBox5.Image))
                {
                    Pen p = Pens.Blue;
                    Point tlhc = new Point(0, 0);
                    Point brhc = new Point(pictureBox5.Image.Width, pictureBox5.Image.Height);
                    g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                    g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                    arr[4] = 1;
                }
                flag = 1; pictureBox5.Enabled = false;pc += 1;
            }

            if (radioButton1.Checked && pc == 3 && pictureBox9.Enabled == true)
            {
                pictureBox9.Image = new Bitmap(pictureBox9.Width, pictureBox9.Height);
                using (var g = Graphics.FromImage(pictureBox9.Image))
                {
                    Pen p = Pens.Blue;
                    Point tlhc = new Point(0, 0);
                    Point brhc = new Point(pictureBox9.Image.Width, pictureBox9.Image.Height);
                    g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                    g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                    arr[8] = 1;
                }
                flag = 1; pictureBox9.Enabled = false; pc += 1;
            }
            else if (radioButton1.Checked && pc == 3 && pictureBox1.Enabled == true)
            {
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                using (var g = Graphics.FromImage(pictureBox1.Image))
                {
                    Pen p = Pens.Blue;
                    Point tlhc = new Point(0, 0);
                    Point brhc = new Point(pictureBox1.Image.Width, pictureBox1.Image.Height);
                    g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                    g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                    arr[0] = 1;
                }
                flag = 1; pictureBox1.Enabled = false; pc += 1;
            }

            if (radioButton1.Checked && pc == 6 && pictureBox1.Enabled == true)
            {
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                using (var g = Graphics.FromImage(pictureBox1.Image))
                {
                    Pen p = Pens.Blue;
                    Point tlhc = new Point(0, 0);
                    Point brhc = new Point(pictureBox1.Image.Width, pictureBox1.Image.Height);
                    g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                    g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                    arr[0] = 1;
                }
                flag = 1; pc += 1; pictureBox1.Enabled = false;
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); }
            }
            else if (radioButton1.Checked && pc == 6 && pictureBox2.Enabled == true)
            {
                pictureBox2.Image = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                using (var g = Graphics.FromImage(pictureBox2.Image))
                {
                    Pen p = Pens.Blue;
                    Point tlhc = new Point(0, 0);
                    Point brhc = new Point(pictureBox2.Image.Width, pictureBox2.Image.Height);
                    g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                    g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                    arr[1] = 1;
                }
                flag = 1; pictureBox2.Enabled = false; pc += 1;
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); }
            }
            else if (radioButton1.Checked && pc == 6 && pictureBox3.Enabled == true)
            {
                pictureBox3.Image = new Bitmap(pictureBox3.Width, pictureBox3.Height);
                using (var g = Graphics.FromImage(pictureBox3.Image))
                {
                    Pen p = Pens.Blue;
                    Point tlhc = new Point(0, 0);
                    Point brhc = new Point(pictureBox3.Image.Width, pictureBox3.Image.Height);
                    g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                    g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                    arr[2] = 1;
                }
                flag = 1; pictureBox3.Enabled = false; pc += 1;
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); }
            }

            if (radioButton1.Checked && pc == 9 && pictureBox8.Enabled == true)
            {
                pictureBox8.Image = new Bitmap(pictureBox8.Width, pictureBox8.Height);
                using (var g = Graphics.FromImage(pictureBox8.Image))
                {
                    Pen p = Pens.Blue;
                    Point tlhc = new Point(0, 0);
                    Point brhc = new Point(pictureBox8.Image.Width, pictureBox8.Image.Height);
                    g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                    g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                    arr[7] = 1;
                }
                flag = 1; pc += 1; pictureBox8.Enabled = false;
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); }
            }
            else if (radioButton1.Checked && pc == 9 && pictureBox2.Enabled == true)
            {
                pictureBox2.Image = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                using (var g = Graphics.FromImage(pictureBox2.Image))
                {
                    Pen p = Pens.Blue;
                    Point tlhc = new Point(0, 0);
                    Point brhc = new Point(pictureBox2.Image.Width, pictureBox2.Image.Height);
                    g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                    g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                    arr[1] = 1;
                }
                flag = 1; pictureBox2.Enabled = false; pc += 1;
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); }
            }
            else if (radioButton1.Checked && pc == 9 && pictureBox3.Enabled == true)
            {
                pictureBox3.Image = new Bitmap(pictureBox3.Width, pictureBox3.Height);
                using (var g = Graphics.FromImage(pictureBox3.Image))
                {
                    Pen p = Pens.Blue;
                    Point tlhc = new Point(0, 0);
                    Point brhc = new Point(pictureBox3.Image.Width, pictureBox3.Image.Height);
                    g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                    g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                    arr[2] = 1;
                }
                flag = 1; pictureBox3.Enabled = false; pc += 1;
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); }
            }
            else if (radioButton1.Checked && pc == 9 && pictureBox7.Enabled == true)
            {
                pictureBox7.Image = new Bitmap(pictureBox7.Width, pictureBox7.Height);
                using (var g = Graphics.FromImage(pictureBox7.Image))
                {
                    Pen p = Pens.Blue;
                    Point tlhc = new Point(0, 0);
                    Point brhc = new Point(pictureBox7.Image.Width, pictureBox7.Image.Height);
                    g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                    g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                    arr[6] = 1;
                }
                flag = 1; pictureBox7.Enabled = false; pc += 1;
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); }
            }

            if (radioButton1.Checked && pc == 12 && pictureBox2.Enabled == true)
            {
                pictureBox2.Image = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                using (var g = Graphics.FromImage(pictureBox2.Image))
                {
                    Pen p = Pens.Blue;
                    Point tlhc = new Point(0, 0);
                    Point brhc = new Point(pictureBox2.Image.Width, pictureBox2.Image.Height);
                    g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                    g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                    arr[1] = 1;
                }
                flag = 1; pc += 1; pictureBox2.Enabled = false;
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); flag = 0; }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); flag = 0; }
            }
            else if (radioButton1.Checked && pc == 12 && pictureBox4.Enabled == true)
            {
                pictureBox4.Image = new Bitmap(pictureBox4.Width, pictureBox4.Height);
                using (var g = Graphics.FromImage(pictureBox4.Image))
                {
                    Pen p = Pens.Blue;
                    Point tlhc = new Point(0, 0);
                    Point brhc = new Point(pictureBox4.Image.Width, pictureBox4.Image.Height);
                    g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                    g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                    arr[3] = 1;
                }
                flag = 1; pictureBox4.Enabled = false; pc += 1;
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); flag = 0; }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); flag = 0; }
            }
            else if (radioButton1.Checked && pc == 12 && pictureBox6.Enabled == true)
            {
                pictureBox6.Image = new Bitmap(pictureBox6.Width, pictureBox6.Height);
                using (var g = Graphics.FromImage(pictureBox6.Image))
                {
                    Pen p = Pens.Blue;
                    Point tlhc = new Point(0, 0);
                    Point brhc = new Point(pictureBox6.Image.Width, pictureBox6.Image.Height);
                    g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                    g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                    arr[5] = 1;
                }
                flag = 1; pictureBox6.Enabled = false; pc += 1;
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); flag = 0; }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); flag = 0; }
            }
            else if (radioButton1.Checked && pc == 12 && pictureBox7.Enabled == true)
            {
                pictureBox7.Image = new Bitmap(pictureBox7.Width, pictureBox7.Height);
                using (var g = Graphics.FromImage(pictureBox7.Image))
                {
                    Pen p = Pens.Blue;
                    Point tlhc = new Point(0, 0);
                    Point brhc = new Point(pictureBox7.Image.Width, pictureBox7.Image.Height);
                    g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                    g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                    arr[6] = 1;
                }
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); flag = 0; }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); flag = 0; }
            }
            else if (radioButton1.Checked && pc == 12 && pictureBox3.Enabled == true)
            {
                pictureBox3.Image = new Bitmap(pictureBox3.Width, pictureBox3.Height);
                using (var g = Graphics.FromImage(pictureBox3.Image))
                {
                    Pen p = Pens.Blue;
                    Point tlhc = new Point(0, 0);
                    Point brhc = new Point(pictureBox3.Image.Width, pictureBox3.Image.Height);
                    g.DrawLine(p, new Point(tlhc.X, tlhc.Y), new Point(brhc.X, brhc.Y));
                    g.DrawLine(p, new Point(tlhc.X, brhc.Y), new Point(brhc.X, tlhc.Y));
                    arr[2] = 1;
                }
                flag = 1; pictureBox3.Enabled = false; pc += 1;
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); flag = 0; }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); flag = 0; }
            }



            if (radioButton2.Checked && pc == 2 && pictureBox5.Enabled == true)
            {
                pictureBox5.Image = new Bitmap(pictureBox5.Width, pictureBox5.Height);
                using (var g = Graphics.FromImage(pictureBox5.Image))
                {
                    Pen p = Pens.Blue;
                    g.DrawEllipse(p, 0, 0, 68, 68);
                    arr[4] = 0;
                }
                flag = 0; pictureBox5.Enabled = false; pc += 1;
            }
            else if (radioButton2.Checked && pc == 2 && pictureBox1.Enabled == true)
            {
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                using (var g = Graphics.FromImage(pictureBox1.Image))
                {
                    Pen p = Pens.Blue;
                    g.DrawEllipse(p, 0, 0, 68, 68);
                    arr[0] = 0;
                }
                flag = 0; pictureBox1.Enabled = false; pc += 1;
            }

            if (radioButton2.Checked && pc == 5 && pictureBox1.Enabled == true)
            {
                pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                using (var g = Graphics.FromImage(pictureBox1.Image))
                {
                    Pen p = Pens.Blue;
                    g.DrawEllipse(p, 0, 0, 68, 68);
                    arr[0] = 0;
                }
                flag = 0; pictureBox1.Enabled = false; pc += 1;
            }
            else if (radioButton2.Checked && pc == 5 && pictureBox9.Enabled == true)
            {
                pictureBox9.Image = new Bitmap(pictureBox9.Width, pictureBox9.Height);
                using (var g = Graphics.FromImage(pictureBox9.Image))
                {
                    Pen p = Pens.Blue;
                    g.DrawEllipse(p, 0, 0, 68, 68);
                    arr[8] = 0;
                }
                flag = 0; pictureBox9.Enabled = false; pc += 1;
            }         
            else if (radioButton2.Checked && pc == 5 && pictureBox2.Enabled == true)
            {
                pictureBox2.Image = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                using (var g = Graphics.FromImage(pictureBox2.Image))
                {
                    Pen p = Pens.Blue;
                    g.DrawEllipse(p, 0, 0, 68, 68);
                    arr[1] = 0;
                }
                flag = 0; pictureBox2.Enabled = false; pc += 1;
            }
            else if (radioButton2.Checked && pc == 5 && pictureBox3.Enabled == true)
            {
                pictureBox3.Image = new Bitmap(pictureBox3.Width, pictureBox3.Height);
                using (var g = Graphics.FromImage(pictureBox3.Image))
                {
                    Pen p = Pens.Blue;
                    g.DrawEllipse(p, 0, 0, 68, 68);
                    arr[2] = 0;
                }
                flag = 0; pictureBox3.Enabled = false; pc += 1;
            }

            if (radioButton2.Checked && pc == 8 && pictureBox9.Enabled == true)
            {
                pictureBox9.Image = new Bitmap(pictureBox9.Width, pictureBox9.Height);
                using (var g = Graphics.FromImage(pictureBox9.Image))
                {
                    Pen p = Pens.Blue;
                    g.DrawEllipse(p, 0, 0, 68, 68);
                    arr[8] = 0;
                }
                flag = 0; pictureBox9.Enabled = false; pc += 1;
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); }
            }
            else if (radioButton2.Checked && pc == 8 && pictureBox2.Enabled == true)
            {
                pictureBox2.Image = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                using (var g = Graphics.FromImage(pictureBox2.Image))
                {
                    Pen p = Pens.Blue;
                    g.DrawEllipse(p, 0, 0, 68, 68);
                    arr[1] = 0;
                }
                flag = 0; pictureBox2.Enabled = false; pc += 1;
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); }
            }
            else if (radioButton2.Checked && pc == 8 && pictureBox3.Enabled == true)
            {
                pictureBox3.Image = new Bitmap(pictureBox3.Width, pictureBox3.Height);
                using (var g = Graphics.FromImage(pictureBox3.Image))
                {
                    Pen p = Pens.Blue;
                    g.DrawEllipse(p, 0, 0, 68, 68);
                    arr[2] = 0;
                }
                flag = 0; pictureBox3.Enabled = false; pc += 1;
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); }
            }
            else if (radioButton2.Checked && pc == 8 && pictureBox7.Enabled == true)
            {
                pictureBox7.Image = new Bitmap(pictureBox7.Width, pictureBox7.Height);
                using (var g = Graphics.FromImage(pictureBox7.Image))
                {
                    Pen p = Pens.Blue;
                    g.DrawEllipse(p, 0, 0, 68, 68);
                    arr[6] = 0;
                }
                flag = 0; pictureBox7.Enabled = false; pc += 1;
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); }
            }
            else if (radioButton2.Checked && pc == 8 && pictureBox8.Enabled == true)
            {
                pictureBox8.Image = new Bitmap(pictureBox8.Width, pictureBox8.Height);
                using (var g = Graphics.FromImage(pictureBox8.Image))
                {
                    Pen p = Pens.Blue;
                    g.DrawEllipse(p, 0, 0, 68, 68);
                    arr[7] = 0;
                }
                flag = 0; pc += 1; pictureBox8.Enabled = false;
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); }
            }
            else if (radioButton2.Checked && pc == 8 && pictureBox6.Enabled == true)
            {
                pictureBox6.Image = new Bitmap(pictureBox6.Width, pictureBox6.Height);
                using (var g = Graphics.FromImage(pictureBox6.Image))
                {
                    Pen p = Pens.Blue;
                    g.DrawEllipse(p, 0, 0, 68, 68);
                    arr[5] = 0;
                }
                flag = 0; pictureBox6.Enabled = false; pc += 1;
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); }
            }

            if (radioButton2.Checked && pc == 11 && pictureBox8.Enabled == true)
            {
                pictureBox8.Image = new Bitmap(pictureBox8.Width, pictureBox8.Height);
                using (var g = Graphics.FromImage(pictureBox8.Image))
                {
                    Pen p = Pens.Blue;
                    g.DrawEllipse(p, 0, 0, 68, 68);
                    arr[7] = 0;
                }
                flag = 0; pc += 1; pictureBox8.Enabled = false;
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); flag = 0; }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); flag = 0; }
            }
            else if (radioButton2.Checked && pc == 11 && pictureBox2.Enabled == true)
            {
                pictureBox2.Image = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                using (var g = Graphics.FromImage(pictureBox2.Image))
                {
                    Pen p = Pens.Blue;
                    g.DrawEllipse(p, 0, 0, 68, 68);
                    arr[1] = 0;
                }
                flag = 0; pictureBox2.Enabled = false; pc += 1;
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); flag = 0; }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); flag = 0; }
            }
            else if (radioButton2.Checked && pc == 11 && pictureBox3.Enabled == true)
            {
                pictureBox3.Image = new Bitmap(pictureBox3.Width, pictureBox3.Height);
                using (var g = Graphics.FromImage(pictureBox3.Image))
                {
                    Pen p = Pens.Blue;
                    g.DrawEllipse(p, 0, 0, 68, 68);
                    arr[2] = 0;
                }
                flag = 0; pictureBox3.Enabled = false; pc += 1;
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); flag = 0; }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); flag = 0; }
            }
            else if (radioButton2.Checked && pc == 11 && pictureBox7.Enabled == true)
            {
                pictureBox7.Image = new Bitmap(pictureBox7.Width, pictureBox7.Height);
                using (var g = Graphics.FromImage(pictureBox7.Image))
                {
                    Pen p = Pens.Blue;
                    g.DrawEllipse(p, 0, 0, 68, 68);
                    arr[6] = 0;
                }
                flag = 0; pictureBox7.Enabled = false; pc += 1;
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); flag = 0; }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); flag = 0; }
            }
            else if (radioButton2.Checked && pc == 11 && pictureBox4.Enabled == true)
            {
                pictureBox4.Image = new Bitmap(pictureBox4.Width, pictureBox4.Height);
                using (var g = Graphics.FromImage(pictureBox4.Image))
                {
                    Pen p = Pens.Blue;
                    g.DrawEllipse(p, 0, 0, 68, 68);
                    arr[3] = 0;
                }
                flag = 0; pictureBox4.Enabled = false; pc += 1;
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); flag = 0; }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); flag = 0; }
            }
            else if (radioButton2.Checked && pc == 11 && pictureBox6.Enabled == true)
            {
                pictureBox6.Image = new Bitmap(pictureBox6.Width, pictureBox6.Height);
                using (var g = Graphics.FromImage(pictureBox6.Image))
                {
                    Pen p = Pens.Blue;
                    g.DrawEllipse(p, 0, 0, 68, 68);
                    arr[5] = 0;
                }
                flag = 0; pictureBox6.Enabled = false; pc += 1;
                if (Check_x()) { MessageBox.Show("Выйграли крестики"); pobeda(); flag = 0; }
                else if (Check_o()) { MessageBox.Show("Выйграли нолики"); pobeda(); flag = 0; }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            pobeda();
            flag = 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.IO.Ports;
using System.Drawing.Drawing2D;

namespace TM_Elektromobil_PC
{
   
    public partial class Form1 : Form
    {
       


        //. Batarya Detaylarinda Mouse Uzerine gelince Kirmizi yap.
        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = System.Drawing.Color.Red;
            lbl_cs1.ForeColor = System.Drawing.Color.Red;
            lbl_cv1.ForeColor = System.Drawing.Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = System.Drawing.Color.Orange;
            lbl_cs1.ForeColor = System.Drawing.Color.Orange;
            lbl_cv1.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cv1_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = System.Drawing.Color.Red;
            lbl_cs1.ForeColor = System.Drawing.Color.Red;
            lbl_cv1.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cv1_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = System.Drawing.Color.Orange;
            lbl_cs1.ForeColor = System.Drawing.Color.Orange;
            lbl_cv1.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cs1_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = System.Drawing.Color.Red;
            lbl_cs1.ForeColor = System.Drawing.Color.Red;
            lbl_cv1.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cs1_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = System.Drawing.Color.Orange;
            lbl_cs1.ForeColor = System.Drawing.Color.Orange;
            lbl_cv1.ForeColor = System.Drawing.Color.Orange;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = System.Drawing.Color.Red;
            lbl_cs2.ForeColor = System.Drawing.Color.Red;
            lbl_cv2.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cv2_DragEnter(object sender, DragEventArgs e)
        {
            label4.ForeColor = System.Drawing.Color.Red;
            lbl_cs2.ForeColor = System.Drawing.Color.Red;
            lbl_cv2.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cs2_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = System.Drawing.Color.Red;
            lbl_cs2.ForeColor = System.Drawing.Color.Red;
            lbl_cv2.ForeColor = System.Drawing.Color.Red;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = System.Drawing.Color.Orange;
            lbl_cs2.ForeColor = System.Drawing.Color.Orange;
            lbl_cv2.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cv2_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = System.Drawing.Color.Orange;
            lbl_cs2.ForeColor = System.Drawing.Color.Orange;
            lbl_cv2.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cs2_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = System.Drawing.Color.Orange;
            lbl_cs2.ForeColor = System.Drawing.Color.Orange;
            lbl_cv2.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cv2_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = System.Drawing.Color.Red;
            lbl_cs2.ForeColor = System.Drawing.Color.Red;
            lbl_cv2.ForeColor = System.Drawing.Color.Red;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = System.Drawing.Color.Red;
            lbl_cs3.ForeColor = System.Drawing.Color.Red;
            lbl_cv3.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cv3_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = System.Drawing.Color.Red;
            lbl_cs3.ForeColor = System.Drawing.Color.Red;
            lbl_cv3.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cs3_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = System.Drawing.Color.Red;
            lbl_cs3.ForeColor = System.Drawing.Color.Red;
            lbl_cv3.ForeColor = System.Drawing.Color.Red;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = System.Drawing.Color.Orange;
            lbl_cs3.ForeColor = System.Drawing.Color.Orange;
            lbl_cv3.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cv3_MouseHover(object sender, EventArgs e)
        {

        }

        private void lbl_cv3_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = System.Drawing.Color.Orange;
            lbl_cs3.ForeColor = System.Drawing.Color.Orange;
            lbl_cv3.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cs3_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = System.Drawing.Color.Orange;
            lbl_cs3.ForeColor = System.Drawing.Color.Orange;
            lbl_cv3.ForeColor = System.Drawing.Color.Orange;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = System.Drawing.Color.Red;
            lbl_cs4.ForeColor = System.Drawing.Color.Red;
            lbl_cv4.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cv4_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = System.Drawing.Color.Red;
            lbl_cs4.ForeColor = System.Drawing.Color.Red;
            lbl_cv4.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cs4_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = System.Drawing.Color.Red;
            lbl_cs4.ForeColor = System.Drawing.Color.Red;
            lbl_cv4.ForeColor = System.Drawing.Color.Red;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = System.Drawing.Color.Orange;
            lbl_cs4.ForeColor = System.Drawing.Color.Orange;
            lbl_cv4.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cv4_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = System.Drawing.Color.Orange;
            lbl_cs4.ForeColor = System.Drawing.Color.Orange;
            lbl_cv4.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cs4_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = System.Drawing.Color.Orange;
            lbl_cs4.ForeColor = System.Drawing.Color.Orange;
            lbl_cv4.ForeColor = System.Drawing.Color.Orange;
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
        }

        private void lbl_cv5_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = System.Drawing.Color.Orange;
            lbl_cs5.ForeColor = System.Drawing.Color.Orange;
            lbl_cv5.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cs5_DragEnter(object sender, DragEventArgs e)
        {
        }

        private void lbl_cv5_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = System.Drawing.Color.Red;
            lbl_cs5.ForeColor = System.Drawing.Color.Red;
            lbl_cv5.ForeColor = System.Drawing.Color.Red;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = System.Drawing.Color.Orange;
            lbl_cs5.ForeColor = System.Drawing.Color.Orange;
            lbl_cv5.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cs5_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = System.Drawing.Color.Orange;
            lbl_cs5.ForeColor = System.Drawing.Color.Orange;
            lbl_cv5.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cs5_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = System.Drawing.Color.Red;
            lbl_cs5.ForeColor = System.Drawing.Color.Red;
            lbl_cv5.ForeColor = System.Drawing.Color.Red;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = System.Drawing.Color.Red;
            lbl_cs5.ForeColor = System.Drawing.Color.Red;
            lbl_cv5.ForeColor = System.Drawing.Color.Red;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = System.Drawing.Color.Red;
            lbl_cs6.ForeColor = System.Drawing.Color.Red;
            lbl_cv6.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cv6_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = System.Drawing.Color.Red;
            lbl_cs6.ForeColor = System.Drawing.Color.Red;
            lbl_cv6.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cs6_MouseEnter(object sender, EventArgs e)
        {
            label8.ForeColor = System.Drawing.Color.Red;
            lbl_cs6.ForeColor = System.Drawing.Color.Red;
            lbl_cv6.ForeColor = System.Drawing.Color.Red;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = System.Drawing.Color.Orange;
            lbl_cs6.ForeColor = System.Drawing.Color.Orange;
            lbl_cv6.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cv6_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = System.Drawing.Color.Orange;
            lbl_cs6.ForeColor = System.Drawing.Color.Orange;
            lbl_cv6.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cs6_MouseLeave(object sender, EventArgs e)
        {
            label8.ForeColor = System.Drawing.Color.Orange;
            lbl_cs6.ForeColor = System.Drawing.Color.Orange;
            lbl_cv6.ForeColor = System.Drawing.Color.Orange;
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            label9.ForeColor = System.Drawing.Color.Red;
            lbl_cs7.ForeColor = System.Drawing.Color.Red;
            lbl_cv7.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cv7_MouseEnter(object sender, EventArgs e)
        {
            label9.ForeColor = System.Drawing.Color.Red;
            lbl_cs7.ForeColor = System.Drawing.Color.Red;
            lbl_cv7.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cs7_MouseEnter(object sender, EventArgs e)
        {
            label9.ForeColor = System.Drawing.Color.Red;
            lbl_cs7.ForeColor = System.Drawing.Color.Red;
            lbl_cv7.ForeColor = System.Drawing.Color.Red;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.ForeColor = System.Drawing.Color.Orange;
            lbl_cs7.ForeColor = System.Drawing.Color.Orange;
            lbl_cv7.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cv7_MouseLeave(object sender, EventArgs e)
        {
            label9.ForeColor = System.Drawing.Color.Orange;
            lbl_cs7.ForeColor = System.Drawing.Color.Orange;
            lbl_cv7.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cs7_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cs7_MouseLeave(object sender, EventArgs e)
        {
            label9.ForeColor = System.Drawing.Color.Orange;
            lbl_cs7.ForeColor = System.Drawing.Color.Orange;
            lbl_cv7.ForeColor = System.Drawing.Color.Orange;
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label10.ForeColor = System.Drawing.Color.Red;
            lbl_cs8.ForeColor = System.Drawing.Color.Red;
            lbl_cv8.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cv8_MouseEnter(object sender, EventArgs e)
        {
            label10.ForeColor = System.Drawing.Color.Red;
            lbl_cs8.ForeColor = System.Drawing.Color.Red;
            lbl_cv8.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cs8_MouseEnter(object sender, EventArgs e)
        {
            label10.ForeColor = System.Drawing.Color.Red;
            lbl_cs8.ForeColor = System.Drawing.Color.Red;
            lbl_cv8.ForeColor = System.Drawing.Color.Red;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.ForeColor = System.Drawing.Color.Orange;
            lbl_cs8.ForeColor = System.Drawing.Color.Orange;
            lbl_cv8.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cv8_MouseLeave(object sender, EventArgs e)
        {
            label10.ForeColor = System.Drawing.Color.Orange;
            lbl_cs8.ForeColor = System.Drawing.Color.Orange;
            lbl_cv8.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cs8_MouseLeave(object sender, EventArgs e)
        {
            label10.ForeColor = System.Drawing.Color.Orange;
            lbl_cs8.ForeColor = System.Drawing.Color.Orange;
            lbl_cv8.ForeColor = System.Drawing.Color.Orange;
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            label11.ForeColor = System.Drawing.Color.Red;
            lbl_cs9.ForeColor = System.Drawing.Color.Red;
            lbl_cv9.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cv9_MouseEnter(object sender, EventArgs e)
        {
            label11.ForeColor = System.Drawing.Color.Red;
            lbl_cs9.ForeColor = System.Drawing.Color.Red;
            lbl_cv9.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cs9_MouseEnter(object sender, EventArgs e)
        {
            label11.ForeColor = System.Drawing.Color.Red;
            lbl_cs9.ForeColor = System.Drawing.Color.Red;
            lbl_cv9.ForeColor = System.Drawing.Color.Red;
        }

        private void label11_MouseLeave(object sender, EventArgs e)
        {
            label11.ForeColor = System.Drawing.Color.Orange;
            lbl_cs9.ForeColor = System.Drawing.Color.Orange;
            lbl_cv9.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cv9_MouseLeave(object sender, EventArgs e)
        {
            label11.ForeColor = System.Drawing.Color.Orange;
            lbl_cs9.ForeColor = System.Drawing.Color.Orange;
            lbl_cv9.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cs9_MouseLeave(object sender, EventArgs e)
        {
            label11.ForeColor = System.Drawing.Color.Orange;
            lbl_cs9.ForeColor = System.Drawing.Color.Orange;
            lbl_cv9.ForeColor = System.Drawing.Color.Orange;
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            label12.ForeColor = System.Drawing.Color.Red;
            lbl_cs10.ForeColor = System.Drawing.Color.Red;
            lbl_cv10.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cv10_MouseEnter(object sender, EventArgs e)
        {
            label12.ForeColor = System.Drawing.Color.Red;
            lbl_cs10.ForeColor = System.Drawing.Color.Red;
            lbl_cv10.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cs10_MouseEnter(object sender, EventArgs e)
        {
            label12.ForeColor = System.Drawing.Color.Red;
            lbl_cs10.ForeColor = System.Drawing.Color.Red;
            lbl_cv10.ForeColor = System.Drawing.Color.Red;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            label12.ForeColor = System.Drawing.Color.Orange;
            lbl_cs10.ForeColor = System.Drawing.Color.Orange;
            lbl_cv10.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cv10_MouseLeave(object sender, EventArgs e)
        {
            label12.ForeColor = System.Drawing.Color.Orange;
            lbl_cs10.ForeColor = System.Drawing.Color.Orange;
            lbl_cv10.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cs10_MouseLeave(object sender, EventArgs e)
        {
            label12.ForeColor = System.Drawing.Color.Orange;
            lbl_cs10.ForeColor = System.Drawing.Color.Orange;
            lbl_cv10.ForeColor = System.Drawing.Color.Orange;
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            label13.ForeColor = System.Drawing.Color.Red;
            lbl_cs11.ForeColor = System.Drawing.Color.Red;
            lbl_cv11.ForeColor = System.Drawing.Color.Red;
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            label14.ForeColor = System.Drawing.Color.Red;
            lbl_cs12.ForeColor = System.Drawing.Color.Red;
            lbl_cv12.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cv11_MouseEnter(object sender, EventArgs e)
        {
            label13.ForeColor = System.Drawing.Color.Red;
            lbl_cs11.ForeColor = System.Drawing.Color.Red;
            lbl_cv11.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cs11_MouseEnter(object sender, EventArgs e)
        {
            label13.ForeColor = System.Drawing.Color.Red;
            lbl_cs11.ForeColor = System.Drawing.Color.Red;
            lbl_cv11.ForeColor = System.Drawing.Color.Red;
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            label13.ForeColor = System.Drawing.Color.Orange;
            lbl_cs11.ForeColor = System.Drawing.Color.Orange;
            lbl_cv11.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cv11_MouseLeave(object sender, EventArgs e)
        {
            label13.ForeColor = System.Drawing.Color.Orange;
            lbl_cs11.ForeColor = System.Drawing.Color.Orange;
            lbl_cv11.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cs11_MouseLeave(object sender, EventArgs e)
        {
            label13.ForeColor = System.Drawing.Color.Orange;
            lbl_cs11.ForeColor = System.Drawing.Color.Orange;
            lbl_cv11.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cv12_MouseEnter(object sender, EventArgs e)
        {
            label14.ForeColor = System.Drawing.Color.Red;
            lbl_cs12.ForeColor = System.Drawing.Color.Red;
            lbl_cv12.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cs12_MouseEnter(object sender, EventArgs e)
        {
            label14.ForeColor = System.Drawing.Color.Red;
            lbl_cs12.ForeColor = System.Drawing.Color.Red;
            lbl_cv12.ForeColor = System.Drawing.Color.Red;
        }

        private void label14_MouseLeave(object sender, EventArgs e)
        {
            label14.ForeColor = System.Drawing.Color.Orange;
            lbl_cs12.ForeColor = System.Drawing.Color.Orange;
            lbl_cv12.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cv12_MouseLeave(object sender, EventArgs e)
        {
            label14.ForeColor = System.Drawing.Color.Orange;
            lbl_cs12.ForeColor = System.Drawing.Color.Orange;
            lbl_cv12.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cs12_MouseLeave(object sender, EventArgs e)
        {
            label14.ForeColor = System.Drawing.Color.Orange;
            lbl_cs12.ForeColor = System.Drawing.Color.Orange;
            lbl_cv12.ForeColor = System.Drawing.Color.Orange;
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            label15.ForeColor = System.Drawing.Color.Red;
            lbl_cs13.ForeColor = System.Drawing.Color.Red;
            lbl_cv13.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cv13_MouseEnter(object sender, EventArgs e)
        {
            label15.ForeColor = System.Drawing.Color.Red;
            lbl_cs13.ForeColor = System.Drawing.Color.Red;
            lbl_cv13.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cs13_MouseEnter(object sender, EventArgs e)
        {
            label15.ForeColor = System.Drawing.Color.Red;
            lbl_cs13.ForeColor = System.Drawing.Color.Red;
            lbl_cv13.ForeColor = System.Drawing.Color.Red;
        }

        private void label15_MouseLeave(object sender, EventArgs e)
        {
            label15.ForeColor = System.Drawing.Color.Orange;
            lbl_cs13.ForeColor = System.Drawing.Color.Orange;
            lbl_cv13.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cv13_MouseLeave(object sender, EventArgs e)
        {
            label15.ForeColor = System.Drawing.Color.Orange;
            lbl_cs13.ForeColor = System.Drawing.Color.Orange;
            lbl_cv13.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cs13_MouseLeave(object sender, EventArgs e)
        {
            label15.ForeColor = System.Drawing.Color.Orange;
            lbl_cs13.ForeColor = System.Drawing.Color.Orange;
            lbl_cv13.ForeColor = System.Drawing.Color.Orange;
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            label16.ForeColor = System.Drawing.Color.Red;
            lbl_cs14.ForeColor = System.Drawing.Color.Red;
            lbl_cv14.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cv14_MouseEnter(object sender, EventArgs e)
        {
            label16.ForeColor = System.Drawing.Color.Red;
            lbl_cs14.ForeColor = System.Drawing.Color.Red;
            lbl_cv14.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cs14_MouseEnter(object sender, EventArgs e)
        {
            label16.ForeColor = System.Drawing.Color.Red;
            lbl_cs14.ForeColor = System.Drawing.Color.Red;
            lbl_cv14.ForeColor = System.Drawing.Color.Red;
        }

        private void label16_MouseLeave(object sender, EventArgs e)
        {
            label16.ForeColor = System.Drawing.Color.Orange;
            lbl_cs14.ForeColor = System.Drawing.Color.Orange;
            lbl_cv14.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cv14_MouseLeave(object sender, EventArgs e)
        {
            label16.ForeColor = System.Drawing.Color.Orange;
            lbl_cs14.ForeColor = System.Drawing.Color.Orange;
            lbl_cv14.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cs14_MouseLeave(object sender, EventArgs e)
        {
            label16.ForeColor = System.Drawing.Color.Orange;
            lbl_cs14.ForeColor = System.Drawing.Color.Orange;
            lbl_cv14.ForeColor = System.Drawing.Color.Orange;

        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {
            label17.ForeColor = System.Drawing.Color.Red;
            lbl_cs15.ForeColor = System.Drawing.Color.Red;
            lbl_cv15.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cv15_MouseEnter(object sender, EventArgs e)
        {
            label17.ForeColor = System.Drawing.Color.Red;
            lbl_cs15.ForeColor = System.Drawing.Color.Red;
            lbl_cv15.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cs15_MouseEnter(object sender, EventArgs e)
        {
            label17.ForeColor = System.Drawing.Color.Red;
            lbl_cs15.ForeColor = System.Drawing.Color.Red;
            lbl_cv15.ForeColor = System.Drawing.Color.Red;
        }

        private void label17_MouseLeave(object sender, EventArgs e)
        {
            label17.ForeColor = System.Drawing.Color.Orange;
            lbl_cs15.ForeColor = System.Drawing.Color.Orange;
            lbl_cv15.ForeColor = System.Drawing.Color.Orange;
        }

        private void label18_MouseEnter(object sender, EventArgs e)
        {
            label18.ForeColor = System.Drawing.Color.Red;
            lbl_cs16.ForeColor = System.Drawing.Color.Red;
            lbl_cv16.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cv15_MouseLeave(object sender, EventArgs e)
        {
            label17.ForeColor = System.Drawing.Color.Orange;
            lbl_cs15.ForeColor = System.Drawing.Color.Orange;
            lbl_cv15.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cs15_MouseLeave(object sender, EventArgs e)
        {
            label17.ForeColor = System.Drawing.Color.Orange;
            lbl_cs15.ForeColor = System.Drawing.Color.Orange;
            lbl_cv15.ForeColor = System.Drawing.Color.Orange;
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_cv16_MouseEnter(object sender, EventArgs e)
        {
            label18.ForeColor = System.Drawing.Color.Red;
            lbl_cs16.ForeColor = System.Drawing.Color.Red;
            lbl_cv16.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cs16_MouseEnter(object sender, EventArgs e)
        {
            label18.ForeColor = System.Drawing.Color.Red;
            lbl_cs16.ForeColor = System.Drawing.Color.Red;
            lbl_cv16.ForeColor = System.Drawing.Color.Red;
        }

        private void label18_MouseLeave(object sender, EventArgs e)
        {
            label18.ForeColor = System.Drawing.Color.Orange;
            lbl_cs16.ForeColor = System.Drawing.Color.Orange;
            lbl_cv16.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cv16_MouseLeave(object sender, EventArgs e)
        {
            label18.ForeColor = System.Drawing.Color.Orange;
            lbl_cs16.ForeColor = System.Drawing.Color.Orange;
            lbl_cv16.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cs16_MouseLeave(object sender, EventArgs e)
        {
            label18.ForeColor = System.Drawing.Color.Orange;
            lbl_cs16.ForeColor = System.Drawing.Color.Orange;
            lbl_cv16.ForeColor = System.Drawing.Color.Orange;
        }

        private void label19_MouseEnter(object sender, EventArgs e)
        {
            label19.ForeColor = System.Drawing.Color.Red;
            lbl_cs17.ForeColor = System.Drawing.Color.Red;
            lbl_cv17.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cv17_MouseEnter(object sender, EventArgs e)
        {
            label19.ForeColor = System.Drawing.Color.Red;
            lbl_cs17.ForeColor = System.Drawing.Color.Red;
            lbl_cv17.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cs17_MouseEnter(object sender, EventArgs e)
        {
            label19.ForeColor = System.Drawing.Color.Red;
            lbl_cs17.ForeColor = System.Drawing.Color.Red;
            lbl_cv17.ForeColor = System.Drawing.Color.Red;
        }

        private void label19_MouseLeave(object sender, EventArgs e)
        {
            label19.ForeColor = System.Drawing.Color.Orange;
            lbl_cs17.ForeColor = System.Drawing.Color.Orange;
            lbl_cv17.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cv17_MouseLeave(object sender, EventArgs e)
        {
            label19.ForeColor = System.Drawing.Color.Orange;
            lbl_cs17.ForeColor = System.Drawing.Color.Orange;
            lbl_cv17.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cs17_MouseLeave(object sender, EventArgs e)
        {
            label19.ForeColor = System.Drawing.Color.Orange;
            lbl_cs17.ForeColor = System.Drawing.Color.Orange;
            lbl_cv17.ForeColor = System.Drawing.Color.Orange;
        }

        private void label20_MouseEnter(object sender, EventArgs e)
        {
            label20.ForeColor = System.Drawing.Color.Red;
            lbl_cs18.ForeColor = System.Drawing.Color.Red;
            lbl_cv18.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cv18_MouseEnter(object sender, EventArgs e)
        {
            label20.ForeColor = System.Drawing.Color.Red;
            lbl_cs18.ForeColor = System.Drawing.Color.Red;
            lbl_cv18.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cs18_MouseEnter(object sender, EventArgs e)
        {
            label20.ForeColor = System.Drawing.Color.Red;
            lbl_cs18.ForeColor = System.Drawing.Color.Red;
            lbl_cv18.ForeColor = System.Drawing.Color.Red;
        }

        private void label20_MouseLeave(object sender, EventArgs e)
        {
            label20.ForeColor = System.Drawing.Color.Orange;
            lbl_cs18.ForeColor = System.Drawing.Color.Orange;
            lbl_cv18.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cv18_MouseLeave(object sender, EventArgs e)
        {
            label20.ForeColor = System.Drawing.Color.Orange;
            lbl_cs18.ForeColor = System.Drawing.Color.Orange;
            lbl_cv18.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cs18_MouseLeave(object sender, EventArgs e)
        {
            label20.ForeColor = System.Drawing.Color.Orange;
            lbl_cs18.ForeColor = System.Drawing.Color.Orange;
            lbl_cv18.ForeColor = System.Drawing.Color.Orange;
        }

        private void label21_MouseEnter(object sender, EventArgs e)
        {
            label21.ForeColor = System.Drawing.Color.Red;
            lbl_cs19.ForeColor = System.Drawing.Color.Red;
            lbl_cv19.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cv19_MouseEnter(object sender, EventArgs e)
        {
            label21.ForeColor = System.Drawing.Color.Red;
            lbl_cs19.ForeColor = System.Drawing.Color.Red;
            lbl_cv19.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cs19_MouseEnter(object sender, EventArgs e)
        {
            label21.ForeColor = System.Drawing.Color.Red;
            lbl_cs19.ForeColor = System.Drawing.Color.Red;
            lbl_cv19.ForeColor = System.Drawing.Color.Red;
        }

        private void label21_MouseLeave(object sender, EventArgs e)
        {
            label21.ForeColor = System.Drawing.Color.Orange;
            lbl_cs19.ForeColor = System.Drawing.Color.Orange;
            lbl_cv19.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cv19_MouseLeave(object sender, EventArgs e)
        {
            label21.ForeColor = System.Drawing.Color.Orange;
            lbl_cs19.ForeColor = System.Drawing.Color.Orange;
            lbl_cv19.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cs19_MouseLeave(object sender, EventArgs e)
        {
            label21.ForeColor = System.Drawing.Color.Orange;
            lbl_cs19.ForeColor = System.Drawing.Color.Orange;
            lbl_cv19.ForeColor = System.Drawing.Color.Orange;
        }

        private void label22_MouseEnter(object sender, EventArgs e)
        {
            label22.ForeColor = System.Drawing.Color.Red;
            lbl_cs20.ForeColor = System.Drawing.Color.Red;
            lbl_cv20.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cv20_MouseEnter(object sender, EventArgs e)
        {
            label22.ForeColor = System.Drawing.Color.Red;
            lbl_cs20.ForeColor = System.Drawing.Color.Red;
            lbl_cv20.ForeColor = System.Drawing.Color.Red;
        }

        private void lbl_cs20_MouseEnter(object sender, EventArgs e)
        {
            label22.ForeColor = System.Drawing.Color.Red;
            lbl_cs20.ForeColor = System.Drawing.Color.Red;
            lbl_cv20.ForeColor = System.Drawing.Color.Red;
        }

        private void label22_MouseLeave(object sender, EventArgs e)
        {
            label22.ForeColor = System.Drawing.Color.Orange;
            lbl_cs20.ForeColor = System.Drawing.Color.Orange;
            lbl_cv20.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cv20_MouseLeave(object sender, EventArgs e)
        {
            label22.ForeColor = System.Drawing.Color.Orange;
            lbl_cs20.ForeColor = System.Drawing.Color.Orange;
            lbl_cv20.ForeColor = System.Drawing.Color.Orange;
        }

        private void lbl_cs20_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cs20_MouseLeave(object sender, EventArgs e)
        {
            label22.ForeColor = System.Drawing.Color.Orange;
            lbl_cs20.ForeColor = System.Drawing.Color.Orange;
            lbl_cv20.ForeColor = System.Drawing.Color.Orange;
        }

        /* ###################################################################################################################
        ######################################################################################################################


                                                            DEĞİŞKENLER BURADA


        ######################################################################################################################
        ####################################################################################################################*/

        float max_akim_yaz = 0;
        float akim = 0;
        float max_akim = 0;
        float max_sicaklik = 0;

        

        bool _chronostart = false;

        //. Yarış Tur rapornun kaydedileceği yer 
        //string dosya_adi = @"V:\Kocaeli University\TurkMekatronik\TurkMekatronik_database\lap_times.txt";
        string dosya_adi = @"C:\TM\lap_times.txt";
        string data_saved = "Tur\t\tTarih/Saat\t\tTur Süresi\t\t";
        string data_read;


        int _h = 0, _m = 0, _s = 0, _ms = 0;   //. hour - minute - second - milisecond
        int _bh = 999, _bm = 999, _bs = 999, _bms = 999; //. best time
        int _th = 0, _tm = 0, _ts = 0, _tms = 0; //. total time
        int _rh = 0, _rm = 0, _rs = 0, _rms = 0, _rtms = 39000; //. Remaining Time
        int _counter = 0, _remain_counter = 35; //. Lap Counter
        int _bestLap = 0; //. BestLap variable
        int opt_zaman = 0;

        int x_pos = 0, y_pos = 0; //. Marquee for Copyright


        //. Get available COM ports to an array
        string[] ports = SerialPort.GetPortNames();




        public static void save_laptime(string s)
        {
            // İşlem yapılacak dosyanın yolu yazıldı
            //string dosya_yolu = @"V:\Kocaeli University\TurkMekatronik\TurkMekatronik_database\lap_times.txt";
            string dosya_yolu = @"lap_times.txt";

            /*
            File Stream Nesnesi Oluşturuldu
            2. Parametre Dosyanın açılacağını eğer yoksa oluşturulacağını ayarladı.
            3. Parametre Dosyaya yapılacak işlemi belirledi
            */

            FileStream fs = new FileStream(dosya_yolu, FileMode.OpenOrCreate, FileAccess.Write);


            // Yazma işlemi için StremWriter nesnesi oluşturuldu.
            StreamWriter sw = new StreamWriter(fs);

            //sw = File.AppendText(dosya_yolu);

            sw.WriteLine(s);
            // Veri tampon bölgeden dosyaya aktarıldı
            sw.Flush();
            // Kullanılan nesneler kapatıldı
            sw.Close();
            fs.Close();
        }
        static void DosyayaEkle(string dosya_ismi, string eklenen_veri)
        {
            StreamWriter dosya;

            dosya = File.AppendText(dosya_ismi);

            dosya.WriteLine(eklenen_veri);

            dosya.Close();
        }
        

        public Form1()
        {
            InitializeComponent();
            btn_close.Enabled = false;
            btn_open.Enabled = true;

            btn_krono_basla.Enabled = true;
            btn_laptime.Enabled = false;
            cb_balance.Enabled = false;
            cb_farlar.Enabled = false;
            cb_isiklandirma.Enabled = false;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;

            lbl_balance.ForeColor = System.Drawing.Color.Red;
            lbl_farlar.ForeColor = System.Drawing.Color.Red;
            lbl_isiklandirma.ForeColor = System.Drawing.Color.Red;

            //. Crate a txt file for lap times
            save_laptime(data_saved);
            data_saved = "------\t\t-------------------\t-----------";
            //. Add data to txt log file
            DosyayaEkle(dosya_adi, data_saved);


        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

            //. Add available COM ports to Combobox1
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
                comboBox1.SelectedIndex = 0;
            }

            //. Add baudrate options to Combobox2
            comboBox2.Items.Add("300");
            comboBox2.Items.Add("1200");
            comboBox2.Items.Add("2400");
            comboBox2.Items.Add("4800");
            comboBox2.Items.Add("9600");
            comboBox2.Items.Add("19200");
            comboBox2.Items.Add("38400");
            comboBox2.Items.Add("57600");
            comboBox2.Items.Add("74880");
            comboBox2.Items.Add("115200");
            comboBox2.Items.Add("230400");
            comboBox2.Items.Add("250000");
            comboBox2.SelectedIndex = 7;


            //. Get Marquee Text's X and Y
            x_pos = label1.Location.X;
            y_pos = label1.Location.Y;


            Marquee_timer.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        

        private void label64_Click(object sender, EventArgs e)
        {

        }

        private void lbl_bat_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        ///*
        // * ########################################################################################################
        // * ########################################################################################################
                            
        //                                SERIAL READ DATA ONLY WHEN DATA COMES

        // * ########################################################################################################
        // * ########################################################################################################
        //*/

        //private delegate void SetTextDeleg(string text);

        //void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //{
        //    string data = serialPort1.ReadLine();
        //    // Invokes the delegate on the UI thread, and sends the data that was received to the invoked method.
        //    // ---- The "si_DataReceived" method will be executed on the UI thread which allows populating of the textbox.
        //    this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data });
        //}
    


        ////*########################################################################################################

        private void button1_Click(object sender, EventArgs e)
        {

            //. Begin the connection

            serialPort1.PortName = comboBox1.SelectedItem.ToString();
            serialPort1.BaudRate = Int32.Parse(comboBox2.SelectedItem.ToString());

            //serialPort1.ReadTimeout = 10000;

            
            //serialPort1.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);


            try {
                serialPort1.Open();


                

                btn_close.Enabled = true;
                btn_open.Enabled = false;
                cb_balance.Enabled = true;
                cb_farlar.Enabled = true;
                comboBox1.Enabled = false; 
                comboBox2.Enabled = false;
                cb_isiklandirma.Enabled = true;

                lbl_status.Text = "BAĞLANTI BAŞARILI";
                lbl_status.ForeColor = System.Drawing.Color.Green;

                //serial_timer.Start();
            }
            catch(Exception)
            {
                MessageBox.Show("COM Portu Açılamadı!");
            }
                
        }

        private void update_screen(String s)
        {
            try {

                String[] dizi1;
                String[] dizib;
                String[] dizis;
                
            

                dizi1 =s.Split('Y');
                dizib = dizi1[0].Split('-');
                dizis = dizi1[1].Split('-');






                


                //. Gelen Batarya Verilerini Isle


                lbl_cv1.Text = dizib[0].Substring(2) + " V";
                    lbl_cv2.Text = dizib[1] + " V";
                    lbl_cv3.Text = dizib[2] + " V";
                    lbl_cv4.Text = dizib[3] + " V";
                    lbl_cv5.Text = dizib[4] + " V";
                    lbl_cv6.Text = dizib[5] + " V";
                    lbl_cv7.Text = dizib[6] + " V";
                    lbl_cv8.Text = dizib[7] + " V";
                    lbl_cv9.Text = dizib[8] + " V";
                    lbl_cv10.Text = dizib[9] + " V";
                    lbl_cv11.Text = dizib[10] + " V";
                    lbl_cv12.Text = dizib[11] + " V";
                    lbl_cv13.Text = dizib[12] + " V";
                    lbl_cv14.Text = dizib[13] + " V";
                    lbl_cv15.Text = dizib[14] + " V";
                    lbl_cv16.Text = dizib[15] + " V";
                    lbl_cv17.Text = dizib[16] + " V";
                    lbl_cv18.Text = dizib[17] + " V";
                    lbl_cv19.Text = dizib[18] + " V";
                    lbl_cv20.Text = dizib[19] + " V";

                

                //. Gelen Sicaklik Verilerini Isle
               
                  
                    
                

                    lbl_cs1.Text = dizis[0].Substring(2) + " °C";
                    lbl_cs2.Text = dizis[1] + " °C";
                    lbl_cs3.Text = dizis[2] + " °C";
                    lbl_cs4.Text = dizis[3] + " °C";
                    lbl_cs5.Text = dizis[4] + " °C";
                    lbl_cs6.Text = dizis[5] + " °C";
                    lbl_cs7.Text = dizis[6] + " °C";
                    lbl_cs8.Text = dizis[7] + " °C";
                    lbl_cs9.Text = dizis[8] + " °C";
                    lbl_cs10.Text = dizis[9] + " °C";
                    lbl_cs11.Text = dizis[10] + " °C";
                    lbl_cs12.Text = dizis[11] + " °C";
                    lbl_cs13.Text = dizis[12] + " °C";
                    lbl_cs14.Text = dizis[13] + " °C";
                    lbl_cs15.Text = dizis[14] + " °C";
                    lbl_cs16.Text = dizis[15] + " °C";
                    lbl_cs17.Text = dizis[16] + " °C";
                    lbl_cs18.Text = dizis[17] + " °C";
                    lbl_cs19.Text = dizis[18] + " °C";
                    lbl_cs20.Text = dizis[19] + " °C";



                int voltp = 0;
                int sicakp = 0;

                voltp = Int16.Parse(dizib[0].Substring(2));
                sicakp = Int16.Parse(dizis[0].Substring(2));
                voltprogress1.ForeColor = Color.Yellow;
                sicakprogress1.ForeColor = Color.LightBlue;
                //d.Text = sicakp.ToString();
                if (voltp > 3)
                    voltprogress1.ForeColor = Color.Green;
                if (voltp < 2)
                    voltprogress1.ForeColor = Color.Red;
                if (sicakp > 3)
                    sicakprogress1.ForeColor = Color.Red;

                voltprogress1.Value = voltp * 15;
                sicakprogress1.Value = sicakp * 15;


                voltp = Int16.Parse(dizib[1]);
                sicakp = Int16.Parse(dizis[1]);
                voltprogress2.ForeColor = Color.Yellow;
                sicakprogress2.ForeColor = Color.LightBlue;
                //d.Text = sicakp.ToString();
                if (voltp > 3)
                    voltprogress2.ForeColor = Color.Green;
                if (voltp < 2)
                    voltprogress2.ForeColor = Color.Red;
                if (sicakp > 3)
                    sicakprogress2.ForeColor = Color.Red;

                voltprogress2.Value = voltp * 15;
                sicakprogress2.Value = sicakp * 15;

                voltp = Int16.Parse(dizib[2]);
                sicakp = Int16.Parse(dizis[2]);
                voltprogress3.ForeColor = Color.Yellow;
                sicakprogress3.ForeColor = Color.LightBlue;
                //d.Text = sicakp.ToString();
                if (voltp > 3)
                    voltprogress3.ForeColor = Color.Green;
                if (voltp < 2)
                    voltprogress3.ForeColor = Color.Red;
                if (sicakp > 3)
                    sicakprogress3.ForeColor = Color.Red;

                voltprogress3.Value = voltp * 15;
                sicakprogress3.Value = sicakp * 15;

                voltp = Int16.Parse(dizib[3]);
                sicakp = Int16.Parse(dizis[3]);
                voltprogress4.ForeColor = Color.Yellow;
                sicakprogress4.ForeColor = Color.LightBlue;
                //d.Text = sicakp.ToString();
                if (voltp > 3)
                    voltprogress4.ForeColor = Color.Green;
                if (voltp < 2)
                    voltprogress4.ForeColor = Color.Red;
                if (sicakp > 3)
                    sicakprogress4.ForeColor = Color.Red;

                voltprogress4.Value = voltp * 15;
                sicakprogress4.Value = sicakp * 15;

                voltp = Int16.Parse(dizib[4]);
                sicakp = Int16.Parse(dizis[4]);
                voltprogress5.ForeColor = Color.Yellow;
                sicakprogress5.ForeColor = Color.LightBlue;
                //d.Text = sicakp.ToString();
                if (voltp > 3)
                    voltprogress5.ForeColor = Color.Green;
                if (voltp < 2)
                    voltprogress5.ForeColor = Color.Red;
                if (sicakp > 3)
                    sicakprogress5.ForeColor = Color.Red;

                voltprogress5.Value = voltp * 15;
                sicakprogress5.Value = sicakp * 15;

                voltp = Int16.Parse(dizib[5]);
                sicakp = Int16.Parse(dizis[5]);
                voltprogress6.ForeColor = Color.Yellow;
                sicakprogress6.ForeColor = Color.LightBlue;
                //d.Text = sicakp.ToString();
                if (voltp > 3)
                    voltprogress6.ForeColor = Color.Green;
                if (voltp < 2)
                    voltprogress6.ForeColor = Color.Red;
                if (sicakp > 3)
                    sicakprogress6.ForeColor = Color.Red;

                voltprogress6.Value = voltp * 15;
                sicakprogress6.Value = sicakp * 15;

                voltp = Int16.Parse(dizib[6]);
                sicakp = Int16.Parse(dizis[6]);
                voltprogress7.ForeColor = Color.Yellow;
                sicakprogress7.ForeColor = Color.LightBlue;
                //d.Text = sicakp.ToString();
                if (voltp > 3)
                    voltprogress7.ForeColor = Color.Green;
                if (voltp < 2)
                    voltprogress7.ForeColor = Color.Red;
                if (sicakp > 3)
                    sicakprogress7.ForeColor = Color.Red;

                voltprogress7.Value = voltp * 15;
                sicakprogress7.Value = sicakp * 15;


                voltp = Int16.Parse(dizib[7]);
                sicakp = Int16.Parse(dizis[7]);
                voltprogress8.ForeColor = Color.Yellow;
                sicakprogress8.ForeColor = Color.LightBlue;
                //d.Text = sicakp.ToString();
                if (voltp > 3)
                    voltprogress8.ForeColor = Color.Green;
                if (voltp < 2)
                    voltprogress8.ForeColor = Color.Red;
                if (sicakp > 3)
                    sicakprogress8.ForeColor = Color.Red;

                voltprogress8.Value = voltp * 15;
                sicakprogress8.Value = sicakp * 15;


                voltp = Int16.Parse(dizib[8]);
                sicakp = Int16.Parse(dizis[8]);
                voltprogress9.ForeColor = Color.Yellow;
                sicakprogress9.ForeColor = Color.LightBlue;
                //d.Text = sicakp.ToString();
                if (voltp > 3)
                    voltprogress9.ForeColor = Color.Green;
                if (voltp < 2)
                    voltprogress9.ForeColor = Color.Red;
                if (sicakp > 3)
                    sicakprogress9.ForeColor = Color.Red;

                voltprogress9.Value = voltp * 15;
                sicakprogress9.Value = sicakp * 15;


                voltp = Int16.Parse(dizib[9]);
                sicakp = Int16.Parse(dizis[9]);
                voltprogress10.ForeColor = Color.Yellow;
                sicakprogress10.ForeColor = Color.LightBlue;
                //d.Text = sicakp.ToString();
                if (voltp > 3)
                    voltprogress10.ForeColor = Color.Green;
                if (voltp < 2)
                    voltprogress10.ForeColor = Color.Red;
                if (sicakp > 3)
                    sicakprogress10.ForeColor = Color.Red;

                voltprogress10.Value = voltp * 15;
                sicakprogress10.Value = sicakp * 15;


                voltp = Int16.Parse(dizib[10]);
                sicakp = Int16.Parse(dizis[10]);
                voltprogress11.ForeColor = Color.Yellow;
                sicakprogress11.ForeColor = Color.LightBlue;
                //d.Text = sicakp.ToString();
                if (voltp > 3)
                    voltprogress11.ForeColor = Color.Green;
                if (voltp < 2)
                    voltprogress11.ForeColor = Color.Red;
                if (sicakp > 3)
                    sicakprogress11.ForeColor = Color.Red;

                voltprogress11.Value = voltp * 15;
                sicakprogress11.Value = sicakp * 15;


                voltp = Int16.Parse(dizib[11]);
                sicakp = Int16.Parse(dizis[11]);
                voltprogress12.ForeColor = Color.Yellow;
                sicakprogress12.ForeColor = Color.LightBlue;
                //d.Text = sicakp.ToString();
                if (voltp > 3)
                    voltprogress12.ForeColor = Color.Green;
                if (voltp < 2)
                    voltprogress12.ForeColor = Color.Red;
                if (sicakp > 3)
                    sicakprogress12.ForeColor = Color.Red;

                voltprogress12.Value = voltp * 15;
                sicakprogress12.Value = sicakp * 15;


                voltp = Int16.Parse(dizib[12]);
                sicakp = Int16.Parse(dizis[12]);
                voltprogress13.ForeColor = Color.Yellow;
                sicakprogress13.ForeColor = Color.LightBlue;
                //d.Text = sicakp.ToString();
                if (voltp > 3)
                    voltprogress13.ForeColor = Color.Green;
                if (voltp < 2)
                    voltprogress13.ForeColor = Color.Red;
                if (sicakp > 3)
                    sicakprogress13.ForeColor = Color.Red;

                voltprogress13.Value = voltp * 15;
                sicakprogress13.Value = sicakp * 15;

                voltp = Int16.Parse(dizib[13]);
                sicakp = Int16.Parse(dizis[13]);
                voltprogress14.ForeColor = Color.Yellow;
                sicakprogress14.ForeColor = Color.LightBlue;
                //d.Text = sicakp.ToString();
                if (voltp > 3)
                    voltprogress14.ForeColor = Color.Green;
                if (voltp < 2)
                    voltprogress14.ForeColor = Color.Red;
                if (sicakp > 3)
                    sicakprogress14.ForeColor = Color.Red;

                voltprogress14.Value = voltp * 15;
                sicakprogress14.Value = sicakp * 15;


                voltp = Int16.Parse(dizib[14]);
                sicakp = Int16.Parse(dizis[14]);
                voltprogress15.ForeColor = Color.Yellow;
                sicakprogress15.ForeColor = Color.LightBlue;
                //d.Text = sicakp.ToString();
                if (voltp > 3)
                    voltprogress15.ForeColor = Color.Green;
                if (voltp < 2)
                    voltprogress15.ForeColor = Color.Red;
                if (sicakp > 3)
                    sicakprogress15.ForeColor = Color.Red;

                voltprogress15.Value = voltp * 15;
                sicakprogress15.Value = sicakp * 15;

                voltp = Int16.Parse(dizib[15]);
                sicakp = Int16.Parse(dizis[15]);
                voltprogress16.ForeColor = Color.Yellow;
                sicakprogress16.ForeColor = Color.LightBlue;
                //d.Text = sicakp.ToString();
                if (voltp > 3)
                    voltprogress16.ForeColor = Color.Green;
                if (voltp < 2)
                    voltprogress16.ForeColor = Color.Red;
                if (sicakp > 3)
                    sicakprogress16.ForeColor = Color.Red;

                voltprogress16.Value = voltp * 15;
                sicakprogress16.Value = sicakp * 15;


                voltp = Int16.Parse(dizib[16]);
                sicakp = Int16.Parse(dizis[16]);
                voltprogress10.ForeColor = Color.Yellow;
                sicakprogress17.ForeColor = Color.LightBlue;
                //d.Text = sicakp.ToString();
                if (voltp > 3)
                    voltprogress17.ForeColor = Color.Green;
                if (voltp < 2)
                    voltprogress17.ForeColor = Color.Red;
                if (sicakp > 3)
                    sicakprogress17.ForeColor = Color.Red;

                voltprogress17.Value = voltp * 15;
                sicakprogress17.Value = sicakp * 15;

                voltp = Int16.Parse(dizib[17]);
                sicakp = Int16.Parse(dizis[17]);
                voltprogress18.ForeColor = Color.Yellow;
                sicakprogress18.ForeColor = Color.LightBlue;
                //d.Text = sicakp.ToString();
                if (voltp > 3)
                    voltprogress18.ForeColor = Color.Green;
                if (voltp < 2)
                    voltprogress18.ForeColor = Color.Red;
                if (sicakp > 3)
                    sicakprogress18.ForeColor = Color.Red;

                voltprogress18.Value = voltp * 15;
                sicakprogress18.Value = sicakp * 15;

                voltp = Int16.Parse(dizib[18]);
                sicakp = Int16.Parse(dizis[18]);
                voltprogress19.ForeColor = Color.Yellow;
                sicakprogress19.ForeColor = Color.LightBlue;
                //d.Text = sicakp.ToString();
                if (voltp > 3)
                    voltprogress19.ForeColor = Color.Green;
                if (voltp < 2)
                    voltprogress19.ForeColor = Color.Red;
                if (sicakp > 3)
                    sicakprogress19.ForeColor = Color.Red;

                voltprogress19.Value = voltp * 15;
                sicakprogress19.Value = sicakp * 15;

                voltp = Int16.Parse(dizib[19]);
                sicakp = Int16.Parse(dizis[19]);
                voltprogress20.ForeColor = Color.Yellow;
                sicakprogress20.ForeColor = Color.LightBlue;
                //d.Text = sicakp.ToString();
                if (voltp > 3)
                    voltprogress20.ForeColor = Color.Green;
                if (voltp < 2)
                    voltprogress20.ForeColor = Color.Red;
                if (sicakp > 3)
                    sicakprogress20.ForeColor = Color.Red;

                voltprogress20.Value = voltp * 15;
                sicakprogress20.Value = sicakp * 15;


                lbl_anlik_akim.Text = (dizi1[3].Substring(2));
                lbl_hiz.Text = (dizi1[4].Substring(2));
                lbl_bat.Text = (dizi1[2].Substring(2));
               


               

                //. Maximum Genel ve Anlik Sicaklik Degeri Hesapla
                float anlik_max_sicaklik = 0;

                // dene.Text = dizis[5].ToString();

                dene.Text="ff";
          

                for (int j = 0; j < 20; j++)
                 {

                    if (j == 0)
                    {
                        if (max_sicaklik < float.Parse(dizis[j].Substring(2)))
                            max_sicaklik = float.Parse(dizis[j].Substring(2));
                        if (anlik_max_sicaklik < float.Parse(dizis[j].Substring(2)))
                        {
                            anlik_max_sicaklik = float.Parse(dizis[j].Substring(2));

                            lbl_anlik_max_sicaklik.Text = "Cell " + (j + 1).ToString() + ":  " + float.Parse(dizis[j].Substring(2)).ToString() + " °C";

                            lbl_anlik_max_sicaklik.ForeColor = System.Drawing.Color.Red;
                        }

                    }
                    else
                    {
                        if (max_sicaklik < float.Parse(dizis[j]))
                        {
                            max_sicaklik = float.Parse(dizis[j]);

                        }
                        if (anlik_max_sicaklik < float.Parse(dizis[j]))
                        {
                            anlik_max_sicaklik = float.Parse(dizis[j]);

                            lbl_anlik_max_sicaklik.Text = "Cell " + (j + 1).ToString() + ":  " + float.Parse(dizis[j]).ToString() + " °C";
                            lbl_anlik_max_sicaklik.ForeColor = System.Drawing.Color.Red;
                        }
                    }
                    
                    
                   
                }
              
                //dene.Text = "fordan cıktı";
                //. Maximum Anlik Sicakligi Yazdir
                lbl_max_sic.Text = max_sicaklik + " °C";



                //. Gelen Akım Verilerini Isle




                
                String hesap = dizi1[3].Substring(2);
                int a_kacta = hesap.IndexOf("a");
                String akim = dizi1[3].Substring(2, a_kacta);

            
                //dene.Text = akim;

                max_akim_yaz = max_akim_bul(float.Parse(akim)); 
                lbl_max_akim.Text = max_akim_yaz.ToString() + " A";
                lbl_max_akim.ForeColor = System.Drawing.Color.Blue;




      




               
                       //. Gelen Toplam Voltaj Degerlerini Isle Yuzdesini Hesapla
                       
                       

                       double percentage = 0;
                String v_bul = dizi1[2].Substring(2);
                int v_kacta = v_bul.IndexOf("v");
                String v_degeri = dizi1[2].Substring(2, v_kacta);
                
                dene.Text = v_degeri;

               

                float v_toplam = float.Parse(v_degeri) / 100;

                      percentage = (v_toplam - 59) * 4;
                       percentage = Math.Round(percentage, 2);

                      // percentage = (100 * v_toplam) / 80;

                       lbl_yuzde.Text = percentage.ToString() + " %";




                // hız---------------------------------
                Bitmap hizBitmap;

                hizBitmap = (Bitmap)hiz_pictureBox2.Image;
                
               // drawBitmap.RotateFlip(RotateFlipType.Rotate90FlipXY);

                hiz_pictureBox2.Image = hizBitmap;
                this.hiz_pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;

                int hiz_tut = 0;
                foreach (char c in lbl_hiz.Text)
                {
                    if (char.IsDigit(c))
                    {
                        hiz_tut++;
                    }
                }


                string hiz_deger;
                float hiz_derece_tut;
                hiz_deger = (lbl_hiz.Text.Substring(0, hiz_tut));
                //d.Text = deger;
                hiz_derece_tut = float.Parse(hiz_deger);
        
                if (hiz_derece_tut >= 0 ) {
                    if (hiz_derece_tut == 0)
                        hiz_derece_tut = -2;
                    if (hiz_derece_tut <= 10)
                        hiz_derece_tut = hiz_derece_tut + 2;
                    else if (hiz_derece_tut <= 20)
                        hiz_derece_tut = hiz_derece_tut + 4;
                    else if (hiz_derece_tut <= 30)
                        hiz_derece_tut = hiz_derece_tut + 7;
                    else if (hiz_derece_tut <= 40)
                        hiz_derece_tut = hiz_derece_tut + 9;
                    else if (hiz_derece_tut <= 50)
                        hiz_derece_tut = hiz_derece_tut + 12;
                    else if (hiz_derece_tut <= 60)
                        hiz_derece_tut = hiz_derece_tut + 14;
                    else if (hiz_derece_tut <= 70)
                        hiz_derece_tut = hiz_derece_tut + 17;
                    else if (hiz_derece_tut <= 80)
                        hiz_derece_tut = hiz_derece_tut + 19;
                    else if (hiz_derece_tut <= 90)
                        hiz_derece_tut = hiz_derece_tut + 22;
                    else if (hiz_derece_tut <= 100)
                        hiz_derece_tut = hiz_derece_tut + 24;
                    else if (hiz_derece_tut <= 110)
                        hiz_derece_tut = hiz_derece_tut + 27;
                    else if (hiz_derece_tut <= 120)
                        hiz_derece_tut = hiz_derece_tut + 29;
                    else if (hiz_derece_tut <= 130)
                        hiz_derece_tut = hiz_derece_tut + 31;
                    else if (hiz_derece_tut <= 140)
                        hiz_derece_tut = hiz_derece_tut + 33;
                    else if (hiz_derece_tut <= 150)
                        hiz_derece_tut = hiz_derece_tut + 35;
                    else if (hiz_derece_tut <= 160)
                        hiz_derece_tut = hiz_derece_tut + 38;
                    else if (hiz_derece_tut <= 170)
                        hiz_derece_tut = hiz_derece_tut + 40;
                    else if (hiz_derece_tut <= 180)
                        hiz_derece_tut = hiz_derece_tut + 42;
                    else if (hiz_derece_tut <= 190)
                        hiz_derece_tut = hiz_derece_tut + 44;
                    else if (hiz_derece_tut <= 200)
                        hiz_derece_tut = hiz_derece_tut + 46;
                    else if (hiz_derece_tut <= 210)
                        hiz_derece_tut = hiz_derece_tut + 48;
                    else if (hiz_derece_tut <= 220)
                        hiz_derece_tut = hiz_derece_tut + 50;
                    else
                        hiz_derece_tut =270;
                }
                else
                {
                    hiz_derece_tut = 0;
                }
                
                


                float hiz_derece = hiz_derece_tut;
                hiz_pictureBox1.Image = Image.FromFile("D:\\images\\hiz_ibre.png");

                //float derece = 10.0f;
                Bitmap hbitmap = new Bitmap(hiz_pictureBox2.Image.Width, hiz_pictureBox2.Image.Height);
                Graphics grafik = Graphics.FromImage(hbitmap);
                grafik.TranslateTransform((float)hbitmap.Width / 2, (float)hbitmap.Height / 2);
                grafik.RotateTransform(hiz_derece);
                grafik.TranslateTransform(-(float)hbitmap.Width / 2, -(float)hbitmap.Height / 2);
                grafik.InterpolationMode = InterpolationMode.HighQualityBicubic;
                grafik.DrawImage(hiz_pictureBox1.Image, new Point(0, 0));
                grafik.Dispose();
                hiz_pictureBox2.Image = hbitmap;



                //akım---------------------------
                Bitmap akimBitmap;

                akimBitmap = (Bitmap)akim_pictureBox2.Image;

                //akimBitmap.RotateFlip(RotateFlipType.Rotate90FlipXY);

                akim_pictureBox2.Image = akimBitmap;
                this.akim_pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;

                int akim_tut = 0;
                foreach (char c in lbl_anlik_akim.Text)
                {
                    if (char.IsDigit(c))
                    {
                        akim_tut++;
                    }
                }


                string akim_deger;
                float akim_derece_tut;
                akim_deger = (lbl_anlik_akim.Text.Substring(0, akim_tut));
                //d.Text = akim_deger;
                akim_derece_tut = float.Parse(akim_deger);
              
                if (akim_derece_tut >= 0 )
                {
                    if (akim_derece_tut == 0)
                        akim_derece_tut = -2;
                    if (akim_derece_tut <= 5)
                        akim_derece_tut = akim_derece_tut + 4;
                    else if (akim_derece_tut <= 10)
                        akim_derece_tut = akim_derece_tut + 7;
                    else if (akim_derece_tut <= 15)
                        akim_derece_tut = akim_derece_tut + 12;
                    else if (akim_derece_tut <= 20)
                        akim_derece_tut = akim_derece_tut + 15;
                    else if (akim_derece_tut <= 25)
                        akim_derece_tut = akim_derece_tut + 20;
                    else if (akim_derece_tut <= 30)
                        akim_derece_tut = akim_derece_tut + 24;
                    else if (akim_derece_tut <= 35)
                        akim_derece_tut = akim_derece_tut + 29;
                    else if (akim_derece_tut <= 40)
                        akim_derece_tut = akim_derece_tut + 33;
                    else if (akim_derece_tut <= 45)
                        akim_derece_tut = akim_derece_tut + 37;
                    else if (akim_derece_tut <= 50)
                        akim_derece_tut = akim_derece_tut + 41;
                    else if (akim_derece_tut <= 55)
                        akim_derece_tut = akim_derece_tut + 45;
                    else if (akim_derece_tut <= 60)
                        akim_derece_tut = akim_derece_tut + 49;
                    else if (akim_derece_tut <= 65)
                        akim_derece_tut = akim_derece_tut + 54;
                    else if (akim_derece_tut <= 70)
                        akim_derece_tut = akim_derece_tut + 58;
                    else if (akim_derece_tut <= 75)
                        akim_derece_tut = akim_derece_tut + 63;
                    else if (akim_derece_tut <= 80)
                        akim_derece_tut = akim_derece_tut + 67;
                    else if (akim_derece_tut <= 85)
                        akim_derece_tut = akim_derece_tut + 72;
                    else if (akim_derece_tut <= 90)
                        akim_derece_tut = akim_derece_tut + 76;
                    else if (akim_derece_tut <= 95)
                        akim_derece_tut = akim_derece_tut + 80;
                    else if (akim_derece_tut <= 100)
                        akim_derece_tut = akim_derece_tut + 85;
                    else if (akim_derece_tut <= 105)
                        akim_derece_tut = akim_derece_tut + 90;
                    else if (akim_derece_tut <= 110)
                        akim_derece_tut = akim_derece_tut + 94;
                    else if (akim_derece_tut <= 115)
                        akim_derece_tut = akim_derece_tut + 98;
                    else if (akim_derece_tut <= 120)
                        akim_derece_tut = akim_derece_tut + 102;
                    else if (akim_derece_tut <= 125)
                        akim_derece_tut = akim_derece_tut + 107;
                    else if (akim_derece_tut <= 130)
                        akim_derece_tut = akim_derece_tut + 112;
                    else if (akim_derece_tut <= 135)
                        akim_derece_tut = akim_derece_tut + 116;
                    else if (akim_derece_tut <= 140)
                        akim_derece_tut = akim_derece_tut + 121;
                    
                    else
                        akim_derece_tut = 261;
                }
                else
                {
                    akim_derece_tut = 0;
                }
                



                float akim_derece = akim_derece_tut;
                akim_pictureBox1.Image = Image.FromFile("D:\\images\\akim_ibre.png");

                //float derece = 10.0f;
                Bitmap abitmap = new Bitmap(akim_pictureBox2.Image.Width, akim_pictureBox2.Image.Height);
                Graphics agrafik = Graphics.FromImage(abitmap);
                agrafik.TranslateTransform((float)abitmap.Width / 2, (float)abitmap.Height / 2);
                agrafik.RotateTransform(akim_derece);
                agrafik.TranslateTransform(-(float)abitmap.Width / 2, -(float)abitmap.Height / 2);
                agrafik.InterpolationMode = InterpolationMode.HighQualityBicubic;
                agrafik.DrawImage(akim_pictureBox1.Image, new Point(0, 0));
                agrafik.Dispose();
                akim_pictureBox2.Image = abitmap;


                //gerilimm----------------

                Bitmap gerilimBitmap;

                gerilimBitmap = (Bitmap)gerilim_pictureBox2.Image;

                gerilimBitmap.RotateFlip(RotateFlipType.Rotate90FlipXY);

                gerilim_pictureBox2.Image = gerilimBitmap;
                this.gerilim_pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;

                int gerilim_tut = 0;
                foreach (char c in lbl_bat.Text)
                {
                    if (char.IsDigit(c))
                    {
                        gerilim_tut++;
                    }
                }


                string gerilim_deger;
                float gerilim_derece_tut;
                gerilim_deger = (lbl_bat.Text.Substring(0, gerilim_tut));
               // d.Text = gerilim_deger;
                gerilim_derece_tut = float.Parse(gerilim_deger);

                if (gerilim_derece_tut >=60)
                {
                   
                     if (gerilim_derece_tut <= 65)
                        gerilim_derece_tut = (gerilim_derece_tut*-1) +53;
                    else if (gerilim_derece_tut <= 70)
                        gerilim_derece_tut = (gerilim_derece_tut * -1) + 48;
                    else if (gerilim_derece_tut <= 75)
                        gerilim_derece_tut = (gerilim_derece_tut * -1) + 40;
                    else if (gerilim_derece_tut <= 80)
                        gerilim_derece_tut = (gerilim_derece_tut * -1) + 35;
                    else if (gerilim_derece_tut <= 85)
                        gerilim_derece_tut = (gerilim_derece_tut * -1) + 30;
                    else if (gerilim_derece_tut <= 90)
                        gerilim_derece_tut = (gerilim_derece_tut * -1) + 24;
                    else if (gerilim_derece_tut <= 95)
                        gerilim_derece_tut = (gerilim_derece_tut * -1) + 15;
                    else if (gerilim_derece_tut <= 100)
                        gerilim_derece_tut = (gerilim_derece_tut * -1) + 10;
                    else if (gerilim_derece_tut <= 105)
                        gerilim_derece_tut = (gerilim_derece_tut * -1) + 5;
                    else if (gerilim_derece_tut <= 110)
                        gerilim_derece_tut = (gerilim_derece_tut * -1) -2;
                   

                    else
                        gerilim_derece_tut =-112;
                }
                else
                {
                    gerilim_derece_tut =0;
                }
                



                float gerilim_derece = gerilim_derece_tut;
                gerilim_pictureBox1.Image = Image.FromFile("D:\\images\\gerilim_ibre.png");

                //float derece = 10.0f;
                Bitmap gbitmap = new Bitmap(gerilim_pictureBox2.Image.Width, gerilim_pictureBox2.Image.Height);
                Graphics ggrafik = Graphics.FromImage(gbitmap);
                ggrafik.TranslateTransform((float)gbitmap.Width / 2, (float)gbitmap.Height / 2);
                ggrafik.RotateTransform(gerilim_derece);
                ggrafik.TranslateTransform(-(float)gbitmap.Width / 2, -(float)gbitmap.Height / 2);
                ggrafik.InterpolationMode = InterpolationMode.HighQualityBicubic;
                ggrafik.DrawImage(gerilim_pictureBox1.Image, new Point(0, 0));
                ggrafik.Dispose();
                gerilim_pictureBox2.Image = gbitmap;




                //sicaklik----------------

                Bitmap sicaklikBitmap;

                sicaklikBitmap = (Bitmap)sicak_pictureBox2.Image;

                sicaklikBitmap.RotateFlip(RotateFlipType.Rotate90FlipXY);

                sicak_pictureBox2.Image = sicaklikBitmap;
                this.sicak_pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;

                int sicaklik_tut = 0;
                foreach (char c in lbl_max_sic.Text)
                {
                    if (char.IsDigit(c))
                    {
                        sicaklik_tut++;
                    }
                }


                string sicaklik_deger;
                float sicaklik_derece_tut;
              sicaklik_deger = (lbl_max_sic.Text.Substring(0, sicaklik_tut));
                // t.Text =sicaklik_deger;
                sicaklik_derece_tut = float.Parse(sicaklik_deger);

                if (sicaklik_derece_tut >= 0)
                {
                    if (sicaklik_derece_tut == 0)
                        sicaklik_derece_tut = -4;
                    if (sicaklik_derece_tut <= 5)
                        sicaklik_derece_tut = sicaklik_derece_tut + 4;
                    else if (sicaklik_derece_tut <= 10)
                        sicaklik_derece_tut = sicaklik_derece_tut + 7;
                    else if (sicaklik_derece_tut <= 15)
                        sicaklik_derece_tut = sicaklik_derece_tut + 12;
                    else if (sicaklik_derece_tut <= 20)
                        sicaklik_derece_tut = sicaklik_derece_tut + 15;
                    else if (sicaklik_derece_tut <= 25)
                        sicaklik_derece_tut = sicaklik_derece_tut + 20;
                    else if (sicaklik_derece_tut <= 30)
                        sicaklik_derece_tut = sicaklik_derece_tut + 24;
                    else if (sicaklik_derece_tut <= 35)
                        sicaklik_derece_tut = sicaklik_derece_tut + 29;
                    else if (sicaklik_derece_tut <= 40)
                        sicaklik_derece_tut = sicaklik_derece_tut + 33;
                    else if (sicaklik_derece_tut <= 45)
                        sicaklik_derece_tut = sicaklik_derece_tut + 37;
                    else if (sicaklik_derece_tut <= 50)
                        sicaklik_derece_tut = sicaklik_derece_tut + 39;
                    else if (sicaklik_derece_tut <= 55)
                        sicaklik_derece_tut = sicaklik_derece_tut + 43;
                    else if (sicaklik_derece_tut <= 60)
                        sicaklik_derece_tut = sicaklik_derece_tut + 47;
                    else if (sicaklik_derece_tut <= 65)
                        sicaklik_derece_tut = sicaklik_derece_tut + 51;
                    else if (sicaklik_derece_tut <= 70)
                        sicaklik_derece_tut = sicaklik_derece_tut + 55;
                    else if (sicaklik_derece_tut <= 75)
                        sicaklik_derece_tut = sicaklik_derece_tut + 58;
                    else if (sicaklik_derece_tut <= 80)
                        sicaklik_derece_tut = sicaklik_derece_tut + 64;
                    else if (sicaklik_derece_tut <= 85)
                        sicaklik_derece_tut = sicaklik_derece_tut + 67;
                    else if (sicaklik_derece_tut <= 90)
                        sicaklik_derece_tut = sicaklik_derece_tut + 70;
                    else if (sicaklik_derece_tut <= 95)
                        sicaklik_derece_tut = sicaklik_derece_tut + 75;
                    else if (sicaklik_derece_tut <= 100)
                        sicaklik_derece_tut = sicaklik_derece_tut + 79;

                    else
                        sicaklik_derece_tut = 179;
                }
                else
                {
                    sicaklik_derece_tut = 0;
                }



                float sicaklik_derece = sicaklik_derece_tut;
                sicak_pictureBox1.Image = Image.FromFile("D:\\images\\sicak_ibre.png");

                //float derece = 10.0f;
                Bitmap sbitmap = new Bitmap(sicak_pictureBox2.Image.Width, sicak_pictureBox2.Image.Height);
                Graphics sgrafik = Graphics.FromImage(sbitmap);
                sgrafik.TranslateTransform((float)sbitmap.Width / 2, (float)sbitmap.Height / 2);
                sgrafik.RotateTransform(sicaklik_derece);
                sgrafik.TranslateTransform(-(float)sbitmap.Width / 2, -(float)sbitmap.Height / 2);
                sgrafik.InterpolationMode = InterpolationMode.HighQualityBicubic;
                sgrafik.DrawImage(sicak_pictureBox1.Image, new Point(0, 0));
                sgrafik.Dispose();
                sicak_pictureBox2.Image = sbitmap;


                


            }
            catch (Exception)
            {

            }

            
        }


        //. Maximum Akim Degerini Hesapla
        public float max_akim_bul(float gelen_akim)
        {

            if (gelen_akim > max_akim)
            {
                max_akim = gelen_akim;
            }
            return max_akim;

        }

        //. Seri porttan timer ile veri oku 
        private void serial_timer_Tick(object sender, EventArgs e)
        {
            try
            {
                String data_read;
                data_read = serialPort1.ReadLine();
                //. Okunan veriyi ekrana islemek uzere fonksiyona gonder.
                lbl_test.Text = data_read;
                update_screen(data_read);

            }
            catch (Exception)
            {
                
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //. Seri Baglantiyi Kapat
                serial_timer.Stop();
            serialPort1.Close();
            
            btn_close.Enabled = false;
            btn_open.Enabled = true;
            cb_balance.Enabled = false;
            cb_farlar.Enabled = false;
            cb_isiklandirma.Enabled = false;
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;

            lbl_status.Text = "BAĞLANTI KESİLDİ";
            lbl_status.ForeColor = System.Drawing.Color.Red;
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label3_Enter(object sender, EventArgs e)
        {

        }
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }
        //. ############################ CAR REMOTE CONTROL PARAMETERS ######################################
        private void cb_balance_CheckedChanged(object sender, EventArgs e)
        {
 
            if (cb_balance.Checked)
            {
                    lbl_balance.Text = "Açık";
                    lbl_balance.ForeColor = System.Drawing.Color.Green;

                    serialPort1.Write("D1");
            }
            else
            {
                lbl_balance.Text = "Kapalı";
                lbl_balance.ForeColor = System.Drawing.Color.Red;

                serialPort1.Write("D0");
            }
        }

        private void cb_farlar_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_farlar.Checked)
            {
                lbl_farlar.Text = "Açık";
                lbl_farlar.ForeColor = System.Drawing.Color.Green;
                serialPort1.Write("F1");
            }
            else
            {
                lbl_farlar.Text = "Kapalı";
                lbl_farlar.ForeColor = System.Drawing.Color.Red;
                serialPort1.Write("F0");
            }
        }

        private void cb_isiklandirma_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_isiklandirma.Checked)
            {
                lbl_isiklandirma.Text = "Açık";
                lbl_isiklandirma.ForeColor = System.Drawing.Color.Green;
                serialPort1.Write("L1");
            }
            else
            {
                lbl_isiklandirma.Text = "Kapalı";
                lbl_isiklandirma.ForeColor = System.Drawing.Color.Red;
                serialPort1.Write("L0");
            }
        }
        //.##################################################################################################

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //. When the form closed.. Put best lap time and best lap number to end of the data file.
            DosyayaEkle(dosya_adi, "  ");
            DosyayaEkle(dosya_adi, "  ");
            data_saved = "En İyi Tur\tTarih / Saat\t\tEn İyi Tur Süresi\t\t";
            DosyayaEkle(dosya_adi, data_saved);
            data_saved = "------\t\t-------------------\t-----------";
            DosyayaEkle(dosya_adi, data_saved);
            data_saved = _bestLap.ToString() + ". Tur\t\t" + lbl_date.Text + " " + lbl_time.Text + "\t" + lbl_bestLapTime.Text + "\n\n";
            DosyayaEkle(dosya_adi, data_saved);
            DosyayaEkle(dosya_adi, "  ");
            DosyayaEkle(dosya_adi, "  ");
            data_saved = "\n\nToplam Tur\tTarih / Saat\t\tToplam Tur Süresi\t\t";
            DosyayaEkle(dosya_adi, data_saved);
            data_saved = "------\t\t-------------------\t-----------";
            DosyayaEkle(dosya_adi, data_saved);
            data_saved = lbl_total_lap.Text + " Tur\t\t" + lbl_date.Text + " " + lbl_time.Text + "\t" + lbl_total_time.Text + "\n\n";
            DosyayaEkle(dosya_adi, data_saved);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void lbl_anlik_akim_Click(object sender, EventArgs e)
        {

        }

        private void Marquee_timer_Tick(object sender, EventArgs e)
        {
            //. Marquee settings.
            int minLeft = -label1.Width;
            this.label1.Location = new System.Drawing.Point(x_pos, y_pos);
            x_pos -= 1;


            if (x_pos <= minLeft) x_pos = groupBox10.Width;


        }

        private void lbl_time_left_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form Baglati_Ayarlari = new Form();
            Baglati_Ayarlari.MdiParent = this;
            Baglati_Ayarlari.Show();
        }

        private void lbl_hiz_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_max_akim_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void progress_Click(object sender, EventArgs e)
        {
            
        }

        private void sicak_pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private delegate void SetTextDeleg(string text);
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {

                string data_test = "";
                data_test = serialPort1.ReadLine();

                this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data_test });
            }
            catch (Exception)
            {

            }

        }

        private void si_DataReceived(string data)
        {
            lbl_test.Text = data;
            update_screen(data);
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void system_time_Tick(object sender, EventArgs e)
        {
            //. Read System's date and time.
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            lbl_date.Text = DateTime.Now.ToShortDateString();
        }

        private void list_krono_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void btn_laptime_Click(object sender, EventArgs e)
        {
            _counter++;

            // ---------------------------- Best Lap / LapTime ---------------------------------
            if (_bh > _h)
            {
                _bh = _h;
                _bm = _m;
                _bs = _s;
                _bms = _ms;
                _bestLap = _counter;


            }
            else if (_bm > _m)
            {
                _bm = _m;
                _bs = _s;
                _bms = _ms;
                _bestLap = _counter;
            }
            else if (_bs > _s)
            {

                _bestLap = _counter;
                _bs = _s;
                _bms = _ms;
            }
            else if (_bms > _ms && _bs == _s)
            {
                _bms = _ms;
                _bestLap = _counter;
            }


            lbl_bestLapTime.Text = _bh.ToString() + ":" + _bm.ToString() + ":" + _bs.ToString() + "." + _bms.ToString();
            lbl_bestLap.Text = _bestLap.ToString();

            // ---------------------------- List Auto Scroll ---------------------------------
            list_krono.Items.Add(_counter.ToString() + ".\t" + lbl_krono.Text);
            list_krono.TopIndex = list_krono.Items.Count - 1;
                
            lbl_total_lap.Text = _counter.ToString();

            // ----------------------------- Total Time --------------------------------------
            _th += _h;
            _tm += _m;
            _ts += _s;
            _tms += _ms;
            

            if (_tms > 9)
            {
                _ts++;
                _tms = _tms % 10;
               
                if(_ts > 59)
                {
                    _tm++;
                    _ts = _ts % 60;
                    if(_tm > 59)
                    {
                        _th++;
                        _tm = _tm % 60;
                    }
                }
            }
            if (_ts > 59)
            {
                _tm++;
                if (_tm > 59)
                {
                    _th++;
                }
            }
            if (_tm > 59)
            {
                _th++;
            }

            // ----------------------------- Remaining Time --------------------------------------
            int kalan = 0;
 
            _rm = Math.DivRem(_rtms, 600, out kalan);
            _rs = Math.DivRem(kalan, 10, out kalan);
            _rms = kalan % 10;
            _remain_counter = 30 - _counter;
            if(_remain_counter <= 0)
            {
                _remain_counter = 0;
            }

            


            lbl_time_left.Text = _rm.ToString() + ":" + _rs.ToString() + "." + _rms.ToString();
            lbl_tour_left.Text = _remain_counter.ToString();

            
            
            



            //. Write current lap time to log file.
            string data_saved = "";
  

            data_saved = _counter.ToString() + ". Tur\t\t" + lbl_date.Text + " " + lbl_time.Text + "\t" + lbl_krono.Text;

            DosyayaEkle(dosya_adi, data_saved);



            //. Reset the chronometer.

            _h = 0;
            _m = 0;
            _s = 0;
            _ms = 0;
            lbl_krono.Text = _h.ToString() + ":" + _m.ToString() + ":" + _s.ToString() + "." + _ms.ToString();
            lbl_total_time.Text = _th.ToString() + ":" + _tm.ToString() + ":" + _ts.ToString() + "." + _tms.ToString();




        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            //. WHen the clear button clicked reset the current values
            list_krono.Items.Clear();
            _counter = 0;

            _th = 0;
            _tm = 0;
            _ts = 0;
            _tms = 0;
            _bh = 999;
            _bm = 999;
            _bs = 999;
            _bms = 999;
            _bestLap = 0;

            lbl_total_time.Text = _th.ToString() + ":" + _tm.ToString() + ":" + _ts.ToString() + "." + _tms.ToString();
            lbl_bestLapTime.Text = "0:0:0.0";
            lbl_bestLap.Text = _bestLap.ToString();

            lbl_total_lap.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {   
            //. When the Chronometer Start button clicked. 
            //. Start Chronometer 
            if (_chronostart)
            {

                btn_laptime.Enabled = false;
                btn_krono_basla.Text = "Başlat";
                _chronostart = false;
                kronometre.Stop();
            }
            //. If Chronometer already started.. Stop it ^^
            else {

                btn_laptime.Enabled = true;
                btn_krono_basla.Text = "Durdur";
                _chronostart = true;
                kronometre.Start();
            }
        }

        private void btn_krono_durdur_Click(object sender, EventArgs e)
        {
            //. When the reset button clicked.. Reset Chronometer.
            _h = 0;
            _m = 0;
            _s = 0;
            _ms = 0;
            _rh = 0;
            _rm = 0;
            _rs = 0;
            _rms = 0;
            _rtms = 39000;
            lbl_krono.Text = _h.ToString() + ":" + _m.ToString() + ":" + _s.ToString() + "." + _ms.ToString();
            lbl_tour_left.Text = "30";
            lbl_time_left.Text = "65:00.0";
        }

        private void kronometre_Tick(object sender, EventArgs e)
        {
            //. Chronometer settings.
            _ms++;
            _rtms--;
            if(_ms > 9)
            {
                _s++;
                _ms = 0;
            }
            if(_s > 59)
            {
                _m++;
                _s = 0;
            }
            if(_m > 59)
            {
                _h++;
                _m = 0;
            }
            lbl_krono.Text = _h.ToString()+ ":" + _m.ToString() + ":" + _s.ToString() + "." + _ms.ToString();
        }

    }

}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySieuThi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {

            if (tbId.Text == "" || tbName.Text == "" || tbAge.Text == "")
            {
                MessageBox.Show("Thêm thất bại!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            else
            {
                dgvEmployee.Rows.Add(tbId.Text, tbName.Text, tbAge.Text, ckGender.Checked, pictureBox1.Image);
                MessageBox.Show("Bạn đã thêm thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentCell == null)
            {
                MessageBox.Show("Xoá thất bại!", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            else
            {
                int idx = dgvEmployee.CurrentCell.RowIndex;
                dgvEmployee.Rows.RemoveAt(idx);
                MessageBox.Show("Bạn đã xoá thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "" || tbName.Text == "" || tbAge.Text == "" || dgvEmployee.CurrentCell == null)
            {
                MessageBox.Show("Sửa thất bại", "THÔNG BÁO", MessageBoxButtons.OK);

            }
            else
            {
                int idx = dgvEmployee.CurrentCell.RowIndex;
                dgvEmployee.Rows[idx].Cells[0].Value = tbId.Text;
                dgvEmployee.Rows[idx].Cells[1].Value = tbName.Text;
                dgvEmployee.Rows[idx].Cells[2].Value = tbAge.Text;
                dgvEmployee.Rows[idx].Cells[3].Value = ckGender.Checked;
                dgvEmployee.Rows[idx].Cells[4].Value = pictureBox1.Image;
                MessageBox.Show("Sửa thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filepath = null; OpenFileDialog ofdImages = new OpenFileDialog(); PictureBox objpt = new PictureBox(); if (ofdImages.ShowDialog() == DialogResult.OK) { filepath = ofdImages.FileName; }
            MessageBox.Show("Upload thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
            pictureBox1.Image = Image.FromFile(filepath.ToString());
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }
    }
}

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

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello, World!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtInput.Text))
            {
                // AppendText 追加内容，不会覆盖旧文字，加上换行
                rtbShow.AppendText(txtInput.Text + Environment.NewLine);

                // 清空输入框，方便下次输入
                txtInput.Clear();
                //光标回到输入框
                txtInput.Focus();
            }
    }
}

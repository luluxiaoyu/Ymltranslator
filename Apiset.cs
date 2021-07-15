using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdx_ymltranslator
{
    public partial class Apiset : Form
    {
        public Apiset()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTranslator.appid = textBox1.Text;
            FrmTranslator.sec = textBox2.Text;
            MessageBox.Show("已保存！每一次都要设置一次哦！", "保存成功！" , MessageBoxButtons.OK,MessageBoxIcon.Information );
            this.Close();
        }

        private void Apiset_Load(object sender, EventArgs e)
        {
            textBox1.Text = FrmTranslator.appid;
            textBox2.Text = FrmTranslator.sec;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OutPut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.sfdSave.Filter = "Excel 工作簿(*.xlsx)|*.xlsx|txt文本文件(*.txt)|*.txt";//设置保存类型
                this.sfdSave.FilterIndex = 2;//设置默认保存类型(索引值从1开始)
                sfdSave.AddExtension = true;//自动添加扩展名
                DialogResult result = this.sfdSave.ShowDialog();
                if (result == DialogResult.OK)//点击了保存
                {
                    string filename = sfdSave.FileName.ToString();//获取保存文件名
                    string fileext = filename.Substring(filename.LastIndexOf(".") + 1);//获取文件扩展名
                    MessageBox.Show("文件保存类型为：\n" + fileext);
                    if (fileext == "xlsx")
                    {
                        MessageBox.Show("文件保存类型为xlsx的相应处理内容");
                    }
                    else if (fileext == "txt")
                    {
                        MessageBox.Show("文件保存类型为txt的相应处理内容");
                    }
                    return;
                }
                else if (result == DialogResult.Cancel)//点击了取消
                {
                    MessageBox.Show("点击了取消");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("出现了异常\n异常信息:" + ex.Message + "\n");
                return;
            }
        }
    }
}

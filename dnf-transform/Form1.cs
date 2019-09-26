using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dnf_transform
{
    public partial class Form1 : Form
    {
        private List<BaseModel> baseModelList = new List<BaseModel>();
        private string ctContent = "";
        private string fileName = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCt_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string ext = ofd.FileName.Split('.')[ofd.FileName.Split('.').Length - 1];
            if (ext != "ctm")
            {
                MessageBox.Show("请选择以ctm格式结尾的模板文件");
                return;
            }
            fileName = ofd.SafeFileName.Split('.')[0];
            string path = ofd.FileName;
            ctContent = File.ReadAllText(path, Encoding.UTF8);

            this.lbCt.Text = "读取成功";
        }

        private void BtnBase_Click(object sender, EventArgs e)
        {
            baseModelList = new List<BaseModel>();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string path = ofd.FileName;
            string[] fileContent = File.ReadAllLines(path,Encoding.Default);
            fileContent = fileContent.Where((item) => {
                return item.Contains("常量");
            }).ToArray();
            for (int i = 0; i < fileContent.Length; i++)
            {
                var temp = fileContent[i];
                temp = temp.Replace(".常量","").Replace("7度_获取", "").Replace(",", "").Replace("”", "|").Replace("“", "|").Trim();
                var strArr = temp.Split('|').Where((item)=> { return !string.IsNullOrWhiteSpace(item); }).ToArray();
                var name = strArr[0];
                var address = strArr[1];
                BaseModel bm = new BaseModel
                {
                    Name = name,
                    Address = address
                };
                baseModelList.Add(bm);
            }
            this.lbBase.Text = "读取成功";
        }

        private void BtnTransform_Click(object sender, EventArgs e)
        {
            while (new Regex("{{(.+)}}").Match(ctContent).Success)
            {
                Regex reg = new Regex("{{(.+)}}");
                Match match = reg.Match(ctContent);
                string name = match.Groups[1].Value;
                string address = baseModelList.Where((item) =>
                {
                    return item.Name == name;
                }).FirstOrDefault().Address;
                reg = new Regex("{{" + name + "}}");
                ctContent = reg.Replace(ctContent, address);
            }

            // string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            SaveFileDialog file = new SaveFileDialog();//定义新的文件保存位置控件
            file.Filter = "ct files|*.ct";//设计文件后缀的过滤
            file.FileName = fileName;
            if (file.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(file.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);//新建或者打开文件

                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(ctContent);
                sw.Close();
            }
        }
    }
}

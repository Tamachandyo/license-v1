using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicenseManager1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnValidate.Click += new EventHandler(btnValidate_Click);
            btnGenerate.Click += new EventHandler(btnGenerate_Click);  // 生成ボタンのクリックイベントも追加
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string licenseKey = txtLicenseKey.Text;
            if (ValidateLicense(licenseKey))
            {
                lblResult.Text = "ライセンスが有効です。";
                lblResult.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblResult.Text = "ライセンスが無効です。";
                lblResult.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string newLicenseKey = GenerateRandomLicenseKey();
            txtLicenseKey.Text = newLicenseKey;
            lblResult.Text = "新しいライセンスキーが生成されました。";
            lblResult.ForeColor = System.Drawing.Color.Blue;
        }

        private bool ValidateLicense(string key)
        {
            // ここでライセンスキーの検証ロジックを実装します
            // 簡単な例として、特定のキーが有効と見なされます
            return key == "VALID-KEY-1234";
        }

        private string GenerateRandomLicenseKey()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 16)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}

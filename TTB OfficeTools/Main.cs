using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTB_OfficeTools
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 텍스트박스1의 데이터 가져오기
            string textBox1Text = textBox1.Text;

            // 데이터 변환
            List<string> convertedData = ConvertData(textBox1Text);

            // 변환된 데이터를 텍스트박스2에 넣기
            textBox2.Clear();
            foreach (var data in convertedData)
            {
                textBox2.AppendText(data + Environment.NewLine);
            }
        }

        private List<string> ConvertData(string inputData)
        {
            // 입력 데이터를 구분자로 분리하여 제목과 내용의 쌍으로 구성된 리스트 생성
            string[] dataArray = inputData.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            List<string> pairs = new List<string>();

            for (int i = 0; i < dataArray.Length; i += 2)
            {
                string title = dataArray[i];
                string content = dataArray[i + 1];

                pairs.Add(title + "\t" + content);
            }

            return pairs;
        }

        private void about_bt_Click(object sender, EventArgs e)
        {
            AboutBox1 f = new AboutBox1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace pchmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //string _yturl = "https://www.youtube.com/watch?v=fC2vaR-Ieow&feature=youtu.be";
        //public string VideoId
        //{
        //get
        //{
        //var ytMatch = new Regex(@"youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)").Match(_yturl);
        //vreturn ytMatch.Success ? ytMatch.Groups[1].Value : String.Empty;
        //}
        //}

    private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //webBrowser1.Navigate($"http://youtube.com/v/{VideoId}?version=3");
        }

        
    }
}

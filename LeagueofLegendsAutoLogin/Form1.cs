using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AutoItX3Lib;

namespace LeagueofLegendsAutoLogin
{
    public partial class Form1 : Form
    {
        Autolt Cautoit = new Autolt();
        public Form1()
        {
            InitializeComponent();
        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("time.txt"))
                {
                    String line = sr.ReadToEnd();
                    int time = int.Parse(line);
                    try
                    {
                        using (StreamReader sr2 = new StreamReader("pass.txt"))
                        {
                            String pass = sr2.ReadToEnd();
                            Process.Start("C:\\Program Files (x86)\\Garena\\Garena\\Garena.exe");
                            Thread.Sleep(time);
                            Process.Start("C:\\Program Files (x86)\\Garena\\Garena\\Garena.exe");
                            Thread.Sleep(800);
                            SendKeys.SendWait(pass);
                            Thread.Sleep(300);
                            SendKeys.SendWait("{ENTER}");
                        }
                    }
                    catch(IOException)
                    {
                        Console.WriteLine("Không mật khẩu");
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Không thời gian");
            }
            Thread.Sleep(10000);
            Cautoit.mClick("LEFT", 1070, 273, 5, -1); // chọn liên minh huyền thoại
            Thread.Sleep(2000);
            Cautoit.mClick("LEFT", 744, 746, 2, -1); // chọn chơi
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

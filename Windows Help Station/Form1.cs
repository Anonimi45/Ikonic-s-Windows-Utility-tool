using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Diagnostics;

namespace Windows_Help_Station
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/c del /q /s %temp%\\*.*");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/c del /q /s %temp%\\*.*");
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Process.Start("eventvwr.msc");
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            Process.Start("services.msc");
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Process.Start("powershell", "-Command \"irm 'https://christitus.com/win' | iex\"");
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Process.Start("cleanmgr.exe", "/d C");
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            Process.Start("taskmgr.exe");
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Process.Start("cmd.exe", "/k powershell -Command \"$updates=(New-Object -ComObject Microsoft.Update.Session).CreateUpdateSearcher().Search('IsInstalled=0').Updates; if ($updates.Count -gt 0) { 'Updates found'; $updates | ForEach-Object { $_.Title }; $response = Read-Host 'Do you want to install these updates? (y/n)'; if ($response -eq 'y') { $updates | ForEach-Object { $_.AcceptEula(); $_.Install() }; 'Updates installed' } else { 'No updates were installed' } } else { 'No updates found' }\"");

        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {

        }
    }
}

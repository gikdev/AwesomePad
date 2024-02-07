using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Awesome
{
    public partial class Form1 : Form
    {
        private string currentFilePath = "";
        private bool wordWrapEnabled = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void itemOpen_Click(object sender, EventArgs e)
        {
            if (dialogOpen.ShowDialog() == DialogResult.OK)
            {
                currentFilePath = dialogOpen.FileName;
                var content = File.ReadAllText(currentFilePath);
                txtMain.Text = content;
            }
            else
            {
                MessageBox.Show("An error occured while opening your file. Please try again.", "Error; Try Again!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void itemSave_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(currentFilePath))
            {
                File.WriteAllText(currentFilePath, txtMain.Text);
            }
        }

        private void itemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void itemWordWrap_Click(object sender, EventArgs e)
        {
            wordWrapEnabled = !wordWrapEnabled;
            txtMain.WordWrap = wordWrapEnabled;
            itemWordWrap.Checked = wordWrapEnabled;
        }

        private void itemThemeDark_Click(object sender, EventArgs e)
        {
            uncheckAllThemes();
            itemThemeDark.Checked = true;
            txtMain.ForeColor = Color.FromArgb(255, 248, 249, 250);
            txtMain.BackColor = Color.FromArgb(255, 33, 37, 41);
        }

        private void itemThemeLight_Click(object sender, EventArgs e)
        {
            uncheckAllThemes();
            itemThemeLight.Checked = true;
            txtMain.BackColor = Color.FromArgb(255, 248, 249, 250);
            txtMain.ForeColor = Color.FromArgb(255, 33, 37, 41);
        }

        private void itemThemeHacker_Click(object sender, EventArgs e)
        {
            uncheckAllThemes();
            itemThemeHacker.Checked = true;
            txtMain.ForeColor = Color.FromArgb(255, 105, 219, 124);
            txtMain.BackColor = Color.FromArgb(255, 33, 37, 41);
        }

        private void itemThemeJoker_Click(object sender, EventArgs e)
        {
            uncheckAllThemes();
            itemThemeJoker.Checked = true;
            txtMain.ForeColor = Color.FromArgb(255, 105, 219, 124);
            txtMain.BackColor = Color.FromArgb(255, 94, 6, 116);
        }

        private void itemAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            itemWordWrap.Checked = wordWrapEnabled;
            txtMain.WordWrap = wordWrapEnabled;
            itemThemeLight_Click(null, null);
        }

        private void uncheckAllThemes()
        {
            itemThemeDark.Checked = false;
            itemThemeLight.Checked = false;
            itemThemeHacker.Checked = false;
            itemThemeJoker.Checked = false;
        }

        private void itemFont_Click(object sender, EventArgs e)
        {
            if (dialogFont.ShowDialog() == DialogResult.OK)
            {
                txtMain.Font = dialogFont.Font;
            }
        }
    }
    // dialogColorBg dialogColorText dialogFont dialogOpen dialogSave
}

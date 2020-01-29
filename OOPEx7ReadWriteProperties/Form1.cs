using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMADPartyStore;

namespace OOPEx7ReadWriteProperties
{
    public partial class Form1 : Form
    {
        private Balloon balloon;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                balloon = new Balloon();
                balloon.Color = txtColor.Text.Trim();
                balloon.Diameter = int.Parse(txtDiameter.Text);
                balloon.Height = int.Parse(txtHeight.Text);
            }
            catch(Exception ex)
            {
                balloon = null;
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (balloon == null)
            {
                lblBalloon.Text = "balloon is null";
                return;
            }
            lblBalloon.Text = $"Color: {balloon.Color}\n" +
                $"Height: {balloon.Height}\n" +
                $"Diameter: {balloon.Diameter}";
        }
    }
}

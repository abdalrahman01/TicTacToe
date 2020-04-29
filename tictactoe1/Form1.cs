using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SLUTPROJEKT
{
    public partial class StartPage : Form
    {
      
        public StartPage()
        {
            
            InitializeComponent();
        }

        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            minTB.Text = trackBar1.Minimum.ToString();
            maxTB.Text = trackBar1.Maximum.ToString();
            trackbarValue.Text = trackBar1.Value.ToString();
            if (trackBar1.Value < 5)
                streakn.Text = "3";
            else if (trackBar1.Value < 8)
                streakn.Text = "5";
            else
                streakn.Text = "7";
            
        }

        private void buttonsMouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.BlueViolet;
        }

        private void buttonsMouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.Black;
        }

        private void P2_Click(object sender, EventArgs e)
        {
            P2.Enabled = false;
            P2.FlatAppearance.BorderSize = 1;
            AI.Enabled = true;
            AI.FlatAppearance.BorderSize = 0;
          

        }

        private void AI_Click(object sender, EventArgs e)
        {
            AI.Enabled = false;
            AI.FlatAppearance.BorderSize = 1;
            P2.Enabled = true;
            P2.FlatAppearance.BorderSize = 0;
           
        }
        
        private void start_clicked(object sender, EventArgs e)
        {
            int choice = 2;
            if (AI.Enabled) choice = 2;
            else if (P2.Enabled) choice = 1;
                   

            PLAY form2 = new PLAY(trackBar1.Value,choice);
          
            
            form2.Show();
            
        }

     

        private void StartPage_Load(object sender, EventArgs e)
        {
            settings.Left = ClientSize.Width / 2 - settings.Width / 2;
            settings.Top = ClientSize.Height / 2 - settings.Height / 2;
           
        }
    }
}

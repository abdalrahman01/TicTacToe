using System;

using System.Drawing;
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
            //trackbar är för att bestämma storleken rutnät.
            // ex om det är 3 -> 3x3 plan
            minTB.Text = trackBar1.Minimum.ToString();
            maxTB.Text = trackBar1.Maximum.ToString();
            trackbarValue.Text = trackBar1.Value.ToString();
            
            //de if-statements är för att bestämma hur många i rad för att nån ska vinna 
            if (trackBar1.Value < 5)
                streakn.Text = "3";
            else if (trackBar1.Value < 8)
                streakn.Text = "5";
            else
                streakn.Text = "7";
            
        }

        private void buttonsMouseEnter(object sender, EventArgs e)
        {
            // det är lite design för the buttons on mainscreen
            Button button = (Button)sender;
            button.ForeColor = Color.BlueViolet;
        }

        private void buttonsMouseLeave(object sender, EventArgs e)
        {
            // det är lite design för the buttons on mainscreen 
            Button button = (Button)sender;
            button.ForeColor = Color.Black;
        }

        private void P2_Click(object sender, EventArgs e)
        {
            // det när trycker på så disablar jag the button och rita ett border runt om för att 
            // ska visa att den är vald
            // och enablar den andra 
            P2.Enabled = false;
            P2.FlatAppearance.BorderSize = 1;
            AI.Enabled = true;
            AI.FlatAppearance.BorderSize = 0;
          

        }

        private void AI_Click(object sender, EventArgs e)
        {
            // det när trycker på så disablar jag the button och rita ett border runt om för att 
            // ska visa att den är vald
            // och enablar den andra 
            AI.Enabled = false;
            AI.FlatAppearance.BorderSize = 1;
            P2.Enabled = true;
            P2.FlatAppearance.BorderSize = 0;
           
        }
        
        private void start_clicked(object sender, EventArgs e)
        {
            // choice är för att vilja mot vad du vill spela 
            // 2 för dig själv
            // 1 för datorn som motståndare 
            // default choice är 2 
            int choice = 2;
            // om ett button är disablad det betyder att den är vald
            if (AI.Enabled) choice = 2;
            else if (P2.Enabled) choice = 1;
                   

            // classen PLAY vilket är det andra fönstret 
            // den tar två args den första storleken på spelet (planen) den andra är motsåndare
            PLAY form2 = new PLAY(trackBar1.Value,choice);
            form2.Show();
            
        }

     

        private void StartPage_Load(object sender, EventArgs e)
        {
            // fixer positionen för inställningar så att de är i mitten av skärmen
            settings.Left = ClientSize.Width / 2 - settings.Width / 2;
            settings.Top = ClientSize.Height / 2 - settings.Height / 2;
           
        }
    }
}

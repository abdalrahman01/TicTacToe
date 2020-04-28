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
    public partial class PLAY : Form
    {
        Tictactoe tictactoe;
        int storlek, choice;

        public PLAY(int storlek, int choice)
        {
            this.storlek = storlek;
            this.choice = choice;
            InitializeComponent();
        }
        private void PLAY_Load(object sender, EventArgs e)
        {
           
            tictactoe = new Tictactoe(this);
            tictactoe.Create(storlek, new Point(0, 0));
            tictactoe.Play(choice,result);

        }

        

        
    }
       
}

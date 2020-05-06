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
        // definiera the tictactoe classen vilken är den viktigaste
        Tictactoe tictactoe;
      
        int storlek, choice;

        public PLAY(int storlek, int choice)
        {
            // de är två args som frågas efter när du vill definiera classen PLAY
            this.storlek = storlek;
            this.choice = choice;
            InitializeComponent();
        }

      

        private void PLAY_Load(object sender, EventArgs e)
        {
           // sätter ett värde för tictactoe 
           // den klassen tar args Form vilket säger till vilket fönster den klassen kommar vara med
            tictactoe = new Tictactoe(this);

            // method Create ritar planene och tar två args storleken och positionen i fönstret
            tictactoe.Create(storlek, new Point(0, 0));

            // method Play startat spelet och tar två args motsåndare och var resultat ska visas
            // i det fallet är resultat i en textbox
            tictactoe.Play(choice,result);

        }

        

        
    }
       
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SLUTPROJEKT
{
   
        class Tictactoe
        {
            public Form form;
            private List<List<Button>> buttons = new List<List<Button>>();
            private Dictionary<Point, bool> clickedButtons = new Dictionary<Point, bool>();
            public bool turn = true;
            private readonly int buttonSize = 40;
            public TextBox result;
            public int storlek;
            public Tictactoe(Form form)
            {
                this.form = form;
            }
            

            public void Create(int storlek, Point pos)
            {
            this.storlek = storlek;
                Panel Ground = new Panel();
                for (int i = 0; i < storlek; i++)
                {
                    List<Button> row = new List<Button>();
                    for (int l = 0; l < storlek; l++)
                    {
                        row.Add(new Button());
                    }
                    buttons.Add(row);
                }
                Ground.Location = pos;
                Ground.Size = new Size(storlek * buttonSize, storlek * buttonSize);
                form.Controls.Add(Ground);
                foreach (var row in buttons)
                {
                    foreach (var button in row)
                    {
                        Point coo = new Point(row.IndexOf(button), buttons.IndexOf(row));
                        button.Text = "";
                        button.Font = new Font("Lucida Handwriting", 12F);
                        button.Size = new Size(buttonSize, buttonSize);
                        button.Location = new Point((coo.X * buttonSize), (coo.Y * buttonSize));
                        button.BackColor = Color.Gainsboro;
                        button.FlatAppearance.BorderSize = 1;
                        button.FlatStyle = FlatStyle.Flat;
                        Ground.Controls.Add(button);
                    }

                }

            
            }
            public void Play(int choice, TextBox result)
            {
               this.result = result;
                // choice 1 or 2, 1 for AI and 2 for P2

                foreach (var row in buttons)
                {
                    foreach (var button in row)
                    {
                    if (choice == 2)
                    {
                        button.MouseUp += Button_MouseUp;
                        button.MouseEnter += MouserHoverEnter;
                        button.MouseLeave += MouserHoverLeave;
                    }
                    else if (choice == 1)
                    {
                        button.MouseUp += Button_mouseUp_AI;
                        button.MouseEnter += MouserHoverEnter;
                        button.MouseLeave += MouserHoverLeave;

                    }

                }
                }
            }

            private void MouserHoverLeave(object sender, EventArgs e)
            {
                Button button = (Button)sender;
                if(button.Enabled)
                    button.Text = "";
            }

            private void MouserHoverEnter(object sender, EventArgs e)
            {
                Button button = (Button)sender;
                if (button.Enabled)
                {
                    if (turn)
                        button.Text = "X";
                    else
                        button.Text = "O";
                }
            }

            private void Button_mouseUp_AI(object sender, MouseEventArgs e)
                {

                    Button button = (Button)sender;
                    if (turn)
                    {
                        button.Text = "X";
                        storeButton(button, turn);

                        turn = !turn;
                        button.Enabled = false;
                    }
                    if (!turn)
                    {
                        while (AllbuttonsEnabled() && !turn)
                        {

                            int index1 = new Random().Next(buttons[0].Count);
                            int index2 = new Random().Next(buttons[1].Count);
                            button = buttons[index1][index2];
                            if (button.Enabled)
                            {
                                new TimeSpan(0, 0, 2);
                                button.Text = "O";
                                // button.Font = new Font(button.Font.FontFamily, 16);
                                button.Enabled = false;
                            

                                turn = !turn;
                                storeButton(button, !turn);
                        

                        }
                            else continue;
                        }
                    }
                
                }
            private void Button_MouseUp(object sender, MouseEventArgs e)
                {

                    Button button = (Button)sender;
                    if (turn)
                    {
                        button.Text = "X";
                    }
                    else
                    {
                        button.Text = "O";
                    }

                    button.Enabled = false;
                    storeButton(button, turn);
            
                turn = !turn;
                
                }

      
            private void storeButton(Button button, bool turn)
                {
                    foreach (var row in buttons)
                    {
                        foreach (var item in row)
                        {
                            if (item == button)
                            {
                                Point point = new Point(row.IndexOf(item), buttons.IndexOf(row));
                                clickedButtons.Add(point, turn);
                                if (turn)
                                {
                                    result.AppendText(point.ToString() + " X");
                                }
                                else
                                {
                                    result.AppendText(point.ToString() + " O");
                                }
                            checkWin(button);

                            break;
                            }
                        }
                    }
                }

            private bool AllbuttonsEnabled()
                {
                    bool state = true;
                    int l = 0;
                    foreach (var row in buttons)
                    {
                        foreach (var item in row)
                        {
                            if (!item.Enabled) l++;
                        }
                    }
                    if (l == buttons[0].Count * buttons[1].Count)
                        state = false;
                    return state;
                }
            private void checkWin(Button button)
                {
                    bool won = false;
                    int streak;
                    if (storlek < 5) streak = 2;
                    else if (storlek < 8) streak = 3;
                    else streak = 4;
                
            

                    foreach (var item in clickedButtons)
                    {
                        int x = item.Key.X;
                        int y = item.Key.Y;
                        string Val = button.Text;
                        int l = 0;
                    // den kollar höger och vänster
                    if (l != streak)
                    {
                        for (int i = 0; i < streak; i++)
                        {
                            try
                            {
                                if (Val == buttons[y][x + i].Text && Val == buttons[y][x - i].Text)
                                {
                                    l++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            catch (Exception)
                            {

                                continue;
                            }
                        }
                    }
                    if (l == streak) won = true;
                    else l = 0;
                    // den kollar uppe-vänster och nere-höger
                    if (l != streak)
                    {
                        for (int i = 0; i < streak; i++)
                        {
                            try
                            {
                                if (Val == buttons[y+i][x + i].Text && Val == buttons[y-i][x - i].Text)
                                {
                                    l++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            catch (Exception)
                            {

                                continue;
                            }
                        }
                    }
                    if (l == streak) won = true;
                    else l = 0;
                    // den kollar uppe-höger och nere-vänster
                    if (l != streak)
                    {
                        for (int i = 0; i < streak; i++)
                        {
                            try
                            {
                                if (Val == buttons[y-i][x + i].Text && Val == buttons[y+i][x - i].Text)
                                {
                                    l++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            catch (Exception)
                            {

                                continue;
                            }
                        }
                    }
                    if (l == streak) won = true;
                    else l = 0;
                    //den kollar uppe och nere
                    if (l != streak)
                    {
                        for (int i = 0; i < streak; i++)
                        {
                            try
                            {
                                if (Val == buttons[y+i][x].Text && Val == buttons[y-i][x].Text)
                                {
                                    l++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            catch (Exception)
                            {

                                continue;
                            }
                        }
                    }


                    if (l == streak) won = true;
                

                
                }
                if (won) someOneWon();
            
                
                }
            private void someOneWon()
            {
                foreach (var row in buttons)
                {
                    foreach (var item in row)
                    {
                        item.Enabled = false;
                    }
                }
                string msg = "";
                if (turn) msg = "X WON!";
                else msg = "O WON!";
                MessageBoxButtons btns = MessageBoxButtons.YesNo;
                var msgbx= MessageBox.Show(msg,"Some one Won",btns);
                if (msgbx == DialogResult.Yes)
                {
                    form.Close();
                }
                else
                {
                    form.Close();
                }
            }
        }
}

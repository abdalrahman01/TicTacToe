using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace chess
{
    class CreateGame
    {
        public Point pos;
        private readonly int buttonSize = 40;
        public int storlek;
        public Form form;
        private List<List<Button>> buttons = new List<List<Button>>();
        public bool turn = true;
        public int length;
        private Dictionary<Point, string> clickedButtons = new Dictionary<Point, string>();
        public CreateGame(Form form, Point pos, int storlek, int length)
        {
            this.pos = pos;
            this.storlek = storlek;
            this.form = form;
            this.length = length;
        }
        public Size CreateTicTacToe()
        {
            Panel Ground = new Panel();
            Ground.BackColor = Color.FromArgb(255, 102, 102);
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
                    button.Size = new Size(buttonSize, buttonSize);
                    button.Location = new Point((coo.X * buttonSize), (coo.Y * buttonSize));
                    button.BackColor = Color.FromArgb(204, 0, 102);

                    Ground.Controls.Add(button);
                }

            }      
            


            return new Size(Ground.Width, Ground.Height);
        }
        public void showInfo()
        {
            Label Turn = new Label();
            if (turn) Turn.Text = "X";
            else Turn.Text = "Y";
            Turn.Font = new Font(Turn.Font.FontFamily, 20);
            Turn.ForeColor = Color.Red;
            Turn.Size = new Size(150, 50);
            
        }

        private bool checkWin()
        {
            List<Point> Xs = new List<Point>();
            List<Point> Os = new List<Point>();
            foreach (var item in clickedButtons)
            {
                if (item.Value == "X") Xs.Add(item.Key);
                else Os.Add(item.Key);
            }
            bool WON = false;
            if (Xs.Count >= length)
            {
                foreach (var item in Xs)
                {

                    // den kolla vänster och höger om de är lika!
                    for (int i = 0; i > length; i++)
                    {
                        int l = 0;
                        if (item == new Point(item.X + i, item.Y) && item == new Point(item.X - i, item.Y) && !WON)
                        {
                            l++;
                            if (l == length) WON = true;
                        }
                        else
                        {
                            break;
                        }
                    }
                    // den kollar uppåt och neråt om de är lika!
                    for (int i = 0; i > length; i++)
                    {
                        int l = 0;
                        if (item == new Point(item.X, item.Y + i) && item == new Point(item.X, item.Y - i) && !WON)
                        {
                            l++;
                            if (l == length) WON = true;
                        }
                        else
                        {
                            break;
                        }
                    }
                    // den kollar (uppåt höger) och (neråt vänster)!
                    for (int i = 0; i > length; i++)
                    {
                        int l = 0;
                        if (item == new Point(item.X + i, item.Y - i) && item == new Point(item.X - i, item.Y + i) && !WON)
                        {
                            l++;
                            if (l == length) WON = true;
                        }
                        else
                        {
                            break;
                        }
                    }
                    // den kollar (uppåt vänster) och (neråt höger)!
                    for (int i = 0; i > length; i++)
                    {
                        int l = 0;
                        if (item == new Point(item.X - i, item.Y - i) && item == new Point(item.X + i, item.Y + i) && !WON)
                        {
                            l++;
                            if (l == length) WON = true;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (WON) break;
                }
            }
            else if (Os.Count >= length)
            {
                foreach (var item in Os)
                {

                    // den kolla vänster och höger om de är lika!
                    for (int i = 0; i > length; i++)
                    {
                        int l = 0;
                        if (item == new Point(item.X + i, item.Y) && item == new Point(item.X - i, item.Y) && !WON)
                        {
                            l++;
                            if (l == length) WON = true;
                        }
                        else
                        {
                            break;
                        }
                    }
                    // den kollar uppåt och neråt om de är lika!
                    for (int i = 0; i > length; i++)
                    {
                        int l = 0;
                        if (item == new Point(item.X, item.Y + i) && item == new Point(item.X, item.Y - i) && !WON)
                        {
                            l++;
                            if (l == length) WON = true;
                        }
                        else
                        {
                            break;
                        }
                    }
                    // den kollar (uppåt höger) och (neråt vänster)!
                    for (int i = 0; i > length; i++)
                    {
                        int l = 0;
                        if (item == new Point(item.X + i, item.Y - i) && item == new Point(item.X - i, item.Y + i) && !WON)
                        {
                            l++;
                            if (l == length) WON = true;
                        }
                        else
                        {
                            break;
                        }
                    }
                    // den kollar (uppåt vänster) och (neråt höger)!
                    for (int i = 0; i > length; i++)
                    {
                        int l = 0;
                        if (item == new Point(item.X - i, item.Y - i) && item == new Point(item.X + i, item.Y + i) && !WON)
                        {
                            l++;
                            if (l == length) WON = true;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (WON) break;
                }
            }

            return WON;
        }
        private void StoreData(Button clckdbtn)
        {

            foreach (var row in buttons)
            {
                foreach (var button in row)
                {
                    if (button == clckdbtn)
                    {
                        Point coo = new Point(row.IndexOf(button), buttons.IndexOf(row));
                        clickedButtons.Add(coo, button.Text);

                    }
                }
            }
        }
        public void Play()
        {
            foreach (var row in buttons)
            {
                foreach (var button in row)
                {

                    button.MouseEnter += Button_MouseEnter;
                    button.MouseLeave += Button_MouseLeave;
                    button.MouseClick += Assign;

                }
            }

        }
        public void PlayVsAI()
        {
            foreach (var row in buttons)
            {
                foreach (var button in row)
                {

                    button.MouseEnter += Button_MouseEnter;
                    button.MouseLeave += Button_MouseLeave;
                    button.MouseClick += AssignVsAI;

                }
            }
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Enabled)
            {
                button.Text = "";
                button.BackColor = Color.FromArgb(204, 0, 102);
            }
        }
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Font = new Font(button.Font.FontFamily, 18);
            button.ForeColor = Color.FromArgb(252, 191, 30);


        }
        private void Assign(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            int newSize = 16;
            button.Font = new Font(button.Font.FontFamily, newSize);
            if (turn) button.Text = "X";
            else button.Text = "O";
            button.Enabled = false;
            turn = !turn;
            StoreData(button);
            if (checkWin()) MessageBox.Show("WON");
        }
        private void AssignVsAI(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            int newSize = 16;
            button.Font = new Font(button.Font.FontFamily, newSize);
            if (turn) button.Text = "X";
            else button.Text = "O";
            button.Enabled = false;
            turn = !turn;
            StoreData(button);
            if (checkWin()) MessageBox.Show("WON");
            AssignAI();
        }
        private void AssignAI()
        {
            Button button;
            if (!turn)
            {
                while (AllbuttonsEnabled() && !turn)
                {
                    int index1 = new Random().Next(buttons[0].Count);
                    int index2 = new Random().Next(buttons[1].Count);
                    button = buttons[index1][index2];
                    if (button.Enabled)
                    {
                        button.Text = "O";
                        button.Font = new Font(button.Font.FontFamily, 16);
                        button.Enabled = false;
                        turn = !turn;
                        StoreData(button);
                        if (checkWin()) MessageBox.Show("WON");
                        
                    }
                    else continue;
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
            if (l == storlek * storlek) state = false;
            return state;
        }
    }
}

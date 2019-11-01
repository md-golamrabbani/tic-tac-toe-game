bool turn = true; //true = x turn; false = y turn
int turn_count = 0;

Button b = (Button)sender;
if (turn)
{
    b.Text = "X";
} else
{
    b.Text = "0";
}

turn = !turn;
b.Enabled = false;
turn_count++;

winnerCheck();


private void winnerCheck() {
    bool winner = false;

    // horizontal checks
    if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
    {
        winner = true;
    }
    else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
    {
        winner = true;
    }
    else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
    {
        winner = true;
    }

    // vertical checks
    else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
    {
        winner = true;
    }
    else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
    {
        winner = true;
    }
    else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
    {
        winner = true;
    }
    
    // diagonal checks
    else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
    {
        winner = true;
    }
    else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
    {
        winner = true;
    }

    if (winner)
    {
        disableButton();

        String win = "";
        if (turn)
        {
            win = "0";    
        } else
        {
            win = "X";
        }
        MessageBox.Show(win + "Wins!");
    } // end if statement
    else
    {
        if (turn_count == 9) // game turn 9 time
        {
            MessageBox.Show(win + "Draw!");
        }
    }
} // end winner check function

private void disableButton() {
    try
    {
        foreach (Control item in Controls)
        {
            Button b = (Button)item;
            b.Enabled = false;
        } // forEach loop end
    }
    catch { }
    
}

private void newGame(object sender, EventArgs e) {
    turn = true;
    turn_count = 0;

    try
    {
        foreach (Control item in Controls)
        {
            Button b = (Button)item;
            b.Enabled = false;
            b.Text = "";
        } // forEach loop end
    }
    catch { }
}
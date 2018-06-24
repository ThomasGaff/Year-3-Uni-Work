using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections;
using System.Runtime.InteropServices;
using System.IO;

namespace PasswordCheckerAssignment
{
    

    public partial class Form1 : Form
    {
        //Create some variables for later use
        string PreviousPass;
        string key = "eAP-B=t=N_-K}%W`B%R-%AywxH;pGt4[";
        string vector = "U]+{r6d*M<5bUwKq";
        


        public Form1()
        {
            InitializeComponent();
        }

        

        //Method to make the form appear at the centre of the screen
        protected void CenterToScreen()
        {
            Screen screen = Screen.FromControl(this);

            Rectangle workingArea = screen.WorkingArea;
            this.Location = new Point()
            {
                X = Math.Max(workingArea.X, workingArea.X + (workingArea.Width - this.Width) / 2),
                Y = Math.Max(workingArea.Y, workingArea.Y + (workingArea.Height - this.Height) / 2)
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Make the form appear in the centre
            CenterToScreen();
            //Set the minimum and maximum for the progress bar
            pbScore.Minimum = 0;
            pbScore.Maximum = 6;
            //Set the minimum and maximum for the progress bar
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 1;
            //Set the minimum and maximum for the progress bar
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 1;
            //Set the minimum and maximum for the progress bar
            progressBar3.Minimum = 0;
            progressBar3.Maximum = 1;
            //Set the minimum and maximum for the progress bar
            progressBar4.Minimum = 0;
            progressBar4.Maximum = 1;
            //Set the minimum and maximum for the progress bar
            progressBar5.Minimum = 0;
            progressBar5.Maximum = 1;
            //Set the minimum and maximum for the progress bar
            progressBar6.Minimum = 0;
            progressBar6.Maximum = 1;
            //Set the minimum and maximum for the progress bar
            progressBar7.Minimum = 0;
            progressBar7.Maximum = 1;
            //Set the minimum and maximum, set the value and colour for the progress bar
            progressBar8.Minimum = 0;
            progressBar8.Maximum = 1;
            progressBar8.Value = 1;
            ModifyProgressBarColour.SetState(progressBar8, 2);
            //Set the minimum and maximum, set the value and colour for the progress bar
            progressBar9.Minimum = 0;
            progressBar9.Maximum = 1;
            progressBar9.Value = 1;
            ModifyProgressBarColour.SetState(progressBar9, 1);
            //Set the items in the combo box and set the combo box to autoselect the first item
            comboBoxID.Items.Add("bg88vx");
            comboBoxID.Items.Add("bg77ly");
            comboBoxID.Items.Add("bg71up");
            comboBoxID.SelectedIndex = 0;
        }

        private void bttnPass_Click(object sender, EventArgs e)
        {
            //If the first option in the combobox is selected do this
            if (comboBoxID.SelectedIndex == 0)
            {

                byte[] keyBytes = Encoding.ASCII.GetBytes(key);
                byte[] vectorBytes = Encoding.ASCII.GetBytes(vector);
                //Method for reading the data from a text file
                string decryptstring;
                using (StreamReader readtext = new StreamReader("bg71up.txt"))
                {
                    string line;
                    while ((line = readtext.ReadLine()) != null)
                    {
                        decryptstring = line; //Add to variable.
                                              //Runs the decrypt method on the string
                        byte[] decryptBytes = Convert.FromBase64String(decryptstring);
                        PreviousPass = AESEncryption.DecryptStringFromBytes_Aes(decryptBytes, keyBytes, vectorBytes);
                    }
                }

                //Declare variables
                string Password = txtPass.Text;
                int score = 0;
                int lower = 0;
                int upper = 0;
                int symbol = 0;
                int number = 0;
                int previous = 0;
                int length0 = 0;
                int length4 = 0;
                int length8 = 0;
                int length12 = 0;
                string Uppercase = @"[A-Z]";
                string Lowercase = @"[a-z]";
                string Symbols = @"[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]";
                string Numbers = @"[1-9]";


                //Check if there is anything entered
                if (Password.Length == 0)
                {
                    MessageBox.Show("Please Enter a Password", "Enter a password!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    length0++;
                    return;
                }
                //Check to see if password is same as Username
                if (Password == "bg71up")
                {
                    MessageBox.Show("Please Enter a Different Password", "Password is the same as Username!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Check to see if it is less than 4 characters in length
                if (Password.Length < 4)
                {
                    score--;
                    length4++;
                }
                //Check to see if it is between 8-11 characters in length
                if (Password.Length == 8 || Password.Length == 9 || Password.Length == 10 || Password.Length == 11)
                {
                    score++;
                    length8++;
                }
                //Check to see if it is more than or equal to 12 characters in length
                if (Password.Length >= 12)
                {
                    score++;
                    score++;
                    length12++;
                }
                //Check to see if the password has uppercase letters
                Match upp = Regex.Match(Password, Uppercase);
                if (upp.Success)
                {
                    //Incriment variables
                    score++;
                    upper++;
                }
                //Check to see if the password has lowercase letters
                Match low = Regex.Match(Password, Lowercase);
                if (low.Success)
                {
                    //Incriment variables
                    score++;
                    lower++;
                }
                //Check to see if the password has symbols
                Match sym = Regex.Match(Password, Symbols);
                if (sym.Success)
                {
                    //Incriment variables
                    score++;
                    symbol++;
                }
                //Check to see if the password has numbers
                Match num = Regex.Match(Password, Numbers);
                if (num.Success)
                {
                    //Incriment variables
                    score++;
                    number++;
                }
                //Check to see if the password matches the previous password
                if (PreviousPass == Password)
                {
                    //Incriment variables
                    score--;
                    previous++;
                }




                //Feedback if statments which change the colour of progressbars depending on if it's good or not
                if (previous == 0)
                {
                    progressBar7.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar7, 1);
                }

                if (lower == 0)
                {
                    progressBar1.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar1, 2);
                }

                if (upper == 0)
                {
                    progressBar2.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar2, 2);
                }

                if (symbol == 0)
                {
                    progressBar3.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar3, 2);
                }

                if (number == 0)
                {
                    progressBar4.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar4, 2);
                }

                if (length8 == 0)
                {
                    progressBar5.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar5, 2);
                }

                if (length12 == 0)
                {
                    progressBar6.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar6, 2);
                }

                if (previous == 1)
                {
                    progressBar7.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar7, 2);
                }

                if (lower == 1)
                {
                    progressBar1.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar1, 1);
                }

                if (upper == 1)
                {
                    progressBar2.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar2, 1);
                }

                if (symbol == 1)
                {
                    progressBar3.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar3, 1);
                }

                if (number == 1)
                {
                    progressBar4.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar4, 1);
                }

                if (length8 == 1)
                {
                    progressBar5.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar5, 1);
                }

                if (length12 == 1)
                {
                    progressBar6.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar6, 1);
                    progressBar5.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar5, 1);
                }

                


                //If statments to produce the progressbar strength colour depending on the score
                if (score == 1 || score == 2)
                {
                    lblFeed.Text = "Weak";
                    lblScore.Text = score.ToString();
                    pbScore.Value = score;
                    ModifyProgressBarColour.SetState(pbScore, 2);

                }

                if (score == 3 || score == 4)
                {
                    lblFeed.Text = "Moderate";
                    lblScore.Text = score.ToString();
                    pbScore.Value = score;
                    ModifyProgressBarColour.SetState(pbScore, 3);

                }

                if (score == 5 || score == 6)
                {
                    lblFeed.Text = "Strong";
                    lblScore.Text = score.ToString();
                    pbScore.Value = score;
                    ModifyProgressBarColour.SetState(pbScore, 1);

                }


                //Stops the password from being saved if it's the same as previous
                if (previous == 1)
                {
                    MessageBox.Show("Your password has not been saved as it was the same as the previous", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (length0 == 0)
                {
                    //Gets the date and time on the system
                    DateTime thisDay = DateTime.Today;
                    var date = thisDay.AddMonths(1);
                    string date1 = date.ToString("dd/MM/yyyy");
                    //Displays a message box telling the user when to change their password
                    MessageBox.Show("Please change your password on this date: " + date1, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Calls the Ecnrypt method and encrypts the string
                    byte[] encryptBytes = AESEncryption.EncryptStringToBytes_Aes(Password, keyBytes, vectorBytes);
                    string EncryptedData = Convert.ToBase64String(encryptBytes);

                    using (StreamWriter writetext = new StreamWriter("bg71up.txt"))

                    {
                        //Writes the encrypted string to the textfile
                        writetext.WriteLine(EncryptedData);
                        //Stream.Write(encryptBytes);
                    }
                }


            }
            //If the second option in the combobox is selected do this
            if (comboBoxID.SelectedIndex == 1)
            {


                byte[] keyBytes = Encoding.ASCII.GetBytes(key);
                byte[] vectorBytes = Encoding.ASCII.GetBytes(vector);
                //Method for reading the data from a text file
                string decryptstring;
                using (StreamReader readtext = new StreamReader("bg77ly.txt"))
                {
                    string line;
                    while ((line = readtext.ReadLine()) != null)
                    {
                        decryptstring = line; //Add to variable.
                                              //Runs the decrypt method on the string
                        byte[] decryptBytes = Convert.FromBase64String(decryptstring);
                        PreviousPass = AESEncryption.DecryptStringFromBytes_Aes(decryptBytes, keyBytes, vectorBytes);
                    }
                }

                //Declare variables
                string Password = txtPass.Text;
                int score = 0;
                int lower = 0;
                int upper = 0;
                int symbol = 0;
                int number = 0;
                int previous = 0;
                int length0 = 0;
                int length4 = 0;
                int length8 = 0;
                int length12 = 0;
                string Uppercase = @"[A-Z]";
                string Lowercase = @"[a-z]";
                string Symbols = @"[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]";
                string Numbers = @"[1-9]";


                //Check if there is anything entered
                if (Password.Length == 0)
                {
                    MessageBox.Show("Please Enter a Password", "Enter a password!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    length0++;
                    return;
                }
                //Check to see if password is same as Username
                if (Password == "bg77ly")
                {
                    MessageBox.Show("Please Enter a Different Password", "Password is the same as Username!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Check to see if it is less than 4 characters in length
                if (Password.Length < 4)
                {
                    score--;
                    length4++;
                }
                //Check to see if it is between 8-11 characters in length
                if (Password.Length == 8 || Password.Length == 9 || Password.Length == 10 || Password.Length == 11)
                {
                    score++;
                    length8++;
                }
                //Check to see if it is more than or equal to 12 characters in length
                if (Password.Length >= 12)
                {
                    score++;
                    score++;
                    length12++;
                }
                //Check to see if the password has uppercase letters
                Match upp = Regex.Match(Password, Uppercase);
                if (upp.Success)
                {
                    //Incriment variables
                    score++;
                    upper++;
                }
                //Check to see if the password has lowercase letters
                Match low = Regex.Match(Password, Lowercase);
                if (low.Success)
                {
                    //Incriment variables
                    score++;
                    lower++;
                }
                //Check to see if the password has symbols
                Match sym = Regex.Match(Password, Symbols);
                if (sym.Success)
                {
                    //Incriment variables
                    score++;
                    symbol++;
                }
                //Check to see if the password has numbers
                Match num = Regex.Match(Password, Numbers);
                if (num.Success)
                {
                    //Incriment variables
                    score++;
                    number++;
                }
                //Check to see if the password matches the previous password
                if (PreviousPass == Password)
                {
                    //Incriment variables
                    score--;
                    previous++;
                }




                //Feedback if statments which change the colour of progressbars depending on if it's good or not
                if (lower == 1)
                {
                    progressBar1.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar1, 1);
                }

                if (upper == 1)
                {
                    progressBar2.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar2, 1);
                }

                if (symbol == 1)
                {
                    progressBar3.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar3, 1);
                }

                if (number == 1)
                {
                    progressBar4.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar4, 1);
                }

                if (length8 == 1)
                {
                    progressBar5.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar5, 1);
                }

                if (length12 == 1)
                {
                    progressBar6.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar6, 1);
                }

                if (previous == 0)
                {
                    progressBar7.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar7, 1);
                }

                if (lower == 0)
                {
                    progressBar1.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar1, 2);
                }

                if (upper == 0)
                {
                    progressBar2.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar2, 2);
                }

                if (symbol == 0)
                {
                    progressBar3.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar3, 2);
                }

                if (number == 0)
                {
                    progressBar4.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar4, 2);
                }

                if (length8 == 0)
                {
                    progressBar5.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar5, 2);
                }

                if (length12 == 0)
                {
                    progressBar6.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar6, 2);
                }

                if (previous == 1)
                {
                    progressBar7.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar7, 2);
                }


                //If statments to produce the progressbar strength colour depending on the score
                if (score == 1 || score == 2)
                {
                    lblFeed.Text = "Weak";
                    lblScore.Text = score.ToString();
                    pbScore.Value = score;
                    ModifyProgressBarColour.SetState(pbScore, 2);

                }

                if (score == 3 || score == 4)
                {
                    lblFeed.Text = "Moderate";
                    lblScore.Text = score.ToString();
                    pbScore.Value = score;
                    ModifyProgressBarColour.SetState(pbScore, 3);

                }

                if (score == 5 || score == 6)
                {
                    lblFeed.Text = "Strong";
                    lblScore.Text = score.ToString();
                    pbScore.Value = score;
                    ModifyProgressBarColour.SetState(pbScore, 1);

                }


                //Stops the password from being saved if it's the same as previous
                if (previous == 1)
                {
                    MessageBox.Show("Your password has not been saved as it was the same as the previous", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (length0 == 0)
                {
                    //Gets the date and time on the system
                    DateTime thisDay = DateTime.Today;
                    var date = thisDay.AddMonths(1);
                    string date1 = date.ToString("dd/MM/yyyy");
                    //Displays a message box telling the user when to change their password
                    MessageBox.Show("Please change your password on this date: " + date1, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Calls the Ecnrypt method and encrypts the string
                    byte[] encryptBytes = AESEncryption.EncryptStringToBytes_Aes(Password, keyBytes, vectorBytes);
                    string EncryptedData = Convert.ToBase64String(encryptBytes);

                    using (StreamWriter writetext = new StreamWriter("bg77ly.txt"))

                    {
                        //Writes the encrypted string to the textfile
                        writetext.WriteLine(EncryptedData);
                        //Stream.Write(encryptBytes);
                    }
                }


            }
            //If the third option in the combobox is selected do this
            if (comboBoxID.SelectedIndex == 2)
            {

                byte[] keyBytes = Encoding.ASCII.GetBytes(key);
                byte[] vectorBytes = Encoding.ASCII.GetBytes(vector);
                //Method for reading the data from a text file
                string decryptstring;
                using (StreamReader readtext = new StreamReader("bg88vx.txt"))
                {
                    string line;
                    while ((line = readtext.ReadLine()) != null)
                    {
                        decryptstring = line; //Add to variable.
                                              //Runs the decrypt method on the string
                        byte[] decryptBytes = Convert.FromBase64String(decryptstring);
                        PreviousPass = AESEncryption.DecryptStringFromBytes_Aes(decryptBytes, keyBytes, vectorBytes);
                    }
                }

                //Declare variables
                string Password = txtPass.Text;
                int score = 0;
                int lower = 0;
                int upper = 0;
                int symbol = 0;
                int number = 0;
                int previous = 0;
                int length0 = 0;
                int length4 = 0;
                int length8 = 0;
                int length12 = 0;
                string Uppercase = @"[A-Z]";
                string Lowercase = @"[a-z]";
                string Symbols = @"[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]";
                string Numbers = @"[1-9]";


                //Check if there is anything entered
                if (Password.Length == 0)
                {
                    MessageBox.Show("Please Enter a Password", "Enter a password!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    length0++;
                    return;
                }
                //Check if password is the same as username
                if (Password == "bg88vx")
                {
                    MessageBox.Show("Please Enter a Different Password", "Password is the same as Username!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Check to see if it is less than 4 characters in length
                if (Password.Length < 4)
                {
                    score--;
                    length4++;
                }
                //Check to see if it is between 8-11 characters in length
                if (Password.Length == 8 || Password.Length == 9 || Password.Length == 10 || Password.Length == 11)
                {
                    score++;
                    length8++;
                }
                //Check to see if it is more than or equal to 12 characters in length
                if (Password.Length >= 12)
                {
                    score++;
                    score++;
                    length12++;
                }
                //Check to see if the password has uppercase letters
                Match upp = Regex.Match(Password, Uppercase);
                if (upp.Success)
                {
                    //Incriment variables
                    score++;
                    upper++;
                }
                //Check to see if the password has lowercase letters
                Match low = Regex.Match(Password, Lowercase);
                if (low.Success)
                {
                    //Incriment variables
                    score++;
                    lower++;
                }
                //Check to see if the password has symbols
                Match sym = Regex.Match(Password, Symbols);
                if (sym.Success)
                {
                    //Incriment variables
                    score++;
                    symbol++;
                }
                //Check to see if the password has numbers
                Match num = Regex.Match(Password, Numbers);
                if (num.Success)
                {
                    //Incriment variables
                    score++;
                    number++;
                }
                //Check to see if the password matches the previous password
                if (PreviousPass == Password)
                {
                    //Incriment variables
                    score--;
                    previous++;
                }




                //Feedback if statments which change the colour of progressbars depending on if it's good or not
                if (lower == 1)
                {
                    progressBar1.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar1, 1);
                }

                if (upper == 1)
                {
                    progressBar2.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar2, 1);
                }

                if (symbol == 1)
                {
                    progressBar3.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar3, 1);
                }

                if (number == 1)
                {
                    progressBar4.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar4, 1);
                }

                if (length8 == 1)
                {
                    progressBar5.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar5, 1);
                }

                if (length12 == 1)
                {
                    progressBar6.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar6, 1);
                }

                if (previous == 0)
                {
                    progressBar7.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar7, 1);
                }

                if (lower == 0)
                {
                    progressBar1.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar1, 2);
                }

                if (upper == 0)
                {
                    progressBar2.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar2, 2);
                }

                if (symbol == 0)
                {
                    progressBar3.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar3, 2);
                }

                if (number == 0)
                {
                    progressBar4.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar4, 2);
                }

                if (length8 == 0)
                {
                    progressBar5.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar5, 2);
                }

                if (length12 == 0)
                {
                    progressBar6.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar6, 2);
                }

                if (previous == 1)
                {
                    progressBar7.Value = 1;
                    ModifyProgressBarColour.SetState(progressBar7, 2);
                }


                //If statments to produce the progressbar strength colour depending on the score
                if (score == 1 || score == 2)
                {
                    lblFeed.Text = "Weak";
                    lblScore.Text = score.ToString();
                    pbScore.Value = score;
                    ModifyProgressBarColour.SetState(pbScore, 2);

                }

                if (score == 3 || score == 4)
                {
                    lblFeed.Text = "Moderate";
                    lblScore.Text = score.ToString();
                    pbScore.Value = score;
                    ModifyProgressBarColour.SetState(pbScore, 3);

                }

                if (score == 5 || score == 6)
                {
                    lblFeed.Text = "Strong";
                    lblScore.Text = score.ToString();
                    pbScore.Value = score;
                    ModifyProgressBarColour.SetState(pbScore, 1);

                }


                //Stops the password from being saved if it's the same as previous
                if (previous == 1)
                {
                    MessageBox.Show("Your password has not been saved as it was the same as the previous", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (length0 == 0)
                {
                    //Gets the date and time on the system
                    DateTime thisDay = DateTime.Today;
                    var date = thisDay.AddMonths(1);
                    string date1 = date.ToString("dd/MM/yyyy");
                    //Displays a message box telling the user when to change their password
                    MessageBox.Show("Please change your password on this date: " + date1, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //Calls the Ecnrypt method and encrypts the string
                    byte[] encryptBytes = AESEncryption.EncryptStringToBytes_Aes(Password, keyBytes, vectorBytes);
                    string EncryptedData = Convert.ToBase64String(encryptBytes);

                    using (StreamWriter writetext = new StreamWriter("bg88vx.txt"))

                    {
                        //Writes the encrypted string to the textfile
                        writetext.WriteLine(EncryptedData);
                        //Stream.Write(encryptBytes);
                    }
                }


            }
        
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //Make the password have cirlce dots insteads of the charachters
                txtPass.UseSystemPasswordChar = true;
            }

            else
            {
                //Make the password display normally
                txtPass.UseSystemPasswordChar = false;
            }
        }
    }
}

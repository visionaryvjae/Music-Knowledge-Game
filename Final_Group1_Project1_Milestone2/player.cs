using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Group1_Project1_Milestone1
{
    class player
    {
        public delegate void LoginConfirmation();
        public event LoginConfirmation ConfirmRegister;
        

        string textfile = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "playerInfo.txt");  //@"C:\Users/Aluta Jakuja/Downloads/Milestone2/Artsits_Player/playerInfo.txt";
        string Scorefile = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory,"scoreUpdate.txt");
        string CurrentUser = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "currentUser.txt");
        string username;
        string password;
        int highscore;
        bool multiplayer;
        bool answer;
        List<int> scores;
        int p1 = 0, p2 = 0;
        string points = "Score: ";

        List<string> players = new List<string>();



        public player()
        {

        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public List<int> Scores { get => scores; set => scores = value; }

        public bool Multiplayer { get => multiplayer; set => multiplayer = value; }
        public int Highscore { get => highscore; set => highscore = value; }

        public int IncrementHighScore(int score)
        {
            return score;
        }

        public void MultiplayerStatus(bool mult)
        {
            Multiplayer = mult;
        }

        public void ResetScore()
        {
            File.WriteAllText(Scorefile, "0\n0");
        }

        public void takeCurrentUser(string username, string password)
        {
            File.WriteAllText(CurrentUser, username + "-" + password);
        }

        public string getCurrentUsername(bool multiplayer)
        {
            if (multiplayer)
            {
                return "Player 1";
            }
            else
            {
                string line = File.ReadAllText(CurrentUser);
                string uname;
                int index = line.IndexOf('-');
                uname = line.Substring(0, index);

                return uname;
            }
        }

        public void UpdateUser(int hScore)
        {
            string ln = File.ReadAllText(CurrentUser);
            int index = ln.IndexOf('-');
            string unae = ln.Substring(0, index), pass = ln.Substring(index + 1);

            string lUnae, lPass;
            List<string> ls = File.ReadAllLines(textfile).ToList<string>();
            List<string> Update = new List<string>();
                Update = ls;
            int counter = 0;
            foreach (string l in ls)
            {
                index = l.IndexOf('-');
                lUnae = l.Substring(0, index);
                string line;
                line = l.Substring(index + 1);
                index = line.IndexOf('-');
                lPass = line.Substring(0, index);
                Highscore = Convert.ToInt32(line.Substring(index + 1));


                if ((unae == lUnae) && (pass == lPass))
                {
                    Update[counter] = unae + "-" + pass + "-" + hScore;
                }
                counter++;
            }

            File.WriteAllLines(textfile, Update);
        }

        public string KeepScore(int p, bool answer)
        {
            
            if (multiplayer)
            {
                if (answer)
                {
                    List<string> Score = File.ReadAllLines(Scorefile).ToList<string>();
                    p1 = Convert.ToInt32(Score[0]);
                    p2 = Convert.ToInt32(Score[1]);

                    if (p > 1)
                    {
                        p2++;
                        points = $"Score: {p2}";
                    }
                    else
                    {
                        p1++;
                        points =  $"Score: {p1}";
                    }

                    Score[0] = p1.ToString();
                    Score[1] = p2.ToString();
                    File.WriteAllLines(Scorefile, Score);

                }
                else
                {
                    //WrongAnswer();
                }
            }
            else
            {
                if (answer)
                {
                    List<string> Score = File.ReadAllLines(Scorefile).ToList<string>();
                    p1 = Convert.ToInt32(Score[0]);
                    p1++;

                    File.WriteAllText(Scorefile, p1.ToString());

                    points = $"Score: {p1}";
                }
                else
                {
                   // WrongAnswer();
                }
            }
            return points;
        }

        public string getScores()
        {
            string score;
            List<string> scores = File.ReadAllLines(Scorefile).ToList<string>();

            if (scores.Count > 1)
            {
                score = scores[0] + "-" + scores[1];
            }
            else
            {
                score = scores[0] + "-0";
            }

            return score;
        }


        public void WelcomMessage()
        {
            MessageBox.Show("Hello");
        }

        public void registerPlayer()
        {
            players = File.ReadAllLines(textfile).ToList<string>();
            players.Add(Username + "-" + Password + "-0");
            File.WriteAllLines(textfile, players);
            ConfirmRegister();
        }

        public int getHighScore(bool mult)
        {
            if(mult)
            {
                return 0;
            }
            else
            {
                return Highscore;
            }
        }

        public void Login(string unae, string pass)
        {
            string lUnae, lPass;
            List<string> ls = File.ReadAllLines(textfile).ToList<string>();
            int counter = 0;
            foreach (string l in ls)
            {
                int index = l.IndexOf('-');
                lUnae = l.Substring(0, index);
                string line;
                line = l.Substring(index + 1);
                index = line.IndexOf('-');
                lPass = line.Substring(0, index);
                Highscore = Convert.ToInt32(line.Substring(index + 1));


                if ((unae == lUnae) && (pass == lPass))
                {
                    counter++;
                }

            }
            if (counter > 0)
            {
                MessageBox.Show("Welcome user " + unae, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmPlayerCount f3 = new frmPlayerCount();
                f3.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!!!", "Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        public void Registered()
        {
            MessageBox.Show("Successfully registered!! Please click the login button below to start :D", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

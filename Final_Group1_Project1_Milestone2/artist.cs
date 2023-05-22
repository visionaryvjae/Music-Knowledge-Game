using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Group1_Project1_Milestone1
{
    class artist
    {
        List<string> name = new List<string>();
        List<string> genre = new List<string>();
        List<string> SongTitles = new List<string>();
        string textfile = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory,"artistInfo.txt");
        List<artist> la = new List<artist>();

        public artist()
        {

        }

        public artist(string name, string genre, string songTitles)
        {

        }

        public List<string> Name { get => name; set => name = value; }
        public List<string> Genre { get => genre; set => genre = value; }
        public List<string> SongTitles1 { get => SongTitles; set => SongTitles = value; }

        public void getArtists()
        {
            List<string> ls = File.ReadAllLines(textfile).ToList<string>();

            foreach (string l in ls)
            {
                int index = l.IndexOf('-');
                Name.Add(l.Substring(0, index));
                string line;
                line = l.Substring(index + 1);
                index = line.IndexOf('-');
                SongTitles1.Add(line.Substring(0, index));
                Genre.Add(line.Substring(index + 1));

            }
        }

        public int produceArtistindex()
        {
            int limit = Name.Count - 1;

            Random ran = new Random();

            int randomArtist = ran.Next(0, limit);

            return randomArtist;
        }

        public bool checkArtist(int indx, string userInput)
        {
            List<string> lg = File.ReadAllLines(textfile).ToList<string>();
            string Art;

            Art = Name[indx];

            if (userInput == Art)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<string> getArtistList()
        {
            List<string> tempArtists = new List<string>();
            List<string> tempList = File.ReadAllLines(textfile).ToList<string>();
            foreach (string a in tempList)
            {
                int index = a.IndexOf('-');
                tempArtists.Add(a.Substring(0, index));
            }

            return tempArtists;
        }

        public bool checkGenre(int indx, string userInput)
        {
            List<string> lg = File.ReadAllLines(textfile).ToList<string>();
            string Gen;

            Gen = Genre[indx];

            if (userInput == Gen)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

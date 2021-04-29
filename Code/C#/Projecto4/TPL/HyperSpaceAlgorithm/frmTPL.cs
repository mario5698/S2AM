using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace TPL
{
    public partial class frmTPL : Form
    {
        Thread hilo1;

        public frmTPL()
        {
            InitializeComponent();
        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            hilo1 = new Thread(new ThreadStart(StartProcess));
            hilo1.Start();
        }

        private void StartProcess()
        {
            string[] nomFitxer = { "1.txt", "2.txt", "3.txt" };
             Parallel.For(0, 3, (i, state) =>
               {
                   string ruta = Application.StartupPath;
                   string rutaFile = ruta + "\\Recursos\\" + nomFitxer[i];
                   string file = System.IO.File.ReadAllText(rutaFile);
                   ListBox[] listBoxes = new ListBox[3] { lstData0 , lstData1, lstData2 };
                   file.Replace("-", " ");
                   file.Replace(",", " ");
                   file.Replace(".", " ");
                   file.Replace("\n", " ");
                   file.Replace("\r", " ");

                   string[] words = file.Split(' ');

                       DoChecks(words, listBoxes[i]);
               });
        }
      

        private void DoChecks(string[] words, ListBox lst)
        {
            lstClear(lst);
            string[] Searchwords = { "white", "time", "that", "the", "empty", "door", "table" };
            string[] SearchLetter = { "A", "C", "W", "Z", "L", "S", "E" };
            Random rnd = new Random();
            Parallel.Invoke(() =>
            {
                addTextToLabelBox(lst, GetLongestWord(words));
            },
            () =>
            {
                addTextToLabelBox(lst, GetMostCommonWords(words, rnd.Next(4, 10), rnd.Next(5, 10)));
            },
            () =>
            {
                addTextToLabelBox(lst, GetMostCommonWordsByLength(words, rnd.Next(4, 10), rnd.Next(5, 10)));
            },
            () =>
            {
                for (int i = 0; i < Searchwords.Length; i++)
                {
                    addTextToLabelBox(lst, GetCountForWord(words, Searchwords[i]));
                    addTextToLabelBox(lst, GetCountForLetter(words, SearchLetter[i]));
                }
            },
            () =>
            {
                addTextToLabelBox(lst, GetLessCommonWords(words, rnd.Next(4, 10), rnd.Next(5, 10)));
            }
             );
            changeColorLst(lst);

        }

        #region HelperMethods



        //tasks1 
        private string GetMostCommonWords(string[] words, int len = 5, int quants = 5)
        {
             var frequencyOrder = from word in words
                                 group word by word into g
                                 orderby g.Count() descending
                                 select g.Key;

            var commonWords = frequencyOrder.Take(quants);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Task 1 -- GetCommonWords with more than  letters: ");
            foreach (var v in commonWords)
            {
                sb.AppendLine("  " + v + " " + v.Count());
            }
            string resultat = sb.ToString();
            return resultat;
        }

        //task2
        private string GetMostCommonWordsByLength(string[] words, int len = 5, int quants = 5)
        {
           var frequencyOrder = from word in words
                                 where word.Length == 3
                                 group word by word into g
                                 orderby g.Count() ascending
                                 select g.Key;

            var commonWords = frequencyOrder.Take(quants);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Task 2 -- GetCommonWordsByLength With {len} letters: ");
            foreach (var v in commonWords)
            {
                sb.AppendLine("  " + v + " " + v.Count());
            }
            string resultat = sb.ToString();
            return resultat;

        }
        //taks3
        private string GetCountForWord(string[] words, string term)
        {
          var frequencyOrder = from word in words
                                 where word == term
                                 group word by word into g
                                 orderby g.Count() ascending
                                 select g.Key;


            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Task 2 -- GetCommonWordsByLength With {term} letters: ");
            foreach (var v in frequencyOrder)
            {
                sb.AppendLine("  " + v + " " + v.Count());
            }
            string resultat = sb.ToString();
            return resultat;
        }
        //task4
        private string GetCountForLetter(string[] words, string letter)
        {
            var frequencyOrder = from word in words
                                 where word.StartsWith(letter)
                                 group word by word into g
                                 orderby g.Count() ascending
                                 select g.Key;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Task 4 -- The Words that startWith {letter} accurs");
            int numeroRep = 0;
            foreach (var v in frequencyOrder)
            {
                numeroRep = numeroRep + v.Count();
            }
            sb.AppendLine(" " + numeroRep);
            string resultat = sb.ToString();
            return resultat;
        }

        //tasks 5
        private string GetLessCommonWords(string[] words, int len = 5, int quants = 5)
        {
            var frequencyOrder = from word in words
                                 where word.Length > len
                                 group word by word into g
                                 orderby g.Count() descending
                                 select g.Key;

            var commonWords = frequencyOrder.Take(quants);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Task 5 -- The less common Words With more than {len} letter, are: ");
            foreach (var v in commonWords)
            {
                sb.AppendLine("  " + v + " " + v.Count());
            }
            string resultat = sb.ToString();
            return resultat;
        }


        //Task 6
        private string GetLongestWord(string[] words)
        {
            var longestWord = (from w in words
                               orderby w.Length descending
                               select w).First();

            string resultat = $"Task 6 -- The longest word is {longestWord}.";
            return resultat;
        }
        private void addTextToLabelBox(ListBox lst, string content)
        {
            if (InvokeRequired)
            {
                lst.Invoke(new MethodInvoker(
                    delegate ()
                    {
                        lst.Items.Add(content);
                    }
                ));
            }
        }

        private void changeColorLst(ListBox lst)
        {
            if (InvokeRequired)
            {
                lst.Invoke(new MethodInvoker(
                    delegate ()
                    {
                        lst.BackColor = Color.Green;
                    }
                ));
            }
        }

        private void lstClear(ListBox lst)
        {
            if (InvokeRequired)
            {
                lst.Invoke(new MethodInvoker(
                    delegate ()
                    {
                        lst.Items.Clear();
                        lst.BackColor = Color.White;

                    }
                ));
            }
        }
        #endregion
    }
}

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
            // Cal fer una crida a StartProcess() utilitzant una tasca
            hilo1 = new Thread(new ThreadStart(StartProcess));
            hilo1.Start();
        }

        private void StartProcess()
        {
            string[] nomFitxer = { "1.txt", "2.txt", "3.txt" };
            var result = Parallel.For(0, 3, (i, state) =>
               {
                   string ruta = Application.StartupPath;
                   string rutaFile = ruta + "\\Recursos\\" + nomFitxer[i];
                   string file = System.IO.File.ReadAllText(rutaFile);
                   file = file.Replace(".", " ");
                   file = file.Replace(",", " ");
                   file = file.Replace("-", " ");
                   file = file.Replace("\n", " ");
                   file = file.Replace("\r", " ");

                   string[] words = file.Split(' ');

                   if (i == 0)
                   {
                       DoChecks(words, lstData0);
                   }
                   if (i == 1)
                   {
                       DoChecks(words, lstData1);
                   }
                   if (i == 2)
                   {
                       DoChecks(words, lstData2);
                   }
               });
            //Per a cada fitxer cal fer una crida en paral·lel a la funció DoChecks passant a part de 
            // l'array de strings també el control on volem pintar els resultats
        }
      

        private void DoChecks(string[] words, ListBox lst)
        {
            //aquí llençarem en paral·lel cadascuna de les tasques a fer en el Helper
            //Utilitzem aquests arrays per indicar quines paraules volem buscar i quina lletra 
            //Això serà necessari per alguns mètodes
            lstClear(lst);
            string[] Searchwords = { "white", "time", "that", "the", "empty", "door", "table" };
            string[] SearchLetter = { "A", "C", "W", "Z", "L", "S", "E" };
            // servirà més tard per trobar a l'atzar la llargada d'algunes paraules
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
            // cerca les paraules que apareixen més cops d'una determinada llargada i ens mostren quines són i quants cops apareixen
            // l'argument quants indica quantes paraules hem de mostrar Si indiquem 5 vol dir que mostrem les 5 que surten més
            // per defecte passem sempre 5
            // l'argument len indica la llargada de les paraules i s'obtindrà a partir d'obtenir 
            // un nombre random entre 4 i 10 a la funció que fa la crida a aquesta
            var frequencyOrder = from word in words
                                 where word.Length > len
                                 group word by word into g
                                 orderby g.Count() descending
                                 select g.Key;

            var commonWords = frequencyOrder.Take(quants);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Task 1 -- GetCommonWords with more than {len} letters: ");
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
            // cerca les paraules que apareixen més cops d'una determinada llargada i ens mostren quines són i quants cops apareixen
            // l'argument quants indica quantes paraules hem de mostrar Si indiquem 5 vol dir que mostrem les 5 quurte sen més
            // per defecte passem sempre 5
            // l'argument len indica la llargada de les paraules i s'obtindrà a partir d'obtenir un nombre random entre 4 i 10 a la funció que fa la crida a aquesta
            var frequencyOrder = from word in words
                                 where word.Length > len
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
            // cerca quants cops apareix la paraula term en el llibre
            // l'argument term és cadascuna de les paraules que hi ha en l'array de paraules de DoChecks

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
            // cerca quants cops apareixen paraules que comencen amb la lletra indicada a l'argument letter 
            // l'argument letter és cadascuna de les lletres que hi ha en l'array de lletres de  DoChecks

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
            // cerca quants cops apareixen les paraules que menys apareixen i que tenen una determinada llargada
            // l'argument quants indica quantes paraules hem de mostrar. Si indiquem 5 vol dir que mostrem les 5 que surten menys
            // per defecte passem sempre 5 
            // l'argument len indica la llargada de les paraules i s'obtindrà a partir d'obtenir 
            // un nombre random entre 4 i 10 a la funció que fa la crida a aquesta
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

        ///Falten les funcions que llegeixen el fitxer i en darrer cas el transformen en un array de strings amb les paraules. 
        ///Podeu utilitzar la funció de l'exemple com a base (CreateWordArray), però penseu que ara els fitxers són locals i no  una URL,
        ///i que potser caldrà fer-ho d'una forma una mica diferent per afavorir automatitzar el programa.
        #endregion
    }
}

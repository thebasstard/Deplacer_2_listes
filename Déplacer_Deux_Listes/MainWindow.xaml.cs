using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Déplacer_Deux_Listes
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            Phrases MaPhrase1 = new Phrases();
            MaPhrase1.Langage = "BlaBla";
            Phrases MaPhrase2 = new Phrases();
            MaPhrase2.Langage = "Incroyable !!";
            Phrases MaPhrase3 = new Phrases();
            MaPhrase3.Langage = "Zbouibouiboui";
            Phrases MaPhrase4 = new Phrases();
            MaPhrase4.Langage = "CosmoCosmo";

            List<Phrases> MaListe = new List<Phrases>();

            MaListe.Add(MaPhrase1);
            MaListe.Add(MaPhrase2);
            MaListe.Add(MaPhrase3);
            MaListe.Add(MaPhrase4);

            foreach (Phrases p in MaListe)
            {
                listBoxGauche.Items.Add(p.Langage);
            }


        }

        private void button1Haut_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = listBoxGauche.SelectedIndex;

            if (selectedIndex > 0)
            {
                listBoxGauche.Items.Insert(selectedIndex - 1, listBoxGauche.Items[selectedIndex]);
                listBoxGauche.Items.RemoveAt(selectedIndex + 1);
                listBoxGauche.SelectedIndex = selectedIndex - 1;
            }


        }

        private void button1Bas_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = listBoxGauche.SelectedIndex;
            if (selectedIndex < listBoxGauche.Items.Count - 1 & selectedIndex != -1)
            {
                listBoxGauche.Items.Insert(selectedIndex + 2, listBoxGauche.Items[selectedIndex]);
                listBoxGauche.Items.RemoveAt(selectedIndex);
                listBoxGauche.SelectedIndex = selectedIndex + 1;

            }

        }

        private void button1A_Click(object sender, RoutedEventArgs e)
        {
            listBoxGauche.Items.SortDescriptions.Add
            (
            new System.ComponentModel.SortDescription("",
            System.ComponentModel.ListSortDirection.Ascending)
            );


        }

        private void button1Z_Click(object sender, RoutedEventArgs e)
        {
            listBoxGauche.Items.SortDescriptions.Add
            (
            new System.ComponentModel.SortDescription("",
            System.ComponentModel.ListSortDirection.Descending)
            );


        }

        private void button2Haut_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = listBoxDroite.SelectedIndex;

            if (selectedIndex > 0)
            {
                //déplace l'objet à la ligne souhaitée : l'objet passe à l'index de sa ligne -1 
                listBoxDroite.Items.Insert(selectedIndex - 1, listBoxDroite.Items[selectedIndex]);
                //MessageBox.Show(Convert.ToString(listBoxDroite.Items[selectedIndex]));
                //supprime l'objet resté dans sa ligne +1
                listBoxDroite.Items.RemoveAt(selectedIndex + 1);
                //copie l'objet de la ligne -1 à la ligne sélectionnée
                listBoxDroite.SelectedIndex = selectedIndex - 1;
            }


        }

        private void button2Bas_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = listBoxDroite.SelectedIndex;

            if (selectedIndex < listBoxDroite.Items.Count - 1 & selectedIndex != -1)
            {
                listBoxDroite.Items.Insert(selectedIndex + 2, listBoxDroite.Items[selectedIndex]);
                listBoxDroite.Items.RemoveAt(selectedIndex);
                listBoxDroite.SelectedIndex = selectedIndex + 1;

            }
        }

        private void button2A_Click(object sender, RoutedEventArgs e)
        {
            listBoxDroite.Items.SortDescriptions.Add
            (
            new System.ComponentModel.SortDescription("",
            System.ComponentModel.ListSortDirection.Ascending)
            );
        }

        private void button2Z_Click(object sender, RoutedEventArgs e)
        {
            listBoxDroite.Items.SortDescriptions.Add
            (
            new System.ComponentModel.SortDescription("",
            System.ComponentModel.ListSortDirection.Descending)
            );

        }

        private void buttonGauche_Click(object sender, RoutedEventArgs e)
        {
            string ps = "";
            ps = Convert.ToString(listBoxDroite.SelectedItem);
            listBoxGauche.Items.Add(ps);
            listBoxDroite.Items.Remove(ps);
        }

        private void button1Droite_Click(object sender, RoutedEventArgs e)
        {
            string ps = "";
            ps = Convert.ToString(listBoxGauche.SelectedItem);
            listBoxDroite.Items.Add(ps);
            listBoxGauche.Items.Remove(ps);
        }

        private void buttonUltraDroite_Click(object sender, RoutedEventArgs e)
        {
            foreach (string item in listBoxGauche.Items)
            {
                listBoxDroite.Items.Add(item);//ajoute la liste complete de l'aute côté
            }


            listBoxGauche.Items.Clear();//supprime tous les éléments de la liste

        }

        private void button1UltraGauche_Click(object sender, RoutedEventArgs e)
        {
            foreach (string item in listBoxDroite.Items)
            {
                listBoxGauche.Items.Add(item);
            }


            listBoxDroite.Items.Clear();
        }

        private void listBoxGauche_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void listBoxDroite_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}

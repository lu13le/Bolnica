using System;
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
using System.Windows.Shapes;

namespace BolnicaIspit2
{
    /// <summary>
    /// Interaction logic for unosNovog.xaml
    /// </summary>
    public partial class unosNovog : Window
    {
        BolnicaDataContext dc = new BolnicaDataContext();
        public unosNovog()
        {
            InitializeComponent();
            puniCombo();
        }

        void puniCombo()
        {
            var odelj = from o in dc.Odeljenjes
                        select o;
            cbOdelj.ItemsSource = odelj;
        }

        private void cbOdelj_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var soba = (from s in dc.Sobas
                        where s.OdeljenjeID == ((Odeljenje)cbOdelj.SelectedItem).OdeljenjeID
                        select s);
            cbSoba.ItemsSource = soba;

        }

        private void cbSoba_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var sprat = (from s in dc.Sobas
                         where s.SobaID == ((Soba)cbSoba.SelectedItem).SobaID
                         select s.Sprat).FirstOrDefault();
            tbSprat.Text = sprat.ToString();
        }

        private void btnOdustani_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void btnUnesi_Click(object sender, RoutedEventArgs e)
        {
            Pacijent pacijent = new Pacijent();
            pacijent.IDPacijent =int.Parse( tbSifra.Text);
            pacijent.Ime = tbIme.Text;
            pacijent.Prezime = tbPrezime.Text;
            pacijent.Prioritet =int.Parse( tbPrio.Text);
            pacijent.Odeljenje = ((Odeljenje)cbOdelj.SelectedItem);
            pacijent.Soba = ((Soba)cbSoba.SelectedItem);

            dc.Pacijents.InsertOnSubmit(pacijent);
            try
            {
                dc.SubmitChanges();
                MessageBox.Show("Uspesno ste ubacili pacijenta!");

            }catch(Exception ex)
            {
                MessageBox.Show("greska: " + ex);
            }
            
        }
    }
}

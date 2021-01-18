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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BolnicaIspit2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BolnicaDataContext dc = new BolnicaDataContext();
        public MainWindow()
        {
            InitializeComponent();
            puniGrid();
            puniCombmo();
        }
        void puniGrid()
        {
            var pacijent = from p in dc.Pacijents
                           select p;
            grid1.ItemsSource = pacijent;
        }
        void puniCombmo()
        {
            var naziv = from n in dc.Odeljenjes
                        select n;
            cbOdeljenje.ItemsSource = naziv;
        }

        private void cbOdeljenje_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var pacijent = (from p in dc.Pacijents
                            where p.OdeljenjeID == ((Odeljenje)cbOdeljenje.SelectedItem).OdeljenjeID
                            select p);
            lbPrikaz.ItemsSource = pacijent;
        }

        private void btnMaxDana_Click(object sender, RoutedEventArgs e)
        {
            var max = (from m in dc.Pacijents
                       where m.OdeljenjeID == ((Odeljenje)cbOdeljenje.SelectedItem).OdeljenjeID
                       select m).Max(x => x.BrDana);
            var selektuj = (from s in dc.Pacijents
                            where s.BrDana == max
                            select s);
            lbPrikaz.ItemsSource = selektuj;


        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var vise = (from v in dc.Pacijents
                        where v.Prioritet == ((cbPrio.SelectedIndex + 1))
                        select v).Where(x=> x.BrDana>3);
            lbPrikaz.ItemsSource = vise;
        }

        private void btnIzracunaj_Click(object sender, RoutedEventArgs e)
        {
            int rez =int.Parse( tbBrDana.Text )* int.Parse(tbPart.Text);
            tbUkupno.Text = rez.ToString();
        }

        private void btnOtpusi_Click(object sender, RoutedEventArgs e)
        {
            var pacijent = (from p in dc.Pacijents
                           where p.IDPacijent == int.Parse(tbSifra.Text)
                           select p).FirstOrDefault();
            dc.Pacijents.DeleteOnSubmit(pacijent);
            try
            {
                dc.SubmitChanges();
                puniGrid();
                MessageBox.Show("Uspesno ste obrisali pacijenta!");
                tbSifra.Clear();
            }catch(Exception ex)
            {
                MessageBox.Show("Greska: " + ex);
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            unosNovog novi = new unosNovog();
            novi.ShowDialog();
        }
    }
}

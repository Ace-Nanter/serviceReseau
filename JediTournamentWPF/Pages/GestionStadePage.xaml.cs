﻿using System;
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
using EntitiesLayer;
using BusinessLayer;
using JediTournamentWPF.ViewModel;

namespace JediTournamentWPF.Pages {
    /// <summary>
    /// Logique d'interaction pour GestionStadePage.xaml
    /// </summary>
    public partial class GestionStadePage : Page {

        public GestionStadePage(JediTournamentManager manager)
        {
            //m_manager = manager;
            InitializeComponent();
            //StadeList.ItemsSource = m_manager.getStades();
        }
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            // Initialisation du viewModel
            StadeGestionModel svm = new StadeGestionModel();
            this.DataContext = svm;
            svm.CancelNotified += onCancel;
        }
        private void onCancel(Object sender, EventArgs args)
        {
            this.NavigationService.GoBack();
        }
    }
}

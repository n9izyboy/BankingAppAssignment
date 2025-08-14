using MauiBankingExercise.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MauiBankingExercise.Models;

namespace MauiBankingExercise.View_Models
{
    public partial class AllBankViewModels : BaseViewModel
    {
        public AllBankViewModels()
        {
            Title = "All Banks";
            LoadBanks();
        }
        
        
        
            public string Title { get; set; } = "All Banks";
      
            private BankingDataBaseServices bankingDataBaseServices = new BankingDataBaseServices();
        
        // Add properties and methods to manage the list of banks, customers, accounts, etc.
        // For example, you might have a property to hold a list of banks:
        public List<Bank> Banks { get; set; } = new List<Bank>();
        
        public void LoadBanks()
        {
            // Logic to load banks from a database or API
        }
      
    }
}

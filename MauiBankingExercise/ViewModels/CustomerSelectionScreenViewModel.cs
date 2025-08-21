using MauiBankingExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiBankingExercise.Services;
using MauiBankingExercise.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;


namespace MauiBankingExercise.ViewModels
{
    public partial class CustomerSelectionScreenViewModel : BaseViewModel
    {
        private BankingSeeder _bankingSeeder;
        private Customer _customer;
        

        public Customer customer
         {
            get { return _customer; }
            set
            {
                _customer = value;

                _customer.CustomerType = _bankingSeeder.GetCustomer();

                OnPropertyChanged();
            } 
         }

        public CustomerSelectionScreenViewModel(BankingSeeder bankingSeeder)
        {   _bankingSeeder = bankingSeeder;
            
        }


        public override void OnAppearing()
        {
            base.OnAppearing();
        }

        



         









    } 
}
     

    


using MauiBankingExercise.Models;
using MauiBankingExercise.Services;
using MauiBankingExercise.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace MauiBankingExercise.ViewModels
{
    public partial class CustomerSelectionScreenViewModel : BaseViewModel
    {
        private readonly BankingSeeder bankingSeeder;
        private Customer _customer;
        private bool _isLoading;

        public CustomerSelectionScreenViewModel(BankingSeeder _bankingSeeder)
        {
            BankingSeeder = _bankingSeeder;
            SelectCustomerCommand = new Command<Customer>(OnSelectCustomer);
        }

        public ObservableCollection<Customer> Customers
        {
            get => _customers;
            set => SetProperty(ref _customers, value);
        }

        private void SetProperty(ref ObservableCollection<Customer> customers, ObservableCollection<Customer> value)
        {
            throw new NotImplementedException();
        }

        public bool IsLoading
        {
            get => _isLoading;
            set => SetProperty(ref _isLoading, value);
        }

        private void SetProperty(ref bool isLoading, bool value)
        {
            throw new NotImplementedException();
        }

        private BankingSeeder _bankingSeeder;
        private ObservableCollection<Customer> _customers;

        public BankingSeeder BankingSeeder { get; }
        public ICommand SelectCustomerCommand { get; }

        public async Task LoadCustomersAsync()
        {
            IsLoading = true;
            try
            {
                var customers = await _bankingSeeder.GetCustomersAsync();
                Customers.Clear();
                foreach (var customer in customers)
                {
                    Customers.Add((Customer)customer);
                }
            }
            catch (Exception ex)
            {
                // Handle error
                System.Diagnostics.Debug.WriteLine($"Error loading customers: {ex.Message}");
            }
            finally
            {
                IsLoading = false;
            }
        }

        private async void OnSelectCustomer(Customer customer)
        {
            if (customer != null)
            {
                await Shell.Current.GoToAsync($"CustomerDashboard?customerId={customer.CustomerId}");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

















    } 
}
     

    


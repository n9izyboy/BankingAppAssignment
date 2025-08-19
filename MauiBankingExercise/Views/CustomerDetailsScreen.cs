using MauiBankingExercise.Models;

namespace MauiBankingExercise.Views
{
    internal class CustomerDetailsScreen : Page
    {
        private Customer selectedCustomer;

        public CustomerDetailsScreen(Customer selectedCustomer)
        {
            this.selectedCustomer = selectedCustomer;
        }
    }
}
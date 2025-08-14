using MauiBankingExercise.Views;
using MauiBankingExercise.Models;
namespace MauiBankingExercise.Views;

public partial class CustomerSelectionScreen : ContentPage
{
	public CustomerSelectionScreen()
	{
		InitializeComponent();
	}
	private void OnCustomerSelected(object sender, SelectionChangedEventArgs e)
	{
		// Handle the selection of a customer
		if (e.CurrentSelection.FirstOrDefault() is Customer selectedCustomer)
		{
			// Navigate to the next screen with the selected customer
			Navigation.PushAsync(new CustomerDetailsScreen(selectedCustomer));
		}
    }
}
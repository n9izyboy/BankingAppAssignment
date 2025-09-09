using MauiBankingExercise.Views;
using MauiBankingExercise.Models;

using MauiBankingExercise.ViewModels;
namespace MauiBankingExercise.Views;

public partial class CustomerSelectionScreen : ContentPage
{
	public CustomerSelectionScreen(CustomerSelectionScreenViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }

}
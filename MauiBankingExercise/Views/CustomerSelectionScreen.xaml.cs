using MauiBankingExercise.Views;
using MauiBankingExercise.Models;

using MauiBankingExercise.ViewModels;
namespace MauiBankingExercise.Views;

public partial class CustomerSelectionScreen : ContentPage
{
	public CustomerSelectionScreen(AllBankViewModels vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }

}
namespace MauiBankingExercise;
using MauiBankingExercise.Views;

    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("customers", typeof(CustomerSelectionScreen));
            Routing.RegisterRoute("transaction", typeof(TransactionScreen));
        }
    }


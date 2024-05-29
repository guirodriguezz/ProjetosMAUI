namespace AppControleFinanceiro.Views;

public partial class TransactionAdd : ContentPage
{
    public TransactionAdd()
    {
        InitializeComponent();
    }
    
    private void TapGestureRecognizer_OnTapped(object? sender, TappedEventArgs e)
    {
        Navigation.PopModalAsync();
    }
}
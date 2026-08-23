using LernPlattform.App.ViewModels;

namespace LernPlattform.App.Views;

public partial class BereichePage : ContentPage
{
    private readonly BereicheViewModel _vm;

    public BereichePage(BereicheViewModel vm)
    {
        InitializeComponent();
        _vm = vm;
        BindingContext = vm;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _vm.LadenCommand.ExecuteAsync(null);
    }
}
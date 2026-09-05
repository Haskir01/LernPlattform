using LernPlattform.App.ViewModels;

namespace LernPlattform.App.Views;

public partial class KursPage : ContentPage
{
	private readonly KursViewModel _vm;
	public KursPage(KursViewModel vm)
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
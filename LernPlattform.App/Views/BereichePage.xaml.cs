using LernPlattform.App.ViewModels;

namespace LernPlattform.App.Views;

public partial class BereichePage : ContentPage
{
    private readonly BereicheViewModel _vm;

    // Konstruktor: Initialisiert die Seite und setzt das ViewModel als BindingContext.
    public BereichePage(BereicheViewModel vm)
    {
        InitializeComponent();
        _vm = vm;
        BindingContext = vm;
    }

    // Wird beim Anzeigen der Seite aufgerufen; startet das Laden der Daten.
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _vm.LadenCommand.ExecuteAsync(null);
    }
}
using Microsoft.Extensions.DependencyInjection;

namespace LernPlattform.App;

public partial class App : Application
{
	// Konstruktor: Initialisiert die App und lädt die UI-Komponenten.
	public App()
	{
		InitializeComponent();
	}

	// Erstellt das Hauptfenster der App und gibt es zurück.
	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}
}
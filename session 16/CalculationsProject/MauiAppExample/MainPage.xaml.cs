namespace MauiAppExample;

public partial class MainPage : ContentPage
{
	int count = 0;
	RecruitmentSystem system;
	public MainPage()
	{
		InitializeComponent();
		system=new RecruitmentSystem();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


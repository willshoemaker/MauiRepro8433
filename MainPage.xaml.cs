namespace ListViewBindingIssueRepro;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainPageViewModel()
        {
            PreLoadedParagraphs = new List<ListItemViewModel?>
            {
                new ListItemViewModel()
                {
                    Heading = "Preloaded Item1",
                    Body = "Preloaded text"
                },
                new ListItemViewModel()
                {
                    Heading = "Preloaded Item2",
                    Body = "More preloaded text"
                },
            }
        };

		Loaded += MainPage_Loaded;

    }

	private async void MainPage_Loaded(object? sender, EventArgs e)
	{
		await Task.Delay(1000);
        (BindingContext as MainPageViewModel).Paragraphs = new List<ListItemViewModel?>()
            {
                new ListItemViewModel
                {
                    Heading = "Item1",
                    Body = "This is some text"
                },
                new ListItemViewModel
                {
                    Heading = "Item2",
                    Body = "This is more text"
                },
            };
	}
}


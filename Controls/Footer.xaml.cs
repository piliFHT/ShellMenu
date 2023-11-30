namespace ShellMenu.Controls;

public partial class Footer : ContentView
{
	IDispatcherTimer timer { get; set; }



	public Footer()
	{
		InitializeComponent();
	

		timer = Dispatcher.CreateTimer();
		timer.Interval = TimeSpan.FromMicroseconds(1000);
		timer.Tick += (s, e) =>
		{
			Cas.Text = DateTime.Now.ToLongTimeString();
		};
		timer.Start();
	}
}
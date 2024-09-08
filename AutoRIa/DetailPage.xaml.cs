using TaskManager.Resources.ViewModel;

namespace TaskManager;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
        InitializeComponent();
		BindingContext = vm;
	}
}
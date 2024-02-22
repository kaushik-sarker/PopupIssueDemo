using CommunityToolkit.Maui.Views;

namespace PopupIssueDemo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var spinner = new SpinnerPopup();
            this.ShowPopup(spinner);

            // A dummy network request.
            await Task.Delay(250);

            // This will fail to close the popup. Make the delay to 300ms or more, it will work
            await spinner.CloseAsync();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            // This works fine.
            var spinner = new SpinnerPopup();
            this.ShowPopup(spinner);
            await Task.Delay(250);
            await spinner.CloseAsync();
        }
    }

}

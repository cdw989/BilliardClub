using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;

namespace BilliardClub.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private NavigationService NavigationService = new NavigationService();
        public RelayCommand ScoreKeeper { get; set; }
        public object Frame { get; private set; }

        public MainViewModel()
        {
            NavigationService.Configure("ScoreKeeper", typeof(ScoreKeeper));

            ScoreKeeper = new RelayCommand(GoToScoreKeeper);
        }

        private void GoToScoreKeeper()
        {
            NavigationService.NavigateTo("ScoreKeeper");
        }
    }
}

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace BilliardClub.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public string Title { get; set; }

        public RelayCommand ScoreKeeper { get; set; }

        public MainViewModel()
        {
            Title = "Test";
            ScoreKeeper = new RelayCommand(GoToScoreKeeper);
        }

        private void GoToScoreKeeper()
        {
            Title = "Changed";
        }
    }
}

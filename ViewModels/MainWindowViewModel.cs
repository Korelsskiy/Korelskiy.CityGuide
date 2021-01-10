using Korelskiy.CityGuide.Models.Guide;
using Korelskiy.CityGuide.ViewModels.Base;
using Korelskiy.StyudingWPF1.Infrastructure.Commands;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Korelskiy.CityGuide.ViewModels
{
    internal class MainWindowViewModel: ViewModel
    {
        public ICommand CloseApplicationCommand { get; }

        private bool CanCloseApplicationCommandExecute(object p) => true;
        private void OnCloseApplicationCommand(object p) => Application.Current.Shutdown();
        public ObservableCollection<State> States { get; }
        public ObservableCollection<City> AllCities { get; }

        private State _selectedState;
        public State SelectedState
        {
            get => _selectedState;
            set => Set(ref _selectedState, value);
        }

        private int _rowIndex = 0;
        public int RowIndex
        {
            get => _rowIndex++;
            set => Set(ref _rowIndex, value);
        }
        public MainWindowViewModel()
        {
            City.AddCities();

            State.GetStates(City.Cities);

            City.PopulationChange(City.Cities);

            States = new ObservableCollection<State>(State.States);
           
            AllCities = new ObservableCollection<City>(City.Cities);

            CloseApplicationCommand = new LyambdaCommand(OnCloseApplicationCommand, CanCloseApplicationCommandExecute);
        }
    }
}

using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace AiEffects.TestApp.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private string _title;
        public string Title {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private string _InputTestPageText;
        public string InputTestPageText {
            get { return _InputTestPageText; }
            set { SetProperty(ref _InputTestPageText, value); }
        }

        private DelegateCommand<object> _GotoTestCommand;
        public DelegateCommand<object> GotoTestCommand {
            get { return _GotoTestCommand = _GotoTestCommand ?? new DelegateCommand<object>(async (p) => {
                await Navigation.NavigateAsync(p.ToString(),null,false); 
            }); }
        } 


        private INavigationService Navigation;
        public MainPageViewModel(INavigationService navigationService)
        {
            Navigation = navigationService;
        }
    }
}


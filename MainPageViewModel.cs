using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ListViewBindingIssueRepro
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? callerMemberName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(callerMemberName));
        }
        private List<ListItemViewModel?> _paragraphs = new();
        private List<ListItemViewModel?> _preLoadedParagraphs = new();
        public List<ListItemViewModel?> Paragraphs
        {
            get => _paragraphs;
            set
            {
                _paragraphs = value;
                OnPropertyChanged();
            }
        }

        public List<ListItemViewModel?> PreLoadedParagraphs
        {
            get => _preLoadedParagraphs;
            set
            {
                _preLoadedParagraphs = value;
                OnPropertyChanged();
            }
        }
    }

    public class ListItemViewModel : INotifyPropertyChanged
    {
        private string? _heading;
        private string? _body;

        private void OnPropertyChanged([CallerMemberName] string? callerMemberName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(callerMemberName));
        }

        public string? Heading
        {
            get => _heading;
            set
            {
                _heading = value;
                OnPropertyChanged();
            }
        }
        public string? Body
        {
            get => _body;
            set
            {
                _body = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}

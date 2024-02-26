using ReactiveUI;
using System.Collections.ObjectModel;

namespace MusicStore.ViewModels
{
    public class MusicStoreViewModel : ViewModelBase
    {
        private string? _searchText;
        private bool _isBusy;
        private AlbumViewModel? _selectedAlbum;
        public ObservableCollection<AlbumViewModel> SearchResults { get; } = new();

        public MusicStoreViewModel()
        {
            SearchResults.Add(new AlbumViewModel());
            SearchResults.Add(new AlbumViewModel());
            SearchResults.Add(new AlbumViewModel());
        }

        public string? SearchText
        {
            get => _searchText;
            set => this.RaiseAndSetIfChanged(ref _searchText, value);
        }

        public bool IsBusy
        {
            get => _isBusy;
            set => this.RaiseAndSetIfChanged(ref _isBusy, value);
        }

        public AlbumViewModel? SelectedAlbum
        {
            get => _selectedAlbum;
            set => this.RaiseAndSetIfChanged(ref _selectedAlbum, value);
        }
    }
}

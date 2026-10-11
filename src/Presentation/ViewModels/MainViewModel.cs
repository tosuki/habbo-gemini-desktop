using System.Collections.ObjectModel;
using HabboGemini.Domain.Enums;
using HabboGemini.Presentation.ViewModels.Common;

namespace HabboGemini.Presentation.ViewModels;

public class MainViewModel : ViewModelBase
{
    private string _title = "HabboGemini - AI Operations Room";
    private ChatSessionViewModel? _selectedSession;

    public string Title
    {
        get => _title;
        set => SetProperty(ref _title, value);
    }

    public ObservableCollection<ChatSessionViewModel> Sessions { get; } = new();

    public ChatSessionViewModel? SelectedSession
    {
        get => _selectedSession;
        set => SetProperty(ref _selectedSession, value);
    }

    public MainViewModel()
    {
        // Sessões iniciais para demonstração / pré-visualização na interface
        Sessions.Add(new ChatSessionViewModel("1", "Jarvis", "Sessão principal ativa", AgentState.Trabalhando));
        Sessions.Add(new ChatSessionViewModel("2", "Friday", "Subagente pesquisador", AgentState.Aguardando));
    }
}

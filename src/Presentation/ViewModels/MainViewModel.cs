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
    public ObservableCollection<ConnectionViewModel> Connections { get; } = new();
    public ChatSessionViewModel? SelectedSession
    {
        get => _selectedSession;
        set => SetProperty(ref _selectedSession, value);
    }

    public MainViewModel()
    {
        ChatSessionViewModel jarvis = new ChatSessionViewModel("1", "Jarvis", "Sessão principal", AgentState.Trabalhando)
        {
            X = 80,
            Y = 60
        };

        ChatSessionViewModel friday = new ChatSessionViewModel("2", "Friday", "Subagente pesquisador", AgentState.Delegando)
        {
            X = 340,
            Y = 60
        };

        ChatSessionViewModel ultron = new ChatSessionViewModel("3", "Ultron", "Subagente executor", AgentState.Concluida)
        {
            X = 210,
            Y = 220
        };

        Sessions.Add(jarvis);
        Sessions.Add(friday);
        Sessions.Add(ultron);

        Connections.Add(new ConnectionViewModel(jarvis, friday));
        Connections.Add(new ConnectionViewModel(jarvis, ultron));
    }
}

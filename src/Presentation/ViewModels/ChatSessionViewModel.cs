using HabboGemini.Domain.Enums;
using HabboGemini.Presentation.ViewModels.Common;

namespace HabboGemini.Presentation.ViewModels;

public class ChatSessionViewModel : ViewModelBase
{
    private string _id;
    private string _name;
    private string _description;
    private AgentState _state;

    public string Id
    {
        get => _id;
        set => SetProperty(ref _id, value);
    }

    public string Name
    {
        get => _name;
        set => SetProperty(ref _name, value);
    }

    public string Description
    {
        get => _description;
        set => SetProperty(ref _description, value);
    }

    public AgentState State
    {
        get => _state;
        set => SetProperty(ref _state, value);
    }

    public ChatSessionViewModel(
        string id,
        string name,
        string description = "",
        AgentState state = AgentState.Trabalhando)
    {
        _id = id;
        _name = name;
        _description = description;
        _state = state;
    }
}

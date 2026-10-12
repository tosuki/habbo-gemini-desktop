using System;
using Avalonia;
using HabboGemini.Domain.Enums;
using HabboGemini.Presentation.ViewModels.Common;

namespace HabboGemini.Presentation.ViewModels;

public class ChatSessionViewModel : ViewModelBase
{
    private string _id;
    private string _name;

    private string _description;
    private AgentState _state;

    private double _x;
    private double _y;
    private double _width = 180;
    private double _height = 80;

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

    public double X
    {
        get => _x;
        set
        {
            if (SetProperty(ref _x, value))
            {
                OnPositionChanged?.Invoke();
            }
        }
    }

    public double Y
    {
        get => _y;
        set
        {
            if (SetProperty(ref _y, value))
            {
                OnPositionChanged?.Invoke();
            }
        }
    }

    public double Width
    {
        get => _width;
        set => SetProperty(ref _width, value);
    }

    public double Height
    {
        get => _height;
        set => SetProperty(ref _height, value);
    }

    public Point CenterPoint => new(X + Width / 2, Y + Height / 2);

    public event Action? OnPositionChanged;

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

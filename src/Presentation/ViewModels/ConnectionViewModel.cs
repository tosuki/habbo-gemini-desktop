using Avalonia;
using HabboGemini.Presentation.ViewModels;
using HabboGemini.Presentation.ViewModels.Common;

public class ConnectionViewModel : ViewModelBase
{
    public ChatSessionViewModel Source { get; }
    public ChatSessionViewModel Target { get; }

    private Point _startPoint;
    private Point _endPoint;

    public Point StartPoint { get => _startPoint; set => SetProperty(ref _startPoint, value); }
    public Point EndPoint { get => _endPoint; set => SetProperty(ref _endPoint, value); }

    public ConnectionViewModel(
        ChatSessionViewModel Source,
        ChatSessionViewModel Target
    )
    {
        this.Source = Source;
        this.Target = Target;

        this.Source.OnPositionChanged += UpdatePoints;
        this.Target.OnPositionChanged += UpdatePoints;

        UpdatePoints();
    }

    public void UpdatePoints()
    {
        StartPoint = Source.CenterPoint;
        EndPoint = Target.CenterPoint;
    }
}
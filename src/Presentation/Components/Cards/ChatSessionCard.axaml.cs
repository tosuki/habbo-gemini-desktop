using Avalonia;
using Avalonia.Controls;

namespace HabboGemini.Presentation.Components.Cards;

public partial class ChatSessionCard : UserControl
{
    public static readonly StyledProperty<string> SessionNameProperty =
        AvaloniaProperty.Register<ChatSessionCard, string>(nameof(SessionName), "Gemini");

    public static readonly StyledProperty<string> SessionDescriptionProperty =
        AvaloniaProperty.Register<ChatSessionCard, string>(nameof(SessionDescription), string.Empty);

    public string SessionName
    {
        get => GetValue(SessionNameProperty);
        set => SetValue(SessionNameProperty, value);
    }

    public string SessionDescription
    {
        get => GetValue(SessionDescriptionProperty);
        set => SetValue(SessionDescriptionProperty, value);
    }

    public ChatSessionCard()
    {
        InitializeComponent();
    }
}
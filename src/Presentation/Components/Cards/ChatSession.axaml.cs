using Avalonia;
using Avalonia.Controls;

namespace HabboGemini.src.presentation.Components.Cards;

public partial class ChatSession : UserControl
{
    public static readonly StyledProperty<string> SessionNameProperty =
        AvaloniaProperty.Register<ChatSession, string>(nameof(SessionName), "Gemini");

    public string SessionName {
        get => GetValue(SessionNameProperty);
        set => SetValue(SessionNameProperty, value);
    }

    public ChatSession()
    {
        InitializeComponent();
    }
}
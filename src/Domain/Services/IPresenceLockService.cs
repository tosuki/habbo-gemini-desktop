namespace HabboGemini.Domain.Services;

public interface IPresenceLockService
{
    bool IsSessionActive(string conversationId);
}

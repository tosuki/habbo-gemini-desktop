using System.Collections.Generic;
using System.Threading.Tasks;
using HabboGemini.Domain.Models;

namespace HabboGemini.Domain.Services;

public interface IGeminiReader
{
    Task<IReadOnlyList<ChatSession>> GetRecentConversationsAsync(int limit = 50);
}

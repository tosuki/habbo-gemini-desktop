using System;
using HabboGemini.Domain.Enums;

namespace HabboGemini.Domain.Models;

public record AgentExecution(
    string ConversationId,
    string? ParentConversationId,
    string? AgentName,
    AgentState State,
    DateTime LastModifiedTime,
    string WorkspaceUri
);

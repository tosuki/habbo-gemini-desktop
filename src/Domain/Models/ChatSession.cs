using System;
using HabboGemini.Domain.Enums;

namespace HabboGemini.Domain.Models;

public record ChatSession(
    string Id,
    string Name,
    string Description,
    AgentState State,
    DateTime CreatedAt,
    DateTime UpdatedAt
);

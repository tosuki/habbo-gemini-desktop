using System;
using System.Data;

namespace HabboGemini.Infrastructure.Exceptions;

public sealed class DatabaseConnectionException(ConnectionState connectionState, string message) 
    : Exception($"[Connection state: ${connectionState}] - ${message}");

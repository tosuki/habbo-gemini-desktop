using System;
using System.Threading;
using System.Threading.Tasks;
using HabboGemini.Infrastructure.Exceptions;
using Microsoft.Data.Sqlite;

namespace HabboGemini.Infrastructure.Database;

public class DatabaseConnector
{
    private readonly string _connectionUri;
    private readonly SqliteConnection _connection;
    private Task? _connectTask;

    public DatabaseConnector(string connectionString)
    {
        _connectionUri = connectionString;
        _connection = new SqliteConnection(_connectionUri);
    }

    public async Task<SqliteConnection> GetConnectionAsync()
    {
        if (_connection.State == System.Data.ConnectionState.Closed || _connection.State == System.Data.ConnectionState.Broken)
        {
            Console.WriteLine(
                _connection.State switch
                {
                    System.Data.ConnectionState.Broken => "The connection to database got broken for some reason, connecting to database",
                    _ => "Connecting to database"
                }
            );
            await Connect();
        }


        if (_connection.State == System.Data.ConnectionState.Connecting && _connectTask != null)
        {
            Console.WriteLine("Attempt to get the connection. There is already a connection establishment happening.");
            await _connectTask;
        }

        return _connection;
    }

    public async Task Connect()
    {
        _connectTask = _connection.OpenAsync();

        await _connectTask;

        if (_connection.State != System.Data.ConnectionState.Open)
        {
            throw new DatabaseConnectionException(_connection.State, "Failed to open the connection to the database");
        }
    }

}

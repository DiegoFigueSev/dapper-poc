using Dapper;
using DemoDapper.src.Models;
using Microsoft.Data.Sqlite;

namespace DemoDapper.src.Repositories;

public class RoomRepository
{
    private readonly SqliteConnection _connection;

    public RoomRepository(SqliteConnection connection)
    {
        _connection = connection;
    }

    public IEnumerable<Room> FindAll()
    {
        return _connection.Query<Room>(
            """
            SELECT Id, Number, Capacity
            FROM Rooms
            """
        );
    }
}

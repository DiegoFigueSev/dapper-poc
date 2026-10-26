using Dapper;
using DemoDapper.src.Models;
using Microsoft.Data.Sqlite;

namespace DemoDapper.src.Repositories;

public class RoomRepository(SqliteConnection connection)
{
    private readonly SqliteConnection _connection = connection;

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

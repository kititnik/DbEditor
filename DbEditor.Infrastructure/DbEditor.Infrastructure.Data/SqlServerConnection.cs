using System;
using Microsoft.EntityFrameworkCore;

namespace DbEditor.Infrastructure.Data;

public class SqlServerConnection : IDbConnection
{
    public void ConnectToDb(string connectionString, DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
    }
}


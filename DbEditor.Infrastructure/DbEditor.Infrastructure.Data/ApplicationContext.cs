using System;
using Microsoft;
using Microsoft.EntityFrameworkCore;

namespace DbEditor.Infrastructure.Data;

public class ApplicationContext : DbContext
{
    private readonly IDbConnection _dbConnection;
    private readonly string _connectionString;

    public ApplicationContext(IDbConnection dbConnection, string connectionString)
    {
        _dbConnection = dbConnection;
        _connectionString = connectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        _dbConnection.ConnectToDb(_connectionString, optionsBuilder);
    }

}


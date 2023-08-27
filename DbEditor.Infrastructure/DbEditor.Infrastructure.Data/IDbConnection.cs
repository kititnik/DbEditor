using System;
using Microsoft.EntityFrameworkCore;

namespace DbEditor.Infrastructure.Data;

public interface IDbConnection
{
    public void ConnectToDb(string connectionString, DbContextOptionsBuilder optionsBuilder);
}


using boxAmOffice.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace TestAM_box
{
        public abstract class Mock : IDisposable
        {
            private readonly SqliteConnection _connection;
            protected readonly AppDbContext _db;

            public Mock()
            {
                _connection = new SqliteConnection("Filename=:memory:");
                _connection.Open();

                _db = new AppDbContext(
                    new DbContextOptionsBuilder<AppDbContext>()
                        .UseSqlite(_connection)
                        .Options);

                _db.Database.EnsureCreated();
            }

            public void Dispose()
            {
                _db?.Dispose();
                _connection?.Dispose();
            }
        }
    }

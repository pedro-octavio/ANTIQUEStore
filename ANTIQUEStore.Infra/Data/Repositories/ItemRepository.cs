using ANTIQUEStore.Domain.Core.Interfaces.Repositories;
using ANTIQUEStore.Domain.Domain;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ANTIQUEStore.Infra.Data.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly IConfiguration _configuration;
        private readonly string _connectionString;

        public ItemRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration["ConnectionStrings:ANTIQUEStoreDb"];
        }

        public IEnumerable<Item> GetAll()
        {
            try
            {
                using var _mySqlConnection = new MySqlConnection(_connectionString);

                return _mySqlConnection.Query<Item>("SELECT * FROM Items WHERE IsDeleted = 0;").ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Item GetById(int id)
        {
            try
            {
                using var _mySqlConnection = new MySqlConnection(_connectionString);

                return _mySqlConnection.QueryFirstOrDefault<Item>("SELECT * FROM Items WHERE Id = @Id AND IsDeleted = 0;", new { Id = id });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Add(Item item)
        {
            try
            {
                using var _mySqlConnection = new MySqlConnection(_connectionString);

                _mySqlConnection.Execute("INSERT INTO Items (Name, Description, Price, Year, IsDeleted) VALUES (@Name, @Description, @Price, @Year, 0);", item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Item item)
        {
            try
            {
                using var _mySqlConnection = new MySqlConnection(_connectionString);

                _mySqlConnection.Execute("UPDATE Items SET Name = @Name, Description = @Description, Price = @Price, Year = @Year WHERE Id = @Id;", item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Remove(int id)
        {
            try
            {
                using (var _mySqlConnection = new MySqlConnection(_connectionString))

                    _mySqlConnection.Execute("DELETE FROM Items WHERE Id = @id;", new { id });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

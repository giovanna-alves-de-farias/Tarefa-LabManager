using Microsoft.Data.Sqlite;
using LabManager.Models;
using LabManager.Database;
using Dapper;

namespace LabManager.Repositories;

class LabRepository
{
    private readonly DatabaseConfig _databaseConfig;

    public LabRepository(DatabaseConfig databaseConfig)
    {
        _databaseConfig = databaseConfig;
    }
    
    public IEnumerable<Lab> GetAll()
    {
        var labs = new List<Lab>();

        var connection = new SqliteConnection(_databaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Labs;"; 
            
        var reader = command.ExecuteReader();
        
        while (reader.Read())
        {
            var id = reader.GetInt32(0);
            int number = reader.GetInt32(1);
            var name = reader.GetString(2);
            char block = reader.GetChar(3);
            var lab = new Lab(id, number, name, block);
            labs.Add(lab); 
        }
        connection.Close();
        return labs;
    }
    
    public Lab Save(Lab lab)
    {
        var connection = new SqliteConnection(_databaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "INSERT INTO Labs VALUES($id, $number, $name, $block)"; 
        command.Parameters.AddWithValue("$id", lab.Id);
        command.Parameters.AddWithValue("$number", lab.Number);
        command.Parameters.AddWithValue("name", lab.Name);
        command.Parameters.AddWithValue("$block", lab.Block);
            
        command.ExecuteNonQuery();
        connection.Close();

        return lab;
    }

    public void Delete(int id)
    {
        var connection = new SqliteConnection(_databaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "DELETE FROM Labs WHERE id = $id"; 
        command.Parameters.AddWithValue("$id", id);

        command.ExecuteNonQuery();
        connection.Close();
    }
    
    public Lab Update(Lab lab)
    {
        var connection = new SqliteConnection(_databaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = @"
        Update Labs 
        SET 
            number = $number,
            name = $name,
            block = $block
        WHERE id = $id
        "; 

        command.Parameters.AddWithValue("$id", lab.Id);
        command.Parameters.AddWithValue("$number", lab.Number);
        command.Parameters.AddWithValue("$name", lab.Name);
        command.Parameters.AddWithValue("$block", lab.Block);

        command.ExecuteNonQuery();
        connection.Close();

        return lab;
    }

    public Lab GetById(int id)
    {
        var connection = new SqliteConnection(_databaseConfig.ConnectionString);
        connection.Open();

        var command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Labs WHERE id = $id"; 
        command.Parameters.AddWithValue("$id", id);

        var reader = command.ExecuteReader();
        reader.Read();

        int number = reader.GetInt32(1);
        var name = reader.GetString(2);
        char block = reader.GetChar(3);
        var lab = new Lab(id, number, name, block);

        connection.Close();
        return lab;
    }

    internal bool ExistById(int id)
    {
        throw new NotImplementedException();
    }

    private Lab ReaderToLab(SqliteDataReader  reader)
    {
        var lab = new Lab(reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2),  reader.GetChar(3));
        return lab;
    }

}
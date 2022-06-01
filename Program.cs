﻿using Microsoft.Data.Sqlite;

var connection = new SqliteConnection("Data Source=database.db");
connection.Open();

var command = connection.CreateCommand();
command.CommandText = @"
    CREATE TABLE IF NOT EXISTS Computers(
        id int not null primary key,
        ram varchar(100) not null,
        processor varchar(100) not null
    );
";

command.ExecuteNonQuery();
connection.Close();

// Routing

var modelName = args[0];
var modelAction = args[1];

if(modelName == "Computer")
{
    if(modelAction == "List")
    {
        Console.WriteLine("Computer List");
        connection = new SqliteConnection("Data Source=database.db");
        connection.Open();

        command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Computers";

        var reader = command.ExecuteReader();

        while(reader.Read())
        {
            Console.WriteLine("{0}, {1}, {2}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
        }

        connection.Close();
    }

    if(modelAction == "New")
    {
        var id = Convert.ToInt32(args[2]);
        string ram = args[3];
        string processor = args[4];
        //Console.WriteLine("Computer New");
        //Console.WriteLine("{0}, {1}, {2}", id, ram, processor);

        connection = new SqliteConnection("Data Source=database.db");
        connection.Open();

        command = connection.CreateCommand();
        command.CommandText = "INSERT INTO Computers VALUES($id, $ram, $processor)";
        command.Parameters.AddWithValue("$id", id);
        command.Parameters.AddWithValue("$ram", ram);
        command.Parameters.AddWithValue("$processor", processor);

        command.ExecuteNonQuery();
        connection.Close();
    }
}

connection.Open();

command.CommandText = @"
    CREATE TABLE IF NOT EXISTS Lab(
        id int not null primary key,
        number int not null,
        name varchar(100) not null,
        block int not null
    );
";

command.ExecuteNonQuery();
connection.Close();

if(modelName == "Lab")
{
    if(modelAction == "List")
    {
        Console.WriteLine("Lab List");
        connection = new SqliteConnection("Data Source=database.db");
        connection.Open();

        command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM Lab";

        var reader = command.ExecuteReader();

        while(reader.Read())
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", reader.GetInt32(0), reader.GetInt32(1), reader.GetString(2), reader.GetInt32(3));
        }

        connection.Close();
    }

    if(modelAction == "New")
    {
        // Console.WriteLine("Lab New");
        var id = Convert.ToInt32(args[2]);
        var number = args[3];
        string name = args[4];
        var block = args[5];

        connection = new SqliteConnection("Data Source=database.db");
        connection.Open();

        command = connection.CreateCommand();
        command.CommandText = "INSERT INTO Lab VALUES($id, $number, $name, $block)";
        command.Parameters.AddWithValue("$id", id);
        command.Parameters.AddWithValue("$number", number);
        command.Parameters.AddWithValue("$name", name);
        command.Parameters.AddWithValue("$block", block);

        command.ExecuteNonQuery();
        connection.Close();
    }
}
using System;
using SQLite;
using TodoList_Flowmodoro.Models;

namespace TodoList_Flowmodoro.Helper;

public class SQLiteDatabaseHelper
{
    readonly SQLiteAsyncConnection _conn;
    public SQLiteDatabaseHelper(string path)
    {
        _conn = new SQLiteAsyncConnection(path);
        _conn.CreateTableAsync<TodoItem>().Wait();
    }

    public Task<int> Insert(TodoItem item)
    {
        return _conn.InsertAsync(item);
    }

    public Task<List<TodoItem>> Update(TodoItem item)
    {
        string sql = "UPDATE TodoItem set Title=?, set Description=? WHERE Id = ?";
        return _conn.QueryAsync<TodoItem>(sql, item.Title, item.Description, item.Id);
    }

    public Task<int> Delete(int id)
    {
        return _conn.Table<TodoItem>().DeleteAsync(i => i.Id == id);
    }

    public Task<List<TodoItem>> GetAll()
    {
        return _conn.Table<TodoItem>().ToListAsync();
    }

    public Task<List<TodoItem>> Search(string q)
    {
        string sql = "SELECT * TodoItem WHERE description LIKE '%" + q + "%'";
        return _conn.QueryAsync<TodoItem>(sql);
    }
}
using System.Collections.Generic;
using AppControleFinanceiro.Models;
using LiteDB;

namespace AppControleFinanceiro.Repositories;   

public class TransactionRepositorie : ITransactionRepositorie
{
    private readonly LiteDatabase _database;
    private const string CollectionName = "transactions";

    public TransactionRepositorie()
    {
        _database = new LiteDatabase("Filename=C://users/AppData/database.db;Connection=Shared");
    }

    public List<Transaction> GetAll()
    {
        return _database
            .GetCollection<Transaction>(CollectionName)
            .Query()
            .OrderByDescending(a => a.Date)
            .ToList();
    }

    public void Add(Transaction transaction)
    {
        var col = _database.GetCollection<Transaction>(CollectionName);

        col.Insert(transaction);
        col.EnsureIndex(a => a.Date);
    }

    public void Update(Transaction transaction)
    {
        var col = _database.GetCollection<Transaction>(CollectionName);

        col.Update(transaction);
    }

    public void Delete(Transaction transaction)
    {
        var col = _database.GetCollection<Transaction>(CollectionName);

        col.Delete(transaction.Id);
    }
}
using System.Collections.Generic;
using AppControleFinanceiro.Models;

namespace AppControleFinanceiro.Repositories;

public interface ITransactionRepositorie
{
    List<Transaction> GetAll();
    void Add(Transaction transaction);
    void Update(Transaction transaction);
    void Delete(Transaction transaction);
}
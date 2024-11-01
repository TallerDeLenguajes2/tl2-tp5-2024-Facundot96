using TP5.Models;

namespace TP5.Repository;

public class BudgetRepository : IBudgetRepository
{
    private readonly string connectionString= "Data Source=Database/Tienda.db;Cache=Shared";
        
    public void createBudget(Budget budget)
    {
        
        throw new NotImplementedException();
    }

    public List<Budget> getBudgets()
    {
        throw new NotImplementedException();
    }

    public void updateBudget(int id)
    {
        throw new NotImplementedException();
    }

    public Budget getBudgetById(int id)
    {
        throw new NotImplementedException();
    }

    public void deleteBudgetById(int id)
    {
        throw new NotImplementedException();
    }
}
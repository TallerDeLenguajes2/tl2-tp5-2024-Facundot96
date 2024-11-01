using TP5.Models;

namespace TP5.Repository;

public interface IBudgetRepository
{
    public void createBudget(Budget budget);
    public List<Budget> getBudgets();
    public void updateBudget(int id);
    public Budget getBudgetById(int id);
    public void deleteBudgetById(int id);
}
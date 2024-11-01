namespace TP5.Models;

public class Budget
{
    private int idBudget;
    private string clientName;
    private List<BudgetProductDetail> details;

    public Budget(int idBudget, string clientName, List<BudgetProductDetail> details)
    {
        this.idBudget = idBudget;
        this.clientName = clientName;
        this.details = details;
    }

    public Budget()
    {
    }

    public int IdBudget
    {
        get => idBudget;
        set => idBudget = value;
    }

    public string ClientName
    {
        get => clientName;
        set => clientName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public List<BudgetProductDetail> Details
    {
        get => details;
        set => details = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    
}
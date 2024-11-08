using Microsoft.AspNetCore.Mvc;
using TP5.Models;
using TP5.Repository;

namespace TP5.Controllers;

[ApiController]
[Route("[controller]")]

public class BudgetController : ControllerBase
{
    private readonly IBudgetRepository _budgetRepository;

    public BudgetController(IBudgetRepository budgetRepository)
    {
        _budgetRepository = budgetRepository;
    }
    
    [HttpPost]
    public ActionResult CreateBudget(Budget budget)
    {
        _budgetRepository.createBudget(budget);
        return Created();
    }

    [HttpPost("{id}/ProductDetail")]
    public ActionResult AddProductDetail(int id, BudgetProductDetail detail)
    {
        _budgetRepository.updateBudget(id, detail);
        return Ok();
    }

    [HttpGet]
    public ActionResult<IEnumerable<Budget>> GetBudgets()
    {
        var budgets = _budgetRepository.getBudgets();
        return Ok(budgets);
    }

    [HttpGet("{id}")]
    public ActionResult<Budget> GetBudgetById(int id)
    {
        var budget = _budgetRepository.getBudgetById(id);
        return Ok(budget);
    }

    [HttpDelete("{id}")]
    public ActionResult DeletePresupuesto(int id)
    {
        _budgetRepository.deleteBudgetById(id);
        return Ok();
    }
}
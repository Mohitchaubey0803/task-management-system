using Microsoft.AspNetCore.Mvc;
using TaskManagementSystem.Models;
using TaskManagementSystem.Repositories;
using TaskManagementSystem.ViewModels;

namespace TaskManagementSystem.Controllers;

public class TaskController : Controller
{
    private readonly ITaskRepository _repo;

    public TaskController(ITaskRepository repo)
    {
        _repo = repo;
    }

    public async Task<IActionResult> Index(string? search)
    {
        var tasks = await _repo.GetAllAsync(search);
        return View(tasks);
    }

    public IActionResult Create() => View();

    [HttpPost]
    public async Task<IActionResult> Create(TaskCreateEditVM vm)
    {
        if (!ModelState.IsValid) return View(vm);

        var task = new TaskItem
        {
            Id = Guid.NewGuid(),
            Title = vm.Title,
            Description = vm.Description,
            DueDate = vm.DueDate,
            Status = vm.Status,
            Remarks = vm.Remarks,
            CreatedOn = DateTime.UtcNow,
            LastUpdatedOn = DateTime.UtcNow,
            CreatedBy = "Admin (1)"
        };

        await _repo.AddAsync(task);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Edit(Guid id)
    {
        var task = await _repo.GetByIdAsync(id);
        if (task == null) return NotFound();

        return View(new TaskCreateEditVM
        {
            Id = task.Id,
            Title = task.Title,
            Description = task.Description,
            DueDate = task.DueDate,
            Status = task.Status,
            Remarks = task.Remarks
        });
    }

    [HttpPost]
    public async Task<IActionResult> Edit(TaskCreateEditVM vm)
    {
        var task = await _repo.GetByIdAsync(vm.Id);
        if (task == null) return NotFound();

        task.Title = vm.Title;
        task.Description = vm.Description;
        task.DueDate = vm.DueDate;
        task.Status = vm.Status;
        task.Remarks = vm.Remarks;
        task.LastUpdatedOn = DateTime.UtcNow;
        task.LastUpdatedBy = "Admin (1)";

        await _repo.UpdateAsync(task);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(Guid id)
    {
        var task = await _repo.GetByIdAsync(id);
        if (task == null) return NotFound();
        return View(task);
    }

    [HttpPost, ActionName("Delete")]
    public async Task<IActionResult> DeleteConfirmed(Guid id)
    {
        await _repo.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Details(Guid id)
    {
        var task = await _repo.GetByIdAsync(id);
        if (task == null) return NotFound();
        return View(task);
    }
}

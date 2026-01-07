namespace TaskManagementSystem.ViewModels;

using System.ComponentModel.DataAnnotations;
using TaskManagementSystem.Models;

public class TaskCreateEditVM
{
    public Guid Id { get; set; }

    [Required]
    public string Title { get; set; } = default!;

    public string? Description { get; set; }

    public DateTime DueDate { get; set; }

    public TaskStatus Status { get; set; }

    public string? Remarks { get; set; }
}

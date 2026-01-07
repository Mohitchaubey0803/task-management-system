using System.ComponentModel.DataAnnotations;

namespace TaskManagementSystem.Models;

public class TaskItem
{
    public Guid Id { get; set; }

    [Required, MaxLength(200)]
    public string Title { get; set; } = default!;

    [MaxLength(1000)]
    public string? Description { get; set; }

    public DateTime DueDate { get; set; }

    [Required]
    public TaskStatus Status { get; set; }

    public string? Remarks { get; set; }

    public DateTime CreatedOn { get; set; }
    public DateTime LastUpdatedOn { get; set; }

    [Required]
    public string CreatedBy { get; set; } = default!;

    public string? LastUpdatedBy { get; set; }
}

public enum TaskStatus
{
    Pending = 1,
    InProgress = 2,
    Completed = 3
}

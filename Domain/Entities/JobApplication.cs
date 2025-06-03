using Domain.Enums;

namespace Domain.Entities;

public class JobApplication
{
    public JobApplicationStatus Status { get; set; } = JobApplicationStatus.Approved;
}
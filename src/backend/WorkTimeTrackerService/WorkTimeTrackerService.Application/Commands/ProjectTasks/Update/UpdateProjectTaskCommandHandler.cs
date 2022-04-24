﻿using MediatR;
using System.Threading;
using System.Threading.Tasks;
using WorkTimeTrackerService.Application.Abstractions.ProjectTasks;
using WorkTimeTrackerService.Domain.Replies.ProjectTasks;

namespace WorkTimeTrackerService.Application.Commands.ProjectTasks.Update
{
  public class UpdateProjectTaskCommandHandler : IRequestHandler<UpdateProjectTaskCommand, ProjectTaskReply>
  {
    private readonly IProjectTaskService _projectTaskService;

    public UpdateProjectTaskCommandHandler(IProjectTaskService projectTaskService)
    {
      _projectTaskService = projectTaskService;
    }

    public async Task<ProjectTaskReply> Handle(UpdateProjectTaskCommand request, CancellationToken cancellationToken)
    {
      return await _projectTaskService.UpdateProjectTask(request.ProjectTask);
    }
  }
}

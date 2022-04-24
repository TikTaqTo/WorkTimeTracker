﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkTimeTrackerService.Domain.EntityModels.Dictionaries;
using WorkTimeTrackerService.Domain.Replies.Dictionaries;

namespace WorkTimeTrackerService.Application.Commands.Dictionaries.ProjectTaskStatuses.Create
{
  public class CreateProjectTaskStatusCommand : IRequest<ProjectTaskStatusReply>
  {
    public ProjectTaskStatus ProjectTaskStatus { get; }

    public CreateProjectTaskStatusCommand(ProjectTaskStatus projectTaskStatus)
    {
      ProjectTaskStatus = projectTaskStatus;
    }
  }
}

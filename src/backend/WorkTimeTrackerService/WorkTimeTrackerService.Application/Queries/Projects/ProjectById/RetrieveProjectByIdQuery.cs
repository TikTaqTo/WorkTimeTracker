using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkTimeTrackerService.Domain.Replies.Projects;

namespace WorkTimeTrackerService.Application.Queries.Projects.ProjectById
{
  public class RetrieveProjectByIdQuery : IRequest<ProjectReply>
  {
    public Guid Id { get; }

    public RetrieveProjectByIdQuery(Guid id)
    {
      Id = id;
    }
  }
}

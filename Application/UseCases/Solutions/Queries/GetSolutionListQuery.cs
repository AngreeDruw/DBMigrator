using ApplicationLayer.DbContext;
using Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.UseCases.Solutions.Queries
{
    public class GetSolutionListQuery : IRequest<List<Solution>>
    {
        public class GetSolutionListQueryHandler : IRequestHandler<GetSolutionListQuery, List<Solution>>
        {
            readonly IEntityDbContext _context;

            public GetSolutionListQueryHandler(IEntityDbContext context)
            {
                _context = context;
            }

            public async Task<List<Solution>> Handle(GetSolutionListQuery request, CancellationToken cancellationToken)
            {
                return await _context.Solutions.ToListAsync(cancellationToken);
            }
        }
    }
}

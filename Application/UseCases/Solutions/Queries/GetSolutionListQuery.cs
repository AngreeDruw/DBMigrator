using ApplicationLayer.DbContext;
using ApplicationLayer.UseCases.Solutions.ViewModels;
using AutoMapper;
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
    public class GetSolutionListQuery : IRequest<List<SolutionsViewModel>>
    {
        private class Handler : IRequestHandler<GetSolutionListQuery, List<SolutionsViewModel>>
        {
            readonly IEntityDbContext _context;
            readonly IMapper _mapper;

            public Handler(
                IEntityDbContext context,
                IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<List<SolutionsViewModel>> Handle(GetSolutionListQuery request, CancellationToken cancellationToken)
            {
                var solution = await _context.Solutions.ToListAsync(cancellationToken);
                return _mapper.Map<List<SolutionsViewModel>>(solution);
            }
        }
    }
}

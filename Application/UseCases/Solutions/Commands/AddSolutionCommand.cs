using ApplicationLayer.DbContext;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.UseCases.Solutions.Commands
{
    public class AddSolutionCommand : IRequest<Solution>
    {
        public string Name { get; set; } = "NoName";
        public string Description { get; set; } = string.Empty;

        public class AddSolutionCommandHandler : IRequestHandler<AddSolutionCommand, Solution>
        {
            readonly IEntityDbContext _context;

            public AddSolutionCommandHandler(IEntityDbContext context)
            {
                _context = context;
            }

            public async Task<Solution> Handle(AddSolutionCommand request, CancellationToken cancellationToken)
            {
                Solution solution = new Solution
                {
                    Name = request.Name,
                    Description = request.Description,
                };

                await _context.Solutions.AddAsync(solution);
                await _context.SaveChangesAsync();

                return solution;
            }
        }
    }
}

using ApplicationLayer.DbContext;
using Domain.Entities;
using MediatR;

namespace ApplicationLayer.UseCases.Solutions.Commands
{
    public class AddSolutionCommand : IRequest<Solution>
    {
        public string Name { get; set; } = "NoName";
        public string Description { get; set; } = string.Empty;

        private class Handler : IRequestHandler<AddSolutionCommand, Solution>
        {
            readonly IEntityDbContext _context;

            public Handler(IEntityDbContext context)
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

using ApplicationLayer.DbContext;
using ApplicationLayer.UseCases.Solutions.Commands;
using ApplicationLayer.UseCases.Solutions.Queries;
using Domain.Entities;
using Infrastructure.EntityDbContext;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Presentation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IMediator _mediator;

        public MainWindow(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

            InitializeComponent();
            RefrechSolutionList();
        }

        private async void btnAddSolution_Click(object sender, RoutedEventArgs e)
        {
            await _mediator.Send(new AddSolutionCommand { Name = "SSS", Description = "DDDD" });
            RefrechSolutionList();
        }

        private async void RefrechSolutionList()
        {
            solutionList.ItemsSource = await _mediator.Send(new GetSolutionListQuery());
        }


    }
}

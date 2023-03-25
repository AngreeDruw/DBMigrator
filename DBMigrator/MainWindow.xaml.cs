﻿using ApplicationLayer.DbContext;
using ApplicationLayer.UseCases.Solutions.Commands;
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

namespace DBMigrator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly EntityContext _context;
        private readonly IMediator _mediator;

        public MainWindow(EntityContext context, IMediator mediator)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));

            InitializeComponent();
            RefrechSolutionList();
        }

        private async void btnAddSolution_Click(object sender, RoutedEventArgs e)
        {
            await _mediator.Send(new AddSolutionCommand { Name = "SSS", Description = "DDDD" });
            RefrechSolutionList();
        }

        private void RefrechSolutionList()
        {
            solutionList.ItemsSource = _context.Solutions.ToList();
        }


    }
}

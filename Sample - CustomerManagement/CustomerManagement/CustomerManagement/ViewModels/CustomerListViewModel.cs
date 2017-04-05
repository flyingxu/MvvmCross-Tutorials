﻿using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using CustomerManagement.Core.Models;

namespace CustomerManagement.Core.ViewModels
{
    public class CustomerListViewModel
        : BaseViewModel
    {
        public IObservableCollection<Customer> Customers { get { return DataStore.Customers; } }

        public ICommand CustomerSelectedCommand
        {
            get
            {
                return new MvxCommand<Customer>(DoCustomerSelect);
            }
        }

        public void DoCustomerSelect(Customer customer)
        {
            ShowViewModel<DetailsCustomerViewModel>(new { customerId = customer.ID });
        }

        public ICommand AddCommand
        {
            get
            {
                return new MvxCommand(DoAdd);
            }
        }

        public void DoAdd()
        {
            ShowViewModel<NewCustomerViewModel>();
        }
    }
}

﻿using InterfaceAbstractDemoLastVersion.Abstract;
using InterfaceAbstractDemoLastVersion.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstractDemoLastVersion.Concrete
{
    public class NeroCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;
        public NeroCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
        }
    }
}

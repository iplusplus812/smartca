using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using SmartCA.Domain.Companies;
using SmartCA.Domain.Employees;
using SmartCA.Infrastructure.DomainBase;

namespace SmartCA.Domain.Projects
{
    public class Project : EntityBase
    {
        private string number;
        private string name;
        private Address address;
        private Company owner;
        private Employee constructionAdministrator;
        private Employee principalInCharge;
        private DateTime? contractDate;
        private DateTime? estimatedStartDate;
        private DateTime? estimatedCompletionDate;
        private DateTime? adjustedCompletionDate;
        private DateTime? currentCompletionDate;
        private DateTime? actualCompletionDate;
        private decimal contingencyAllowanceAmount;
        private decimal testingAllowanceAmount;
        private decimal utilityAllowanceAmount;
        private decimal originalConstructionCost;
        private int totalChangeOrderDays;
        private decimal adjustedConstructionConst;
        private decimal totalChangeOrdersAmount;
        private int totalSqureFeet;
        private int percentComplete;
        private string remarks;
        private decimal aeChangeOrderAmount;
        private string contractReason;
        private string agencyApplicationNumber;
        private string agencyFileNumber;
        private MarketSegment segment;
        private List<Allowance> allowances;
        private List<Contract> contracts;

        public Project(string number,string name):this(null,number,name)
        {
            
        }

        public Project(object key,string number,string name): base(key)
        {
            this.number = number;
            this.name = name;
            this.address = null;
            this.owner = new Company();
            this.constructionAdministrator = null;
            this.principalInCharge = null;
            this.contractDate = null;
            this.estimatedStartDate = null;
            this.estimatedCompletionDate = null;
            this.currentCompletionDate = null;
            this.actualCompletionDate = null;
            this.contingencyAllowanceAmount = 0;
            this.testingAllowanceAmount = 0;
            this.utilityAllowanceAmount = 0;
            this.originalConstructionCost = 0;
            this.totalChangeOrderDays = 0;
            this.adjustedConstructionConst = 0;
            this.totalChangeOrdersAmount = 0;
            this.totalSqureFeet = 0;
            this.percentComplete = 0;
            this.remarks = string.Empty;
            this.aeChangeOrderAmount = 0;
            this.contractReason = string.Empty;
            this.agencyApplicationNumber = string.Empty;
            this.agencyFileNumber = string.Empty;
            this.segment = null;
            this.allowances = new List<Allowance>();
            this.contracts = new List<Contract>();
        }

        public string Number
        {
            get { return this.number; }
        }

        public string Name
        {
            get { return this.name; }
        }

        

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }
    }
}

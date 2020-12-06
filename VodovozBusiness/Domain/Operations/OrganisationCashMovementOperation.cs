using System;
using System.ComponentModel.DataAnnotations;
using QS.DomainModel.Entity;

namespace Vodovoz.Domain.Operations
{
    public class OrganisationCashMovementOperation : PropertyChangedBase, IDomainObject
    {
        public virtual int Id { get; set; }

        DateTime operationTime;
        public virtual DateTime OperationTime {
            get => operationTime;
            set => SetField (ref operationTime, value);
        }
        
        private Organization organisation;
        [Display (Name = "Организация")]
        public virtual Organization Organisation
        {
            get => organisation;
            set => SetField(ref organisation, value);
        }
        
        private decimal amount;
        [Display (Name = "Сумма")]
        public virtual decimal Amount
        {
            get => amount;
            set => SetField(ref amount, value);
        }
    }
}
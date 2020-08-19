using Api.Common.Repository.Contracts.Core.Entities;
using System;

namespace Bryan.TesteGFT.ApplicationService.ViewModels
{
    public abstract class BaseViewModel : IBaseViewModel
    {
        public string AuditUserName { get; set; }
        public Guid Id { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool IsActive { get; set; }
    }
}
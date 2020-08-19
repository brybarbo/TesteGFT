using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Api.Common.Repository.Contracts.Core.Entities
{
    public abstract class AggregateRootBase : IAggregateRoot, IDomainEntity
    {
        public AggregateRootBase()
        {
            this.AppliedEvents = new List<object>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [Required]
        public Guid AuditUserId { get; set; }

        public int Version { get; set; }

        public List<object> AppliedEvents { get; set; }

        public override string ToString()
        {
            return $"Type:{GetType().Name} - Id:{Id}";
        }
    }
}
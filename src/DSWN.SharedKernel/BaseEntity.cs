using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace DSWN.SharedKernel
{
    [ExcludeFromCodeCoverage]
    public abstract class BaseEntity<TId>
    {
        public TId Id { get; set; }
        public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();

#pragma warning disable CS8653 // A default expression introduces a null value for a type parameter.
        protected BaseEntity(TId id)
        {
            if (object.Equals(id, default(TId)))
                throw new ArgumentException("The ID cannot be the type's default value.", "id");

            this.Id = id;
        }
#pragma warning restore CS8653 // A default expression introduces a null value for a type parameter.

#pragma warning disable CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.
        // EF requires an empty constructor
        protected BaseEntity() { }
#pragma warning restore CS8618 // Non-nullable field is uninitialized. Consider declaring as nullable.

        // For simple entities, this may suffice
        // As Eric Evans notes earlier in the course, equality of Entities is frequently not a simple operation
        public override bool Equals(object? otherObject)
        {
            var entity = otherObject as BaseEntity<TId>;
            if (entity != null)
                return this.Equals(entity);

            return base.Equals(otherObject);
        }

        // For the rare case when we want to actually do a reference comparison
        public bool ReferenceEquals(object? otherObject)
        {
            var entity = otherObject as BaseEntity<TId>;
            if (entity != null)
                return base.Equals(entity);

            return base.Equals(otherObject);
        }

#pragma warning disable CS8602 // Dereference of a possibly null reference.
        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
#pragma warning restore CS8602 // Dereference of a possibly null reference.

#pragma warning disable CS8602 // Dereference of a possibly null reference.
        public bool Equals(BaseEntity<TId> other)
        {
            if (other == null)
                return false;

            return this.Id.Equals(other.Id);
        }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
    }
}

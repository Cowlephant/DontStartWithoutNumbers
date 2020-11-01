using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DSWN.SharedKernel
{
    // source: https://enterprisecraftsmanship.com/posts/value-object-better-implementation/
#pragma warning disable CS8610 // Nullability of reference types in type of parameter doesn't match overridden member.
    public abstract class ValueObject
    {
        protected abstract IEnumerable<object> GetEqualityComponents();

#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            if (GetType() != obj.GetType())
                return false;

            var valueObject = (ValueObject)obj;

            return GetEqualityComponents().SequenceEqual(valueObject.GetEqualityComponents());
        }
#pragma warning restore CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).

        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        public override int GetHashCode()
        {
            return GetEqualityComponents()
                .Aggregate(1, (current, obj) =>
                {
                    unchecked
                    {
                        return current * 23 + (obj?.GetHashCode() ?? 0);
                    }
                });
        }

        public static bool operator ==(ValueObject a, ValueObject b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(ValueObject a, ValueObject b)
        {
            return !(a == b);
        }
    }
#pragma warning restore CS8610 // Nullability of reference types in type of parameter doesn't match overridden member.
}

﻿using DSWN.SharedKernel.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DSWN.SharedKernel
{
    public abstract class EnumClassBase<T> : ValueObject, IEnumClass where T : IEnumClass
    {
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }

        protected EnumClassBase(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public override string ToString() => Name;

        public static IEnumerable<string> GetNames() => GetValues().Select(e => e.Name);
        public static T GetValue(int id) => GetValues().First(e => e.Id == id);
        public static T GetValue(string name) => GetValues().First(e => e.Name == name);

#pragma warning disable CS8601 // Possible null reference assignment.
        public static IReadOnlyList<T> GetValues()
        {
            // There are other ways to do that such as filling a collection in the constructor
            return typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(property => (T)property.GetValue(null))
                .ToList();
        }
#pragma warning restore CS8601 // Possible null reference assignment.

        public static IEnumerable<int> GetIds()
        {
            return GetValues().Select(e => e.Id);
        }

        public static explicit operator int(EnumClassBase<T> t) => t.Id; // int value = (int)Role.Author;
        public static explicit operator EnumClassBase<T>(int id) => (dynamic)GetValue(id); // Role role = (Role)1;

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Id;
            yield return Name;
            yield return Description;
        }
    }
}

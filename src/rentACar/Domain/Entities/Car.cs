using System;
using NArchitecture.Core.Persistence.Repositories;

namespace Domain.Entities;

public class Car : Entity<Guid>
{
public string BrandName { get; set; }
}

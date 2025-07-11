﻿namespace TeamManagement.Domain.SeedWork;

public interface IUnitOfWork : IDisposable
{
    Task<bool> SaveAsync(CancellationToken cancellationToken = default);
}

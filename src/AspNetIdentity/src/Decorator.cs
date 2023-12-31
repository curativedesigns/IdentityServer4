﻿
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using System;

namespace IdentityServer4.AspNetIdentity;

internal class Decorator<TService>
{
    public Decorator(TService instance)
    {
        Instance = instance;
    }

    public TService Instance { get; set; }
}

internal class Decorator<TService, TImpl> : Decorator<TService>
    where TImpl : class, TService
{
    public Decorator(TImpl instance) : base(instance)
    {
    }
}

internal class DisposableDecorator<TService> : Decorator<TService>, IDisposable
{
    public DisposableDecorator(TService instance) : base(instance)
    {
    }

    public void Dispose()
    {
        (Instance as IDisposable)?.Dispose();
    }
}
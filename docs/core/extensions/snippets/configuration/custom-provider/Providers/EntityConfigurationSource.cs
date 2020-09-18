﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CustomProvider.Example.Providers
{
    public class EntityConfigurationSource : IConfigurationSource
    {
        private readonly Action<DbContextOptionsBuilder> _optionsAction;

        public EntityConfigurationSource(
            Action<DbContextOptionsBuilder> optionsAction) =>
            _optionsAction = optionsAction;

        public IConfigurationProvider Build(IConfigurationBuilder builder) =>
            new EntityConfigurationProvider(_optionsAction);
    }
}

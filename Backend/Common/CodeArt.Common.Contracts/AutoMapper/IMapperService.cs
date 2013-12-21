using System;
using System.Linq.Expressions;

namespace CodeArt.Common.Contracts.AutoMapper
{
    public interface IMapperService
    {
        void CreateMap<TFrom, TTO>(params Expression<Func<TTO, object>>[] ignoredMembers);
        TTo Map<TFrom, TTo>(TFrom from);
        void AssertConfigurationIsValid();
    }
}
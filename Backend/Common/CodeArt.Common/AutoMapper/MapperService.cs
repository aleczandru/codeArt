using System;
using System.Linq.Expressions;
using AutoMapper;
using CodeArt.Common.Contracts.AutoMapper;

namespace CodeArt.Common.AutoMapper
{
    public class MapperService : IMapperService
    {
        public void CreateMap<TFrom, TTO>(params Expression<Func<TTO , object>>[] ignoredMembers)
        {
            var mappingResult = Mapper.CreateMap<TFrom, TTO>();
            foreach (var ignoredMember in ignoredMembers)
            {
                mappingResult.ForMember(ignoredMember, y => y.Ignore());
            }
        }

        public TTo Map<TFrom , TTo>(TFrom from)
        {
           return Mapper.Map<TFrom, TTo>(from);
        }

        public void AssertConfigurationIsValid()
        {
            Mapper.AssertConfigurationIsValid();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ProjetoBase.Dominio.Entities;
using ProjetoBase.MVC.ViewModels;

namespace ProjetoBase.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected void Configure()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ProcessoViewModel, Processo>();
        }
    }
}
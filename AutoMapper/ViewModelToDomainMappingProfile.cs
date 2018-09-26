using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using ProjetoBase.Dominio.Entities;
using ProjetoBase.MVC.ViewModels;

namespace ProjetoBase.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected void Configure()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Processo, ProcessoViewModel>();
        }

    }
}
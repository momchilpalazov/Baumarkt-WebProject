﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaumarktSystem.Web.ViewModels.Home
{
    public class ApplicationTypeViewModel
    {

        public int Id { get; set; }

        public string Name { get; set; } = null!;


        public List<ApplicationTypeViewModel> ApplicationTypeList { get; set; } = new List<ApplicationTypeViewModel>();


    }
}

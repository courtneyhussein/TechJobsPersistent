﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Employer is required")]
        public int EmployerId { get; set; }

        public List<SelectListItem> Employers { get; set; }
        public List<Skill> Skills { get; set; }

        //Constructor
        public AddJobViewModel(List<Employer> exsistingEmployers, List<Skill> exsistingSkills)
        {
            Skills = exsistingSkills;
            Employers = new List<SelectListItem>();

            foreach(var employer in exsistingEmployers)
            {
                Employers.Add(
                    new SelectListItem
                    {
                        Value = employer.Id.ToString(),
                        Text = employer.Name
                    }
                    );
            }
        }

        public AddJobViewModel() { }
    }
}

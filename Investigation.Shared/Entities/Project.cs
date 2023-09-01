using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Investigation.Shared.Entities
{
    public class Project
    {

        public int Id { get; set; }

        [Display(Name = "Nombre del proyecto")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string NameProject { get; set; }

        [Display(Name = "Fecha de inicio")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string DateInitial { get; set; }

        [Display(Name = "Fecha de Finalización")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string DateFinal { get; set; }

        [Display(Name = "Lider del Proyecto")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string NameLider { get; set; }

        [Display(Name = "Descripción")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string Description { get; set; }


        [Display(Name = "Área de investigación")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string AreaWork { get; set; }




        //[MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        //public string Address { get; set; }

        //public string FullName => $"{FirstName} {LastName}";

        //public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";


    }
}

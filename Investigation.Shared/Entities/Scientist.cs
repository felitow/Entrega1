using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Investigation.Shared.Entities
{
    public class Scientist
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del cientifico")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string nameCientifico { get; set; }

        [Display(Name = "Afiliacion institucional")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string afiliacion { get; set; }

        [Display(Name = "Especialización")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string especializacion { get; set; }

        [Display(Name = "Rol en el proyecto")]
        [MaxLength(100, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        public string rolproyecto { get; set; }

  
    }
}

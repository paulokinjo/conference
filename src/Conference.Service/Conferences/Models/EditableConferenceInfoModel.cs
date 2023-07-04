using System.ComponentModel.DataAnnotations;

namespace Conference.Service.Conferences.Models
{
    public class EditableConferenceInfoModel
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; } = default!;

        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; } = default!;

        [Required(AllowEmptyStrings = false)]
        public string Location { get; set; } = default!;

        public string Tagline { get; set; } = default!;
        public string TwitterSearch { get; set; } = default!;

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        [Display(Name = "Start")]
        public DateTime StartDate { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy/MM/dd}")]
        [Display(Name = "End")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Is Published?")]
        public bool IsPublished { get; set; }
    }
}

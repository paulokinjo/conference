using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Conference.Service.Conferences.Models
{
    public sealed class ConferenceInfoModel : EditableConferenceInfoModel
    {
        public Guid Id { get; set; }
        [StringLength(maximumLength: 6, MinimumLength = 6)]
        public string AccessCode { get; set; } = default!;
        [Display(Name = "Owner")]
        [Required(AllowEmptyStrings = false)]
        public string OwnerName { get; set; } = default!;

        [Display(Name = "Email")]
        [Required(AllowEmptyStrings = false)]
        [RegularExpression(@"[\w-]+(\.?[\w-])*\@[\w-]+(\.[\w-]+)+", ErrorMessageResourceName = "InvalidEmail")]
        public string OwnerEmail { get; set; } = default!;

        [Required(AllowEmptyStrings = false)]
        [RegularExpression(@"^\w+$", ErrorMessageResourceName = "InvalidSlug")]
        public string Slug { get; set; } = default!;

        public bool WasEverPublished { get; set; }

        public ICollection<SeatType> Seats { get; set; } = new ObservableCollection<SeatType>();
    }
}

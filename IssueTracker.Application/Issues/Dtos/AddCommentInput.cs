using System.ComponentModel.DataAnnotations;

namespace IssueTracker.Application.Issues.Dtos
{
    public class AddCommentInput
    {
        [Required]
        [MaxLength(128)]
        public string IssueId { get; set; }

        [Required]
        [MaxLength(65536)]
        public string Message { get; protected set; }
    }
}

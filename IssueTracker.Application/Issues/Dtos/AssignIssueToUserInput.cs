using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IssueTracker.Application.Issues.Dtos
{
    public class AssignIssueToUserInput
    {
        [Required]
        [MaxLength(128)]
        public string IssueId { get; set; }

        [Required]
        [MaxLength(128)]
        public string UserId { get; set; }
    }
}

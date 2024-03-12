using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Duck02.Entities
{
    /// <summary> 
    /// Represents a author entity with essential details
    /// </summary>
    public class Author
    {
        /// <summary>
        /// Initializes a new instance of the Author class.
        /// </summary>
        public Author()
        {
            UpdatedOn = "2020-03-31T00:00:00.000Z";
            TravelDate = "2020-10-30";
        }

        /// <summary>
        /// Primary key for the Author 
        /// </summary>
        [Key]
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Author 
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// TenantId of the Author 
        /// </summary>
        public Guid? TenantId { get; set; }
        /// <summary>
        /// CreatedOn of the Author 
        /// </summary>
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// CreatedBy of the Author 
        /// </summary>
        public Guid? CreatedBy { get; set; }
        /// <summary>
        /// UpdatedOn of the Author 
        /// </summary>
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// UpdatedBy of the Author 
        /// </summary>
        public Guid? UpdatedBy { get; set; }

        /// <summary>
        /// Required field TravelDate of the Author 
        /// </summary>
        [Required]
        public Date TravelDate { get; set; }
        /// <summary>
        /// ReturnDate of the Author 
        /// </summary>
        public Date? ReturnDate { get; set; }
        /// <summary>
        /// Collection navigation property representing associated 
        /// </summary>
        public ICollection<Books>? Books { get; set; }
    }
}
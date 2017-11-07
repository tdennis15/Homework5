using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Homework5.Models
{

    /// <summary>
    /// DMV address change model
    /// </summary>
    public class Model
    {
        ///Address ID, integer as Primary Key
        ///
        public int UserID { get; set; }

        ///DoB 
        ///
        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime DoB { get; set; }

        ///First Name
        ///
        [Required, StringLength(64)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        ///Last Name
        ///
        [Required, StringLength(64)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        ///Middle Name
        ///
        [Required, StringLength(64)]
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        ///Residence Address
        ///
        [Required, StringLength(256)]
        [Display(Name = "New Residence Address")]
        public string RAddress { get; set; }

        ///Residence City
        ///
        [Required, StringLength(64)]
        [Display(Name = "City")]
        public string RCity { get; set; }

        ///Residence State
        ///
        [Required, StringLength(64)]
        [Display(Name = "State")]
        public string RState { get; set; }

        /// <summary>
        /// Residence Zip
        /// </summary>
        [Required]
        [Display(Name = "Zip Code")]
        public string RZip { get; set; }

    }
}
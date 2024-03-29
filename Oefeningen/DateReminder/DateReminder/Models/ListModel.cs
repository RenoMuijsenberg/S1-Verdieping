﻿using System.ComponentModel.DataAnnotations;

namespace DateReminder.Models
{
    public class ListModel
    {
        //Id of list
        [Key]
        public int Id { get; set; }
        
        //Id of user
        public string UserId { get; set; }

        //Name of list
        [Required(ErrorMessage = "List name is required")]
        public string ListName { get; set; }
    }
}

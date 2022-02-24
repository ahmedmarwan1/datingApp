using System;
using System.Collections.Generic;
using DatingApp.API.Models.Data;

namespace DatingApp.API.Dtos
{
    public class UserForDetailsDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive  { get; set; }
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<PhotoForDetailsDto> Photos {get; set;}
    }
}
﻿namespace ApiProjetBlazor.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; } = String.Empty;
        public required string Username { get; set; }
        
    }
}

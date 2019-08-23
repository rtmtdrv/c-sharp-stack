using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace csharp_belt_exam.Models 
{
    [Table("participants")]
    public class Participant 
    {
        [Key]
        public int ParticipantId {get;set;}
        public int UserId {get;set;}
        public int ActivityId {get;set;}
        public User Person {get;set;}
    }
}
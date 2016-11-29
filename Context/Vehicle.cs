namespace Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    [Table("Vehicle")]
    [DataContract]
    public partial class Vehicle
    {
        [DataMember]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [DataMember]
        public string Title { get; set; }

        [StringLength(50)]
        [DataMember]
        public string Type { get; set; }

        [StringLength(50)]
        [DataMember]
        public string Brand { get; set; }

        [StringLength(50)]
        [DataMember]
        public string Model { get; set; }

        [DataMember]
        public int? Year { get; set; }

        [StringLength(50)]
        [DataMember]
        public string Color { get; set; }

        [StringLength(50)]
        [DataMember]
        public string Status { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        [StringLength(500)]
        [DataMember]
        public string Description { get; set; }

        [Required]
        [StringLength(50)]
        [DataMember]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public int Telephone { get; set; }

        [StringLength(200)]
        [DataMember]
        public string Url { get; set; }
    }
}

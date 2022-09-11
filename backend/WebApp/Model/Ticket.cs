﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Model
{
    public class Ticket
    {
        [Key]
        [Required]
        public int TicketId { get; set; }

        public DateTime PurchaseDate { get; set; }

        public int ShowingId { get; set; }

        public int CinemaHallId { get; set; }

        public int RowNumber { get; set; }

        public int ColumnNumber { get; set; }


        //navigation property for ef core
        public Showing? Showing { get; set; }

    }
}

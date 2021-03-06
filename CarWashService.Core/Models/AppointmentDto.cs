﻿namespace CarWashService.Core.Models
{
    public class AppointmentDto
    {

        public int AppointmentId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string StartTime { get; set; }
        public string Comments { get; set; }
        public int ServiceId { get; set; }
        public string ServiceTitle { get; set; }
        public double Amount { get; set; }
        public decimal Cost { get; set; }
    }
}

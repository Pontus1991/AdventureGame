﻿using Hemsida.Models;
using System;
using System.Collections.Generic;

namespace Hemsida.Models.ViewModels
{
    public class EditBookingViewModel
    {
        public List<Room> Rooms { get; set; }
        public Booking Booking { get; set; }
    }
}
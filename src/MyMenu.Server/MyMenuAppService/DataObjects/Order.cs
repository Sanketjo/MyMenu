﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.Azure.Mobile.Server;

namespace MyMenuAppService.DataObjects
{
    public class Order : EntityData
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Number { get; set; }
        public string SpecialInstruction { get; set; }
        public string Address { get; set; }
        public string UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public string Payment { get; set; }
        public string UserName { get; set; }

        // Order Placed, Out for Delivery, Delivered 
        public string Status { get; set; }
        public bool HasFeedback { get; set; }

        public double TotalAmount { get; set; }
        public double Discount { get; set; }
        public string CouponId { get; set; }

        public bool SendSms { get; set; }
        public bool SendEmail { get; set; }
    }
}
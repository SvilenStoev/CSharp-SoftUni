using PersonInfo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Border_Control.Models
{
    public class Robot : IIdentifiable
    {
        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model { get; set; }

        public string Id { get; set; }

    }
}
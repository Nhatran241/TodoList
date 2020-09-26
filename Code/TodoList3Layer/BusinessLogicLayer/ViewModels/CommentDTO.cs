﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.ViewModels
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public int? IdEmployee { get; set; }
        public int? IdWork { get; set; }
        public string CommentContent { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }
    public abstract class EntitiyBase
    {
        public EntityStateOption EntityState { get; set; }
        public bool HasChanges { get; set; }
        public bool IsNew { get; private set; }

        //public bool IsValid
        //{
        //    get { return Validate(); }
        //}
        public bool IsValid => Validate();
        public abstract bool Validate();
    }
}

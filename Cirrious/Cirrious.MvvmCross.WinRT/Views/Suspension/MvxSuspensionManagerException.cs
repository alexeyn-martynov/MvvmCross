﻿using System;
using Cirrious.CrossCore.Exceptions;

namespace Cirrious.MvvmCross.WinRT.Views
{
    public class MvxSuspensionManagerException : MvxException
    {
        public MvxSuspensionManagerException()
        {
        }

        public MvxSuspensionManagerException(Exception e)
            : base(e, "MvxSuspensionManager failed")
        {

        }
    }
}
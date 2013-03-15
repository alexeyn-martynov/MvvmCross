// IMvxSingleViewModelCache.cs
// (c) Copyright Cirrious Ltd. http://www.cirrious.com
// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
// 
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

using Android.OS;
using Cirrious.MvvmCross.Interfaces.ViewModels;

namespace Cirrious.MvvmCross.Droid.Interfaces
{
    public interface IMvxSingleViewModelCache
    {
        void Cache(IMvxViewModel toCache, Bundle bundle);
        IMvxViewModel GetAndClear(Bundle bundle);
    }
}
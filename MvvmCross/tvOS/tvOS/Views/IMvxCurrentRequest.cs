// IMvxCurrentRequest.cs

// MvvmCross is licensed using Microsoft Public License (Ms-PL)
// Contributions and inspirations noted in readme.md and license.txt
//
// Project Lead - Stuart Lodge, @slodge, me@slodge.com

namespace MvvmCross.tvOS.Views
{
    using MvvmCross.Core.ViewModels;

    public interface IMvxCurrentRequest
    {
        MvxViewModelRequest CurrentRequest { get; }
    }
}
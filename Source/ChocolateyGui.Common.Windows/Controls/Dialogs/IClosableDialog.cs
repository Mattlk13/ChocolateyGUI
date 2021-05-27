﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Chocolatey" file="IClosableDialog.cs">
//   Copyright 2017 - Present Chocolatey Software, LLC
//   Copyright 2014 - 2017 Rob Reynolds, the maintainers of Chocolatey, and RealDimensions Software, LLC
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Threading.Tasks;

namespace ChocolateyGui.Common.Windows.Controls.Dialogs
{
    public interface IClosableDialog<TResult>
    {
        Task<TResult> WaitForClosingAsync();
    }
}
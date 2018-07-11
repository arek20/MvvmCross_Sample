﻿using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace MvvmCross_Sample.Core.ViewModels
{
    public class MenuViewModel : MvxViewModel
    {
        public IMvxCommand ShowTipCalcCommand
        {
            get { return new MvxCommand(() => NavigationService.Navigate<TipViewModel>()); }
        }

        public IMvxCommand ShowSettingsCommand
        {
            get { return new MvxCommand(() => NavigationService.Navigate<SettingsViewModel>()); }
        }
    }
}

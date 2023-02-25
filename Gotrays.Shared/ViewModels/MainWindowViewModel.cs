using System;

namespace Gotrays.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public SettingViewModel SettingViewModel { get; set; } = new();

    public TranscriptViewModel TranscriptViewModel { get; set; } = new();
}
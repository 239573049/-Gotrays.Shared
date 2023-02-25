namespace Gotrays.ViewModels;

public class SettingViewModel : ViewModelBase
{
    /// <summary>
    /// 文字记录最大数量                            
    /// </summary>
    public int TranscriptLongest { get; set; }

    /// <summary>
    /// 图片保存最大数量
    /// </summary>
    public int ImageRecordsLongest { get; set; }
}
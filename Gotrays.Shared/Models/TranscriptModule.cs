using System;

namespace Gotrays.Models;

public class TranscriptModule
{
    /// <summary>
    /// 内容
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// 创建时间
    /// </summary>
    public DateTime CreatedTime { get; set; }

    /// <summary>
    /// 来源
    /// </summary>
    public string Source { get; set; }

    public string Prompt => "来源：" + Source + Environment.NewLine + "创建时间：" + CreatedTime.ToString("yyyy-MM-dd HH:mm:ss");
}
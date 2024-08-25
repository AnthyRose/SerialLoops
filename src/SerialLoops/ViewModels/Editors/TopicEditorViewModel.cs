using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Avalonia.Platform.Storage;
using HaruhiChokuretsuLib.Archive.Data;
using HaruhiChokuretsuLib.Archive.Graphics;
using HaruhiChokuretsuLib.Util;
using ReactiveUI;
using SerialLoops.Assets;
using SerialLoops.Controls;
using SerialLoops.Lib;
using SerialLoops.Lib.Items;
using SerialLoops.Lib.Util;
using SerialLoops.Utility;
using SerialLoops.ViewModels.Dialogs;
using SerialLoops.Views.Dialogs;
using SkiaSharp;

namespace SerialLoops.ViewModels.Editors
{
    public class TopicEditorViewModel : EditorViewModel
    {
        public TopicItem Topic { get; set; }
        public string TopicDisplayName => $"{Topic.DisplayName}";

        public TopicEditorViewModel(TopicItem item, MainWindowViewModel window, Project project, ILogger log) : base(item, window, log, project)
        {
            Topic = item;
        }
    }
}

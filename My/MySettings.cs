// Decompiled with JetBrains decompiler
// Type: Panoramic.My.MySettings
// Assembly: Panoramic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F56D4AC4-83F8-432A-A14A-448D0B48A097
// Assembly location: E:\Programs\steamapps\common\Grand Theft Auto V\scripts\Panoramic.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Panoramic.My
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
  [EditorBrowsable(EditorBrowsableState.Advanced)]
  internal sealed class MySettings : ApplicationSettingsBase
  {
    private static MySettings defaultInstance = (MySettings) SettingsBase.Synchronized((SettingsBase) new MySettings());

    public static MySettings Default
    {
      get
      {
        MySettings defaultInstance = MySettings.defaultInstance;
        return defaultInstance;
      }
    }
  }
}

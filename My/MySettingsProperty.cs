// Decompiled with JetBrains decompiler
// Type: Panoramic.My.MySettingsProperty
// Assembly: Panoramic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F56D4AC4-83F8-432A-A14A-448D0B48A097
// Assembly location: E:\Programs\steamapps\common\Grand Theft Auto V\scripts\Panoramic.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Panoramic.My
{
  [StandardModule]
  [HideModuleName]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal sealed class MySettingsProperty
  {
    [HelpKeyword("My.Settings")]
    internal static MySettings Settings
    {
      get
      {
        MySettings mySettings = MySettings.Default;
        return mySettings;
      }
    }
  }
}

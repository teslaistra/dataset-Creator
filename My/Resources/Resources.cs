// Decompiled with JetBrains decompiler
// Type: Panoramic.My.Resources.Resources
// Assembly: Panoramic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F56D4AC4-83F8-432A-A14A-448D0B48A097
// Assembly location: E:\Programs\steamapps\common\Grand Theft Auto V\scripts\Panoramic.dll

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Panoramic.My.Resources
{
  [StandardModule]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  [HideModuleName]
  internal sealed class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (object.ReferenceEquals((object) My.Resources.Resources.resourceMan, (object) null))
          My.Resources.Resources.resourceMan = new ResourceManager("Panoramic.Resources", typeof (My.Resources.Resources).Assembly);
        return My.Resources.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return My.Resources.Resources.resourceCulture;
      }
      set
      {
        My.Resources.Resources.resourceCulture = value;
      }
    }
  }
}

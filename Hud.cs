// Decompiled with JetBrains decompiler
// Type: Panoramic.Hud
// Assembly: Panoramic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F56D4AC4-83F8-432A-A14A-448D0B48A097
// Assembly location: E:\Programs\steamapps\common\Grand Theft Auto V\scripts\Panoramic.dll

using GTA;
using GTA.Native;
using System;

namespace Panoramic
{
  public class Hud : Script
  {
    public Hud()
    {
      Tick += OnTick;
    }

    public void OnTick(object o, EventArgs e)
    {
      if (!Panoramic.hideHud)
        return;
      Function.Call((Hash) 8187532053442985248L, new InputArgument[0]);
    }
  }
}

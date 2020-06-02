// Decompiled with JetBrains decompiler
// Type: Panoramic.Panoramic
// Assembly: Panoramic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F56D4AC4-83F8-432A-A14A-448D0B48A097
// Assembly location: E:\Programs\steamapps\common\Grand Theft Auto V\scripts\Panoramic.dll

using GTA;
using GTA.Math;
using GTA.Native;
using GTA.UI;

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Panoramic.My;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Panoramic
{
  public class Panoramic : Script
  {
    public static bool hideHud = false;
    public static ScriptSettings config = ScriptSettings.Load("scripts\\panoramic.ini");
    private float cFov;
    private bool cHideHud;
    private bool cPlayerVisible;

    public Panoramic()
    {
     // base.\u002Ector();
      Tick += OnTick;
      if (File.Exists("scripts\\panoramic.ini"))
      {
        this.cFov = (float) Panoramic.config.GetValue<float>("SETTINGS", "FOV", (float)50.0);
        this.cHideHud = (bool) Panoramic.config.GetValue<bool>("SETTINGS", "HUD", true);
        this.cPlayerVisible = (bool) Panoramic.config.GetValue<bool>("SETTINGS", "PLAYERVISIBLE", false);
      }
      else
      {
        Panoramic.config.SetValue<float>("SETTINGS", "FOV", (float) 50.0);
        Panoramic.config.SetValue<bool>("SETTINGS", "HUD", true);
        Panoramic.config.SetValue<bool>("SETTINGS", "PLAYERVISIBLE", false);
        Panoramic.config.Save();
      }
    }

    public void OnTick(object o, EventArgs e)
    {
      if (!this.Cheating("panorama"))
        return;
      string str = "panorama\\" + Conversions.ToString(DateAndTime.Now.Year) + Conversions.ToString(DateAndTime.Now.Month) + Conversions.ToString(DateAndTime.Now.Day) + Conversions.ToString(DateAndTime.Now.Hour) + Conversions.ToString(DateAndTime.Now.Minute) + Conversions.ToString(DateAndTime.Now.Second) + Conversions.ToString(DateAndTime.Now.Millisecond);
      if (!Directory.Exists(str)) Directory.CreateDirectory(str);
      Game.TimeScale= 0.0f;
      Game.Player.Character.IsVisible = this.cPlayerVisible;

      Panoramic.hideHud = this.cHideHud;
      Script.Wait(100);
      Ped character = Game.Player.Character;
      Vector3 position = ( character).Position;
      Vector3 rotation = ( character).Rotation;

      Camera camera = World.CreateCamera(position, rotation, this.cFov);
      camera.Position = position;
      camera.Rotation = new Vector3((float) (rotation.X + 80.0), (float) rotation.Y, (float) rotation.Z);
      World.RenderingCamera = camera; 
      //World.set_RenderingCamera(camera);
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p1.jpg"), ImageFormat.Jpeg);
      camera.Rotation = new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0));

      //camera.set_Rotation(new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p2.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p3.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p4.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p5.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p6.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p7.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p8.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p9.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p10.jpg"), ImageFormat.Jpeg);
            camera.Position = position;
     camera.Rotation = (new Vector3((float) (rotation.X + 40.0), (float) rotation.Y, (float) rotation.Z));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p11.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p12.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p13.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p14.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p15.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p16.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p17.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p18.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p19.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p20.jpg"), ImageFormat.Jpeg);
            camera.Position = position;
            camera.Rotation = (rotation);
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p21.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p22.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p23.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p24.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p25.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p26.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p27.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p28.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p29.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p30.jpg"), ImageFormat.Jpeg);
            camera.Position = position;
            camera.Rotation = (new Vector3((float) (rotation.X - 40.0), (float) rotation.Y, (float) rotation.Z));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p31.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p32.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p33.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p34.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p35.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p36.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p37.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p38.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p39.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p40.jpg"), ImageFormat.Jpeg);
            camera.Position = position;
            camera.Rotation = (new Vector3((float) (rotation.X - 80.0), (float) rotation.Y, (float) rotation.Z));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p41.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p42.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p43.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p44.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p45.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p46.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p47.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p48.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera; 
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p49.jpg"), ImageFormat.Jpeg);
     camera.Rotation = (new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
      World.RenderingCamera = camera;
      Script.Wait(100);
      this.TakeScreenShot().Save(Path.Combine(str, "p50.jpg"), ImageFormat.Jpeg);
      World.DestroyAllCameras();
      World.RenderingCamera = (Camera) null;

      GTA.UI.Notification.Show("Screenshot saved.");

      Game.TimeScale= 1f;
      ((Entity) Game.Player.Character).IsVisible= !this.cPlayerVisible;
      Panoramic.hideHud = !this.cHideHud;
    }

    public bool Cheating(string Cheat)
    {
      return Function.Call<bool>((Hash) 6160435850588389544L, new InputArgument[1]
      {
        Game.GenerateHash(Cheat)
      });
    }

    public Bitmap TakeScreenShot()
    {
      Size blockRegionSize =new Size();
      ref Size local = ref blockRegionSize;
      Rectangle bounds1 = MyProject.Computer.Screen.Bounds;
      int width1 = bounds1.Width;
      bounds1 = MyProject.Computer.Screen.Bounds;
      int height1 = bounds1.Height;
      local = new Size(width1, height1);
      Rectangle bounds2 = MyProject.Computer.Screen.Bounds;
      int width2 = bounds2.Width;
      bounds2 = MyProject.Computer.Screen.Bounds;
      int height2 = bounds2.Height;
      Bitmap bitmap = new Bitmap(width2, height2);
      Graphics.FromImage((Image) bitmap).CopyFromScreen(new Point(0, 0), new Point(0, 0), blockRegionSize);
      return bitmap;
    }

    public void OnAborted()
    {
    }
  }
}

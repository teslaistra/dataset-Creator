using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GTA;
using GTA.Native;
using GTA.UI;
using GTA.Math;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Panoramic.My;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Numerics;
using System.IO;

namespace dataSetCreator
{
    public class Hud : Script
    {
        public Hud()
        {
            Tick += OnTick;
        }

        public void OnTick(object o, EventArgs e)
        {
            if (!Datacreator.hideHud)
                return;
            Function.Call((Hash)8187532053442985248L, new InputArgument[0]);
        }
    }
    public class Datacreator : Script
    {
        public static bool hideHud = false;
        public static ScriptSettings config = ScriptSettings.Load("scripts\\panoramic.ini");
        private float cFov;
        private bool cHideHud;
        private bool cPlayerVisible;

        bool flag = false;
        Vector3 start = new Vector3(0, 0, 0);
        Vector3 finish = new Vector3(0, 0, 0);


        public Datacreator()
        {
            if (File.Exists("scripts\\panoramic.ini"))
            {
                this.cFov = (float)config.GetValue<float>("SETTINGS", "FOV", (float)50.0);
                this.cHideHud = (bool)config.GetValue<bool>("SETTINGS", "HUD", true);
                this.cPlayerVisible = (bool)config.GetValue<bool>("SETTINGS", "PLAYERVISIBLE", false);
            }
            else
            {
                config.SetValue<float>("SETTINGS", "FOV", (float)50.0);
                config.SetValue<bool>("SETTINGS", "HUD", true);
                config.SetValue<bool>("SETTINGS", "PLAYERVISIBLE", false);
                config.Save();
            }
            Tick += OnTick;
            KeyDown += OnKeyDown;
        }

        void OnTick(object sender, EventArgs e)
        {
            if (flag == true)
            {
                GameplayCamera.RelativePitch = -GameplayCamera.RelativePitch;
                hideHud = this.cHideHud;
                makePanorama(25);
                Game.Player.Character.Position += GameplayCamera.Direction;
                finish = Game.Player.Character.Position;
                hideHud = !this.cHideHud;
    
                float dist = Vector3.Distance(start, finish);
                GTA.UI.Notification.Show(dist.ToString());

                Script.Wait(1000);

            }
        }
        void makePanorama(int time)
        {
            string str = "panorama\\" +"x_"+ Game.Player.Character.Position.X.ToString() + "_" + "y_" + Game.Player.Character.Position.Y.ToString() + "_" + "z_" + Game.Player.Character.Position.Z.ToString() + "_";
            if (!Directory.Exists(str)) Directory.CreateDirectory(str);
            StreamWriter sw = new StreamWriter(str+"\\info.txt");
            {
                sw.WriteLine("Position of Player:");
                sw.WriteLine(Game.Player.Character.Position.ToString());
                sw.WriteLine("Rotation of Player: ");
                sw.WriteLine(Game.Player.Character.Rotation.ToString());
                sw.WriteLine("Forward vector of player: ");
                sw.WriteLine(Game.Player.Character.ForwardVector.ToString());
                sw.WriteLine("Position of player camera vector:");
                sw.WriteLine(GameplayCamera.Position.ToString());
                sw.WriteLine("Rotation of player camera vector:");
                sw.WriteLine(GameplayCamera.Rotation.ToString());
            }
            sw.Close();
            Game.TimeScale = 0.0f;
            Game.Player.Character.IsVisible = this.cPlayerVisible;

            Script.Wait(time);
            Ped character = Game.Player.Character;
            Vector3 position = (character).Position;
            Vector3 rotation = (character).Rotation;

            Camera camera = World.CreateCamera(position, rotation, this.cFov);
            camera.Position = position;
            camera.Rotation = new Vector3((float)(rotation.X + 80.0), (float)rotation.Y, (float)rotation.Z);
            World.RenderingCamera = camera;
            //World.set_RenderingCamera(camera);
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p1.jpg"), ImageFormat.Jpeg);
            camera.Rotation = new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0));
            camera.FieldOfView = 360;
            //camera.set_Rotation(new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p2.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p3.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p4.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p5.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p6.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p7.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p8.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p9.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p10.jpg"), ImageFormat.Jpeg);
            camera.Position = position;
            camera.Rotation = (new Vector3((float)(rotation.X + 40.0), (float)rotation.Y, (float)rotation.Z));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p11.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p12.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p13.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p14.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p15.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p16.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p17.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p18.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p19.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p20.jpg"), ImageFormat.Jpeg);
            camera.Position = position;
            camera.Rotation = (rotation);
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p21.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p22.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p23.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p24.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p25.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p26.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p27.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p28.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p29.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p30.jpg"), ImageFormat.Jpeg);
            camera.Position = position;
            camera.Rotation = (new Vector3((float)(rotation.X - 40.0), (float)rotation.Y, (float)rotation.Z));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p31.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p32.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p33.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p34.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p35.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p36.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p37.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p38.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p39.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p40.jpg"), ImageFormat.Jpeg);
            camera.Position = position;
            camera.Rotation = (new Vector3((float)(rotation.X - 80.0), (float)rotation.Y, (float)rotation.Z));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p41.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p42.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p43.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p44.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p45.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p46.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p47.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p48.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p49.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p50.jpg"), ImageFormat.Jpeg);
            World.DestroyAllCameras();
            World.RenderingCamera = (Camera)null;

            GTA.UI.Notification.Show("Screenshot saved.");

            Game.TimeScale = 1f;
            ((Entity)Game.Player.Character).IsVisible = !this.cPlayerVisible;
            hideHud = !this.cHideHud;

        }

        void makePanoramaOptimized(int time)
        {
            string str = "panorama\\" + "x_" + Game.Player.Character.Position.X.ToString() + "_" + "y_" + Game.Player.Character.Position.Y.ToString() + "_" + "z_" + Game.Player.Character.Position.Z.ToString() + "_";
            if (!Directory.Exists(str)) Directory.CreateDirectory(str);
            StreamWriter sw = new StreamWriter(str + "\\info.txt");
            {
                sw.WriteLine("Position of Player:");
                sw.WriteLine(Game.Player.Character.Position.ToString());
                sw.WriteLine("Rotation of Player: ");
                sw.WriteLine(Game.Player.Character.Rotation.ToString());
                sw.WriteLine("Forward vector of player: ");
                sw.WriteLine(Game.Player.Character.ForwardVector.ToString());
                sw.WriteLine("Position of player camera vector:");
                sw.WriteLine(GameplayCamera.Position.ToString());
                sw.WriteLine("Rotation of player camera vector:");
                sw.WriteLine(GameplayCamera.Rotation.ToString());
            }
            sw.Close();
            Game.TimeScale = 0.0f;
            Game.Player.Character.IsVisible = this.cPlayerVisible;

            Script.Wait(time);
            Ped character = Game.Player.Character;
            Vector3 position = (character).Position;
            Vector3 rotation = (character).Rotation;

            Camera camera = World.CreateCamera(position, rotation, this.cFov);
            camera.Position = position;
            camera.Rotation = new Vector3((float)(rotation.X + 80.0), (float)rotation.Y, (float)rotation.Z);
            World.RenderingCamera = camera;
            //World.set_RenderingCamera(camera);
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p1.jpg"), ImageFormat.Jpeg);
            camera.Rotation = new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0));
            //camera.FieldOfView = 360;
            //camera.set_Rotation(new Vector3((float) camera.Rotation.X, (float) camera.Rotation.Y, (float) (camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p2.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p3.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p4.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p5.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p6.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p7.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p8.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p9.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p10.jpg"), ImageFormat.Jpeg);

            camera.Position = position;
            camera.Rotation = (new Vector3((float)(rotation.X + 40.0), (float)rotation.Y, (float)rotation.Z));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p11.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p12.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p13.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p14.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p15.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p16.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p17.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p18.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p19.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p20.jpg"), ImageFormat.Jpeg);

            camera.Position = position;
            camera.Rotation = (rotation);
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p21.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p22.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p23.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p24.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p25.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p26.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p27.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p28.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p29.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p30.jpg"), ImageFormat.Jpeg);

            camera.Position = position;
            camera.Rotation = (new Vector3((float)(rotation.X - 40.0), (float)rotation.Y, (float)rotation.Z));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p31.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p32.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p33.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p34.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p35.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p36.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p37.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p38.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p39.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p40.jpg"), ImageFormat.Jpeg);
            camera.Position = position;
            camera.Rotation = (new Vector3((float)(rotation.X - 80.0), (float)rotation.Y, (float)rotation.Z));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p41.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p42.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p43.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p44.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p45.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p46.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p47.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p48.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p49.jpg"), ImageFormat.Jpeg);
            camera.Rotation = (new Vector3((float)camera.Rotation.X, (float)camera.Rotation.Y, (float)(camera.Rotation.Z + 35.0)));
            World.RenderingCamera = camera;
            Script.Wait(time);
            this.TakeScreenShot().Save(Path.Combine(str, "p50.jpg"), ImageFormat.Jpeg);
            World.DestroyAllCameras();
            World.RenderingCamera = (Camera)null;

            GTA.UI.Notification.Show("Screenshot saved.");

            Game.TimeScale = 1f;
            ((Entity)Game.Player.Character).IsVisible = !this.cPlayerVisible;
            hideHud = !this.cHideHud;

            GTA.UI.Notification.Show(GameplayCamera.FieldOfView.ToString());

        }


        public Bitmap TakeScreenShot()
        {
            Size blockRegionSize = new Size();
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
            Graphics.FromImage((Image)bitmap).CopyFromScreen(new Point(0, 0), new Point(0, 0), blockRegionSize);
            return bitmap;
        }
        void OnKeyDown(object sender, KeyEventArgs e)
        {
            
            if(e.KeyCode == Keys.H)
            {
                //GTA.UI.Notification.Show(GameplayCamera.RelativePitch.ToString());
                GameplayCamera.RelativePitch = -GameplayCamera.RelativePitch;
                /*GTA.UI.Screen.ShowSubtitle("ForwardVector");
                GTA.UI.Screen.ShowSubtitle("X: " + Game.Player.Character.ForwardVector.X.ToString() +" Y: "+Game.Player.Character.ForwardVector.Y.ToString()+ " Z: " +Game.Player.Character.ForwardVector.Z.ToString());
                Script.Wait(5000);

                GTA.UI.Screen.ShowSubtitle("FrontPosition");
                Script.Wait(2000);
                GTA.UI.Screen.ShowSubtitle("X: " + Game.Player.Character.FrontPosition.X + " Y: " + Game.Player.Character.FrontPosition.Y.ToString() + " Z: " + Game.Player.Character.FrontPosition.Z.ToString());
                Script.Wait(5000);

                GTA.UI.Screen.ShowSubtitle("AbovePosition");
                Script.Wait(2000);
                GTA.UI.Screen.ShowSubtitle("X: " + Game.Player.Character.AbovePosition.X + " Y: " + Game.Player.Character.AbovePosition.Y.ToString() + " Z: " + Game.Player.Character.AbovePosition.Z.ToString());
                Script.Wait(5000);

                GTA.UI.Screen.ShowSubtitle("GetPositionOffset");
                Script.Wait(2000);

                GTA.UI.Screen.ShowSubtitle(Game.Player.Character.GetPositionOffset(Game.Player.Character.FrontPosition).ToString());
                */
                //Game.Player.WantedLevel = 5;
            }
            if(e.KeyCode == Keys.V)
            {
                GTA.UI.Notification.Show(GameplayCamera.FieldOfView.ToString());
                GTA.Game.Player.Money += 10000;
            }
            if (e.KeyCode == Keys.J)
            {
                start = Game.Player.Character.Position;
                Game.Player.WantedLevel = 0; 
                GTA.UI.Notification.Show("Начинаем мерить дистанцию");                
                flag = true;
            }
            if (e.KeyCode == Keys.C)
            {
                finish = Game.Player.Character.Position;


                float dist = Vector3.Distance(start, finish);
                Script.Wait(1000);
                GTA.UI.Notification.Show(dist.ToString());

                flag = false;
                //GTA.UI.Notification.Show(GameplayCamera.Direction.ToString());
                //Ped character = Game.Player.Character;
                //Game.Player.Character.Position += GameplayCamera.Direction;

                /*
                Camera camera = World.CreateCamera(position, rotation, 50);
                camera.Position = position;
                camera.Rotation = new Vector3((float)(rotation.X + 80.0), (float)rotation.Y, (float)rotation.Z);
                World.RenderingCamera = camera; 
                */
            }

        }

        public bool Cheating(string Cheat)
        {
            return Function.Call<bool>((Hash)6160435850588389544L, new InputArgument[1]
            {
                 Game.GenerateHash(Cheat)
            });
        }

    }
}

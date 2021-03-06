﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace SecondScreen
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The VerifyYouTube_Web recording.
    /// </summary>
    [TestModule("f947dc62-2d95-4385-8c8a-356ac13f004a", ModuleType.Recording, 1)]
    public partial class VerifyYouTube_Web : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SecondScreenRepository repository.
        /// </summary>
        public static SecondScreenRepository repo = SecondScreenRepository.Instance;

        static VerifyYouTube_Web instance = new VerifyYouTube_Web();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyYouTube_Web()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VerifyYouTube_Web Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.3.2")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.3.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Init();

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Src='http://wwe-dev.wwe-app.cloud14.wwe.com/f/styles/active_1/public/wweactive/photo/2015/01/1-7/20150105_raw_thennow.jpg') on item 'ShowsWWE.HttpWweDevWweAppCloud14WweComF4'.", repo.ShowsWWE.HttpWweDevWweAppCloud14WweComF4Info, new RecordItemIndex(0));
            Validate.Attribute(repo.ShowsWWE.HttpWweDevWweAppCloud14WweComF4Info, "Src", "http://wwe-dev.wwe-app.cloud14.wwe.com/f/styles/active_1/public/wweactive/photo/2015/01/1-7/20150105_raw_thennow.jpg");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=874,Height=710}) on item 'ShowsWWE.HttpWweDevWweAppCloud14WweComF4'.", repo.ShowsWWE.HttpWweDevWweAppCloud14WweComF4Info, new RecordItemIndex(1));
            Validate.CompareImage(repo.ShowsWWE.HttpWweDevWweAppCloud14WweComF4Info, HttpWweDevWweAppCloud14WweComF4_Screenshot1, HttpWweDevWweAppCloud14WweComF4_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.DeviceAndroidRelease131' at 859;628.", repo.ShowsWWE.DeviceAndroidRelease131Info, new RecordItemIndex(2));
            repo.ShowsWWE.DeviceAndroidRelease131.Click("859;628");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down 2}' with focus on 'ShowsWWE.DeviceAndroidRelease131'.", repo.ShowsWWE.DeviceAndroidRelease131Info, new RecordItemIndex(3));
            repo.ShowsWWE.DeviceAndroidRelease131.PressKeys("{Down 2}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.DeviceAndroidRelease131' at 909;628.", repo.ShowsWWE.DeviceAndroidRelease131Info, new RecordItemIndex(4));
            repo.ShowsWWE.DeviceAndroidRelease131.Click("909;628");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}' with focus on 'ShowsWWE.DeviceAndroidRelease131'.", repo.ShowsWWE.DeviceAndroidRelease131Info, new RecordItemIndex(5));
            repo.ShowsWWE.DeviceAndroidRelease131.PressKeys("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.HttpWweDevWweAppCloud14WweComF4' at 825;678.", repo.ShowsWWE.HttpWweDevWweAppCloud14WweComF4Info, new RecordItemIndex(6));
            repo.ShowsWWE.HttpWweDevWweAppCloud14WweComF4.Click("825;678");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down 8}' with focus on 'ShowsWWE.DeviceAndroidRelease131'.", repo.ShowsWWE.DeviceAndroidRelease131Info, new RecordItemIndex(7));
            repo.ShowsWWE.DeviceAndroidRelease131.PressKeys("{Down 8}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
        CompressedImage HttpWweDevWweAppCloud14WweComF4_Screenshot1
        { get { return repo.ShowsWWE.HttpWweDevWweAppCloud14WweComF4Info.GetScreenshot1(new Rectangle(0, 0, 874, 710)); } }

        Imaging.FindOptions HttpWweDevWweAppCloud14WweComF4_Screenshot1_Options
        { get { return Imaging.FindOptions.Parse("1;None;0,0,874,710;True;10000000;0ms"); } }

#endregion
    }
#pragma warning restore 0436
}

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
    ///The activeContent recording.
    /// </summary>
    [TestModule("7199a9f2-a87b-4092-9822-856cead99937", ModuleType.Recording, 1)]
    public partial class ActiveContent : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SecondScreenRepository repository.
        /// </summary>
        public static SecondScreenRepository repo = SecondScreenRepository.Instance;

        static ActiveContent instance = new ActiveContent();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ActiveContent()
        {
            varURL = "http://qa.wwe-app.cloud6.wwe.com/feeds/wweactive";
            varBrowser = "Chrome";
            varImg1 = "";
            varImg2 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ActiveContent Instance
        {
            get { return instance; }
        }

#region Variables

        string _varBrowser;

        /// <summary>
        /// Gets or sets the value of variable varBrowser.
        /// </summary>
        [TestVariable("eb95e33a-d83c-46b9-aa8d-968fa57e5c73")]
        public string varBrowser
        {
            get { return _varBrowser; }
            set { _varBrowser = value; }
        }

        string _varImg1;

        /// <summary>
        /// Gets or sets the value of variable varImg1.
        /// </summary>
        [TestVariable("64806513-c313-4875-9161-260f5398137a")]
        public string varImg1
        {
            get { return _varImg1; }
            set { _varImg1 = value; }
        }

        string _varImg2;

        /// <summary>
        /// Gets or sets the value of variable varImg2.
        /// </summary>
        [TestVariable("8fe9a285-2aa9-4582-aaf9-b39ac62cf09c")]
        public string varImg2
        {
            get { return _varImg2; }
            set { _varImg2 = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable varURL.
        /// </summary>
        [TestVariable("200da798-9069-48ee-9400-0045663e343a")]
        public string varURL
        {
            get { return repo.varURL; }
            set { repo.varURL = value; }
        }

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

            activeContent_Open_Browser();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.HttpQaWweAppCloud6WweComFStyle1' at 294;72.", repo.ShowsWWE.HttpQaWweAppCloud6WweComFStyle1Info, new RecordItemIndex(1));
            repo.ShowsWWE.HttpQaWweAppCloud6WweComFStyle1.Click("294;72");
            Delay.Milliseconds(200);
            
            Validate_HttpQaWweAppCloud6WweComFStyle1();
            Delay.Milliseconds(17770);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ShowsWWE.HeaderClearfix' at 4;4.", repo.ShowsWWE.HeaderClearfixInfo, new RecordItemIndex(3));
            repo.ShowsWWE.HeaderClearfix.MoveTo(new Location(HeaderClearfix_Screenshot1, "4;4", HeaderClearfix_Screenshot1_Options));
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=874,Height=82}) on item 'ShowsWWE.HeaderClearfix'.", repo.ShowsWWE.HeaderClearfixInfo, new RecordItemIndex(4));
            Validate.CompareImage(repo.ShowsWWE.HeaderClearfixInfo, HeaderClearfix_Screenshot1_2, HeaderClearfix_Screenshot1_2_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'ShowsWWE.RTAtSloomzoHAHAHAHAOHHELLYEAHHash2' at 4;4.", repo.ShowsWWE.RTAtSloomzoHAHAHAHAOHHELLYEAHHash2Info, new RecordItemIndex(5));
            repo.ShowsWWE.RTAtSloomzoHAHAHAHAOHHELLYEAHHash2.MoveTo(new Location(RTAtSloomzoHAHAHAHAOHHELLYEAHHash2_Screenshot1, "4;4", RTAtSloomzoHAHAHAHAOHHELLYEAHHash2_Screenshot1_Options));
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ShowsWWE.RTAtSloomzoHAHAHAHAOHHELLYEAHHash2' at 4;4.", repo.ShowsWWE.RTAtSloomzoHAHAHAHAOHHELLYEAHHash2Info, new RecordItemIndex(6));
            repo.ShowsWWE.RTAtSloomzoHAHAHAHAOHHELLYEAHHash2.Click(new Location(RTAtSloomzoHAHAHAHAOHHELLYEAHHash2_Screenshot1_2, "4;4", RTAtSloomzoHAHAHAHAOHHELLYEAHHash2_Screenshot1_2_Options));
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating CompareImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=874,Height=91}) on item 'ShowsWWE.RTAtSloomzoHAHAHAHAOHHELLYEAHHash2'.", repo.ShowsWWE.RTAtSloomzoHAHAHAHAOHHELLYEAHHash2Info, new RecordItemIndex(7));
            Validate.CompareImage(repo.ShowsWWE.RTAtSloomzoHAHAHAHAOHHELLYEAHHash2Info, RTAtSloomzoHAHAHAHAOHHELLYEAHHash2_Screenshot1_3, RTAtSloomzoHAHAHAHAOHHELLYEAHHash2_Screenshot1_3_Options);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        CompressedImage HttpQaWweAppCloud6WweComFStyle1_Screenshot1
        { get { return repo.ShowsWWE.HttpQaWweAppCloud6WweComFStyle1Info.GetScreenshot1(new Rectangle(0, 0, 874, 378)); } }

        Imaging.FindOptions HttpQaWweAppCloud6WweComFStyle1_Screenshot1_Options
        { get { return Imaging.FindOptions.Parse("1;None;0,0,874,378;True;10000000;0ms"); } }

        CompressedImage HeaderClearfix_Screenshot1
        { get { return repo.ShowsWWE.HeaderClearfixInfo.GetScreenshot1(new Rectangle(866, 63, 8, 8)); } }

        Imaging.FindOptions HeaderClearfix_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage HeaderClearfix_Screenshot1_2
        { get { return repo.ShowsWWE.HeaderClearfixInfo.GetScreenshot1(new Rectangle(0, 0, 874, 82)); } }

        Imaging.FindOptions HeaderClearfix_Screenshot1_2_Options
        { get { return Imaging.FindOptions.Parse("1;None;0,0,874,82;True;10000000;0ms"); } }

        CompressedImage RTAtSloomzoHAHAHAHAOHHELLYEAHHash2_Screenshot1
        { get { return repo.ShowsWWE.RTAtSloomzoHAHAHAHAOHHELLYEAHHash2Info.GetScreenshot1(new Rectangle(794, 73, 8, 8)); } }

        Imaging.FindOptions RTAtSloomzoHAHAHAHAOHHELLYEAHHash2_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage RTAtSloomzoHAHAHAHAOHHELLYEAHHash2_Screenshot1_2
        { get { return repo.ShowsWWE.RTAtSloomzoHAHAHAHAOHHELLYEAHHash2Info.GetScreenshot1(new Rectangle(810, 48, 8, 8)); } }

        Imaging.FindOptions RTAtSloomzoHAHAHAHAOHHELLYEAHHash2_Screenshot1_2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage RTAtSloomzoHAHAHAHAOHHELLYEAHHash2_Screenshot1_3
        { get { return repo.ShowsWWE.RTAtSloomzoHAHAHAHAOHHELLYEAHHash2Info.GetScreenshot1(new Rectangle(0, 0, 874, 91)); } }

        Imaging.FindOptions RTAtSloomzoHAHAHAHAOHHELLYEAHHash2_Screenshot1_3_Options
        { get { return Imaging.FindOptions.Parse("1;None;0,0,874,91;True;10000000;0ms"); } }

#endregion
    }
#pragma warning restore 0436
}

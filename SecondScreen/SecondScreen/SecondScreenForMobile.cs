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
    ///The SecondScreenForMobile recording.
    /// </summary>
    [TestModule("aa1cd360-4b50-47ec-962e-397a0d804604", ModuleType.Recording, 1)]
    public partial class SecondScreenForMobile : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MobileRepository repository.
        /// </summary>
        public static MobileRepository repo = MobileRepository.Instance;

        static SecondScreenForMobile instance = new SecondScreenForMobile();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SecondScreenForMobile()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SecondScreenForMobile Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.3.1")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "5.3.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run mobile app 'com.wwe.universe' on device 'tab4'.", new RecordItemIndex(0));
            Host.Local.RunMobileApp("tab4", "com.wwe.universe");
            Delay.Milliseconds(3500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComWweUniverse.Home' at Center", repo.ComWweUniverse.HomeInfo, new RecordItemIndex(1));
            repo.ComWweUniverse.Home.Touch();
            Delay.Milliseconds(500);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

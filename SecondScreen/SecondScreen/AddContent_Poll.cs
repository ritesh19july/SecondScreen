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
    ///The AddContent_Poll recording.
    /// </summary>
    [TestModule("c1ef8995-760c-4157-a05c-cc0c94fdc404", ModuleType.Recording, 1)]
    public partial class AddContent_Poll : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SecondScreenRepository repository.
        /// </summary>
        public static SecondScreenRepository repo = SecondScreenRepository.Instance;

        static AddContent_Poll instance = new AddContent_Poll();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddContent_Poll()
        {
            varPollNID = "12345";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AddContent_Poll Instance
        {
            get { return instance; }
        }

#region Variables

        string _varPollNID;

        /// <summary>
        /// Gets or sets the value of variable varPollNID.
        /// </summary>
        [TestVariable("94fbefe6-d4c0-42ae-9196-793ce5935034")]
        public string varPollNID
        {
            get { return _varPollNID; }
            set { _varPollNID = value; }
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

            Mouse_ClickOnPoll();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(1));
            Delay.Duration(500, false);
            
            Mouse_Up_EditPollNid();
            Delay.Milliseconds(0);
            
            Key_Sequence_EditPollNid();
            Delay.Milliseconds(0);
            
            Key_Sequence_EditPollNid1(varPollNID);
            Delay.Milliseconds(0);
            
            Mouse_Down_DragNDrop();
            Delay.Milliseconds(0);
            
            Mouse_Up_DragNDrop();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

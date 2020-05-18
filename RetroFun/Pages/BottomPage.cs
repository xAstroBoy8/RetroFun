﻿using RetroFun.Controls;
using RetroFun.Subscribers;
using Sulakore.Communication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetroFun.Pages
{
    [ToolboxItem(true)]
    [DesignerCategory("UserControl")]
    public partial class BottomPage:  SubscriberPackets
    {
        private bool _FreezeUserMovement;
        public bool FreezeUserMovement
        {
            get => _FreezeUserMovement;
            set
            {
                _FreezeUserMovement = value;
                RaiseOnPropertyChanged();
            }
        }

        private string _UsernameFilter;

        public string UsernameFilter
        {
            get => _UsernameFilter;
            set
            {
                _UsernameFilter = value;
                RaiseOnPropertyChanged();
            }
        }

        public BottomPage()
        {
            InitializeComponent();

            Bind(FreezeMovementCheck, "Checked", nameof(FreezeUserMovement));
            Bind(UsernameTextBox, "Text", nameof(UsernameFilter));

        }

        public override async void Out_LatencyTest(DataInterceptedEventArgs obj)
        {
            if (UsernameFilter == null)
            {
                if (Connection.Remote.IsConnected)
                {
                    await Connection.SendToServerAsync(Out.RequestUserData);
                }
            }
        }

        public override void Out_Username(DataInterceptedEventArgs obj)
        {
            string username = obj.Packet.ReadString();


            if (UsernameFilter == null)
            {
                UsernameFilter = username;
            }
        }

        public override void Out_RoomUserWalk(DataInterceptedEventArgs e)
        {
            if (FreezeUserMovement)
            {
                e.IsBlocked = true;
            }
        }
    }
}

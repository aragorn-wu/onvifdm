﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using odm.controlsUIProvider;
using odm.models;
using odm.utils.controlsUIProvider;

namespace nvc.controlsUIProvider {
	public class ChannelNameProvider : BaseUIProvider {
		//PropertyChannelName _channelName;
		public void InitView(ChannelDescription devChannel) {
			//_channelName = new PropertyChannelName(devChannel) { Dock = DockStyle.Fill};
			//UIProvider.Instance.MainFrameProvider.AddPropertyControl(_channelName);
		}

		public override void ReleaseUI() {
			//if (_channelName != null && !_channelName.IsDisposed)
			//    _channelName.ReleaseAll();
		}
	}
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using odm.controls;
using System.Windows.Forms;
using odm.models;

namespace odm.controls.UIProvider {
	public class TimeSettingsProvider : BaseUIProvider {
		PropertyTimeZone _timeSettings;
		public void InitView(DateTimeSettingsModel devModel, Action apply) {
			_timeSettings = new PropertyTimeZone(devModel) { Dock = DockStyle.Fill, onBindingError = BindingError, onApply = apply };
			UIProvider.Instance.MainFrameProvider.AddPropertyControl(_timeSettings);
		}

		public override void ReleaseUI() {
			if (_timeSettings != null && !_timeSettings.IsDisposed)
				_timeSettings.ReleaseAll();
		}
	}
}
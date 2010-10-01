﻿//----------------------------------------------------------------------------------------------------------------
// Copyright (C) 2010 Synesis LLC and/or its subsidiaries. All rights reserved.
//
// Commercial Usage
// Licensees  holding  valid ONVIF  Device  Manager  Commercial  licenses may use this file in accordance with the
// ONVIF  Device  Manager Commercial License Agreement provided with the Software or, alternatively, in accordance
// with the terms contained in a written agreement between you and Synesis LLC.
//
// GNU General Public License Usage
// Alternatively, this file may be used under the terms of the GNU General Public License version 3.0 as published
// by  the Free Software Foundation and appearing in the file LICENSE.GPL included in the  packaging of this file.
// Please review the following information to ensure the GNU General Public License version 3.0 
// requirements will be met: http://www.gnu.org/copyleft/gpl.html.
// 
// If you have questions regarding the use of this file, please contact Synesis LLC at onvifdm@synesis.ru.
//
//----------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Net;
using System.Net.NetworkInformation;

using nvc.onvif;
using dev = onvif.services.device;
using nvc.utils;

namespace nvc.models {
	public static class NetworkStatusExtensions {
		public static IObservable<NetworkStatus> GetNetworkStatus(this Session session) {

			var proxy = session.device;
			
			return Observable.Join( proxy.GetDNS()
				.And(proxy.GetNetworkInterfaces())
				.Then((dns,nics)=>{
					var netStat = new NetworkStatus();
					if (dns.FromDHCP && dns.DNSFromDHCP.Count() > 0) {
						netStat.dns = IPAddress.Parse(dns.DNSFromDHCP[0].IPv4Address);
					}

					var nic = nics.Where(x => x.Enabled).FirstOrDefault();
					if (nic != null) {
						var nic_cfg = nic.IPv4.Config;
						//networkSettngs.m_token = t[0].token;
						netStat.mac = PhysicalAddress.Parse(nic.Info.HwAddress.Replace(':', '-'));
						//netStat.m_dhcp = nic.IPv4.Config.DHCP;

						if (nic_cfg.FromDHCP != null ) {
							//DebugHelper.Assert(nic_cfg.FromDHCP != null);
							DebugHelper.Assert(nic_cfg.FromDHCP.Address != null);
							netStat.ip = IPAddress.Parse(nic_cfg.FromDHCP.Address);
							netStat.subnetPrefix = nic_cfg.FromDHCP.PrefixLength;
						} else if (nic_cfg.Manual != null && nic_cfg.Manual.Count() > 0) {
							netStat.ip = IPAddress.Parse(nic_cfg.Manual[0].Address);
							netStat.subnetPrefix = nic_cfg.Manual[0].PrefixLength;
						}
					}
					return netStat;
				})
			);
		}
	}
}

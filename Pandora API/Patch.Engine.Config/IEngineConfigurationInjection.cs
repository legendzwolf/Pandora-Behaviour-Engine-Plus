﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pandora.API.Patch.Engine.Config;
public interface IEngineConfigurationInjection
{
	public enum OptionFlags
	{
		None = 0, 
		HidePatches = 1,
	}
	public string MenuPath { get; set; }
	public IEngineConfigurationFactory Factory { get; set; }
}

﻿using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using UnityEngine;

namespace Maritaria.Cockpit
{
	public sealed class CockpitConfig
	{
		[JsonConverter(typeof(StringEnumConverter))]
		public KeyCode FirstPersonKey;
	}
}
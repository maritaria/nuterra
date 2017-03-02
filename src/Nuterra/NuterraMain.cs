﻿using System;
using System.IO;
using System.Reflection;
using UnityEngine;

namespace Nuterra
{
	public static class NuterraMain
	{
		public static readonly Version CurrentVersion = new Version(0, 3, 0);
		public static readonly string DataFolder = Path.Combine(Application.dataPath, "..\\Nuterra_Data");
		public static readonly string ModsFolder = Path.Combine(Application.dataPath, "..\\Nuterra_Data\\Mods");
		public static readonly string TerraTechAssemblyName = "Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null";

		internal static void Start()
		{
			CleanLogger.Install();
			Console.WriteLine($"Nuterra.Nuterra.Startup({CurrentVersion})");

			if (!Directory.Exists(DataFolder))
			{
				Console.WriteLine("Nuterra_Data is missing! mods won't be loaded");
				return;
			}

			ModLoader.Instance.LoadAllMods(ModsFolder);
		}
	}
}
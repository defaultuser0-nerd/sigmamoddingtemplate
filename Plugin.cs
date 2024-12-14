using System;
using BepInEx;
using sigmamodtemplate;
using UnityEngine;
using Utilla;
using Newtilla;

namespace sigmamodtemplate
{
	[BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
	[ModdedGamemode]
	public class Plugin : BaseUnityPlugin
	{
		bool inRoom;

		void Start()
		{
            Newtilla.Newtilla.OnJoinModded += OnModdedJoin;
            Newtilla.Newtilla.OnLeaveModded += OnModdedLeave;
            HarmonyPatches.ApplyHarmonyPatches();
			GorillaTagger.OnPlayerSpawned(Initialized);
		}

		void OnEnable()
		{
			// u enable it idiot
		}

		void OnDisable()
		{
            // u disable it idiot
		}

		void Initialized(object sender, EventArgs e)
		{
			/* code runs right after your player loads */
		}

		void Update()
		{
			/* runs every frame */
		}

		[ModdedGamemodeJoin]        
		public void OnModdedJoin(string gamemode)
		{
			/* it will right even if its enabled/disabled */

			inRoom = true;
		}

		[ModdedGamemodeLeave]
		public void OnModdedLeave(string gamemode)
		{
            /* code will go bye bye here */
            /* it will right even if its enabled/disabled */

            inRoom = false;
		}
	}
}

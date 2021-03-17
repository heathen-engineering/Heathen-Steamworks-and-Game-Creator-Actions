﻿namespace GameCreator.Core
{
    using System;
	using UnityEngine;
	using GameCreator.Variables;
	using HeathenEngineering.SteamApi.Foundation;

	[AddComponentMenu("")]
	public class SteamAchivementUnlock :  IAction
	{
		public SteamAchievementData SteamAchievementToUnlock;


		public override bool InstantExecute(GameObject invoker, IAction[] actions, int index)
		{
			// Debug.Log(SteamAchievementToUnlock);
			SteamAchievementToUnlock.Unlock();

			return true;
		}


		#if UNITY_EDITOR
		public static new string NAME = "MVT/Heathen/Unlock Steam Achivement";
		#endif
	}
}

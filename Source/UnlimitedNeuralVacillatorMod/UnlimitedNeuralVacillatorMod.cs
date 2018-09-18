using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using static GeneShuffler;
using static StateMachine;

namespace UnlimitedNeuralVacillatorMod
{
	[HarmonyPatch(typeof(GeneShufflerSM), "InitializeStates")]
	internal class UnlimitedNeuralVacillatorMod_GeneShufflerSM_InitializeStates
	{

		private static void Postfix(GeneShufflerSM __instance, BaseState default_state)
		{
			if (!UnlimitedNeuralVacillatorState.StateManager.State.Enabled) return;

			Debug.Log(" === UnlimitedNeuralVacillatorMod_GeneShufflerSM_OnSpawn Postfix === ");

			__instance.working.pst.EventTransition(GameHashes.AnimQueueComplete, __instance.idle);

		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimTestMod
{
	using Harmony;
	using System;
	using UnityEngine;
	using static SimMessages;
	using Debug = Debug;

	[HarmonyPatch(typeof(SimMessages), "CreateDiseaseTable")]
	internal static class SimMessages_CreateDiseaseTable
	{
		private static bool Prefix()
		{
			Debug.Log(" === SimMessages_CreateDiseaseTable Prefix === ");

			return true;
		}
	}

	[HarmonyPatch(typeof(SimMessages), "ModifyBuildingEnergy")]
	internal static class SimMessages_ModifyBuildingEnergy
	{
		private static bool Prefix(int sim_handle, float delta_kj, float min_temperature, float max_temperature)
		{
			Debug.Log(" === ModifyBuildingEnergy Prefix === (" + sim_handle + "," + delta_kj + "," + min_temperature + "," + max_temperature + ")");

			return true;
		}
	}

	[HarmonyPatch(typeof(SimMessages), "ModifyEnergy")]
	internal static class SimMessages_ModifyEnergy
	{
		private static bool Prefix(int gameCell, float kilojoules, float max_temperature, EnergySourceID id)
		{
			Debug.Log(" === ModifyEnergy Prefix === (" + gameCell + "," + kilojoules + "," + max_temperature + "," + id + ")");

			return true;
		}
	}

	[HarmonyPatch(typeof(SimMessages), "Dig")]
	internal static class SimMessages_Dig
	{
		private static bool Prefix(int gameCell, int callbackIdx)
		{
			Debug.Log(" === SimMessages_Dig Prefix === (" + gameCell + "," + callbackIdx + ")");

			return true;
		}
	}

	[HarmonyPatch(typeof(SimMessages), "SetCellProperties")]
	internal static class SimMessages_SetCellProperties
	{
		private static bool Prefix(int gameCell, byte properties)
		{
			Debug.Log(" === SimMessages_SetCellProperties Prefix=== (" + gameCell + "," + properties + ")");

			return true;
		}
	}

	[HarmonyPatch(typeof(SimCellOccupier), "GetSimCellProperties")]
	internal static class SimCellOccupier_GetSimCellProperties
	{
		private static void Postfix(ref Sim.Cell.Properties __result)
		{
			Debug.Log(" === SimCellOccupier_GetSimCellProperties Postfix=== " + __result);

			//return true;
		}
	}
}

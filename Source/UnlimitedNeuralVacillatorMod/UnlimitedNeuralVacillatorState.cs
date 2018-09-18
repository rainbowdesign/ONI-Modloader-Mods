using System.Collections.Generic;
using ONI_Common.Json;

namespace UnlimitedNeuralVacillatorMod
{
	public class UnlimitedNeuralVacillatorState
	{
		public bool Enabled { get; set; } = true;


		public static BaseStateManager<UnlimitedNeuralVacillatorState> StateManager
			= new BaseStateManager<UnlimitedNeuralVacillatorState>("Template");
	}
}
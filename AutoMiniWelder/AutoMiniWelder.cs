using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using VRageMath;
using VRage.Game;
using Sandbox.ModAPI.Interfaces;
using Sandbox.ModAPI.Ingame;
using Sandbox.Game.EntityComponents;
using VRage.Game.Components;
using VRage.Collections;
using VRage.Game.ObjectBuilders.Definitions;
using VRage.Game.ModAPI.Ingame;
using SpaceEngineers.Game.ModAPI.Ingame;
public sealed class Program : MyGridProgram {
	// Начало

	List<MyDetectedEntityInfo> entity_list = new List<MyDetectedEntityInfo>();
	public Program() {
		Runtime.UpdateFrequency = UpdateFrequency.Update10;
	}

	public void Save() {

	}

	public void Main(string argument, UpdateType updateSource) {

	}

	// Конец
}
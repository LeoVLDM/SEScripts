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
		var door_sensor = GridTerminalSystem.GetBlockWithName("Door Sensor 1") as IMySensorBlock;
		if (door_sensor is IMySensorBlock) {
			door_sensor.DetectedEntities(entity_list);
			if (entity_list.Count == 0) {
				var door = GridTerminalSystem.GetBlockWithName("Door 1") as IMyDoor;
				door.ApplyAction("Open_Off");
			} else {
				var door = GridTerminalSystem.GetBlockWithName("Door 1") as IMyDoor;
				door.ApplyAction("Open_On");
			}
		}

		door_sensor = GridTerminalSystem.GetBlockWithName("Door Sensor 2") as IMySensorBlock;
		if (door_sensor is IMySensorBlock) {
			door_sensor.DetectedEntities(entity_list);
			if (entity_list.Count == 0) {
				var door = GridTerminalSystem.GetBlockWithName("Door 2") as IMyDoor;
				door.ApplyAction("Open_Off");
			} else {
				var door = GridTerminalSystem.GetBlockWithName("Door 2") as IMyDoor;
				door.ApplyAction("Open_On");
			}
		}

		door_sensor = GridTerminalSystem.GetBlockWithName("Door Sensor 3") as IMySensorBlock;
		if (door_sensor is IMySensorBlock) {
			door_sensor.DetectedEntities(entity_list);
			if (entity_list.Count == 0) {
				var door = GridTerminalSystem.GetBlockWithName("Door 3") as IMyDoor;
				door.ApplyAction("Open_Off");
			} else {
				var door = GridTerminalSystem.GetBlockWithName("Door 3") as IMyDoor;
				door.ApplyAction("Open_On");
			}
		}

		door_sensor = GridTerminalSystem.GetBlockWithName("Door Sensor 4") as IMySensorBlock;
		if (door_sensor is IMySensorBlock) {
			door_sensor.DetectedEntities(entity_list);
			if (entity_list.Count == 0) {
				var door = GridTerminalSystem.GetBlockWithName("Door 4") as IMyDoor;
				door.ApplyAction("Open_Off");
			} else {
				var door = GridTerminalSystem.GetBlockWithName("Door 4") as IMyDoor;
				door.ApplyAction("Open_On");
			}
		}

		door_sensor = GridTerminalSystem.GetBlockWithName("Door Sensor 5") as IMySensorBlock;
		if (door_sensor is IMySensorBlock) {
			door_sensor.DetectedEntities(entity_list);
			if (entity_list.Count == 0) {
				var door = GridTerminalSystem.GetBlockWithName("Door 5") as IMyDoor;
				door.ApplyAction("Open_Off");
			} else {
				var door = GridTerminalSystem.GetBlockWithName("Door 5") as IMyDoor;
				door.ApplyAction("Open_On");
			}
		}

		door_sensor = GridTerminalSystem.GetBlockWithName("Door Sensor 6") as IMySensorBlock;
		if (door_sensor is IMySensorBlock) {
			door_sensor.DetectedEntities(entity_list);
			if (entity_list.Count == 0) {
				var door = GridTerminalSystem.GetBlockWithName("Door 6") as IMyDoor;
				door.ApplyAction("Open_Off");
			} else {
				var door = GridTerminalSystem.GetBlockWithName("Door 6") as IMyDoor;
				door.ApplyAction("Open_On");
			}
		}

		door_sensor = GridTerminalSystem.GetBlockWithName("Door Sensor 7") as IMySensorBlock;
		if (door_sensor is IMySensorBlock) {
			door_sensor.DetectedEntities(entity_list);
			if (entity_list.Count == 0) {
				var door = GridTerminalSystem.GetBlockWithName("Door 7") as IMyDoor;
				door.ApplyAction("Open_Off");
			} else {
				var door = GridTerminalSystem.GetBlockWithName("Door 7") as IMyDoor;
				door.ApplyAction("Open_On");
			}
		}
	}

	// Конец
}
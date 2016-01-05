﻿using UnityEngine;
using System.Collections;

public class ChangeStateEvent : TargetEvent{

	public State[] statesToAdd;
	public State[] statesToRemove;
	protected override void active()
	{
		
		PlayerState.instance.eventStateList.AddRange(statesToAdd);
		
		foreach (var state in statesToRemove)
		{
			PlayerState.instance.eventStateList.Remove(state);	
		}
	}
	
	
	
}
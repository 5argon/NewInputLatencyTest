using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine.Experimental.PlayerLoop;

[UpdateBefore(typeof(Initialization))]
public class BeginFrameTrackingSystem : ComponentSystem
{
	protected override void OnUpdate()
	{
		Debug.LogWarning($"--- BEGIN frame : {Time.realtimeSinceStartup}");
	}
}

[UpdateAfter(typeof(PostLateUpdate))]
public class EndFrameTrackingSystem : ComponentSystem
{
	protected override void OnUpdate()
	{
		Debug.LogWarning($"--- END frame : {Time.realtimeSinceStartup}");
	}
}

public class Tester : MonoBehaviour {

	public AudioSource aSource;
	public InputOfTheYear inp;

	public void Awake()
	{
		Debug.Log($"Registered!!");
		inp.HelloActionMap._HelloTouchAction.performed += callbackContext => 
		{
			Debug.Log($"NEW input system! : Input time {callbackContext.time} {callbackContext.startTime} {callbackContext.action.name} {callbackContext.interaction} {callbackContext.phase} {callbackContext.control.name} {callbackContext.control.path} {callbackContext.action.phase}");
			aSource.Play();
		};
	}

	public void Update()
	{
		Debug.LogWarning($"UPDATE : {Time.realtimeSinceStartup}");
	}

	public void OnEnable()
	{
		Debug.Log($"Enabled!!");
		inp.Enable();
	}

	public void NormalTouch()
	{
		Debug.Log($"Normal touch : In-frame input time {Time.realtimeSinceStartup}");
	}

}
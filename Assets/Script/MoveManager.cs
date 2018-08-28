using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveManager : MonoBehaviour {

	[SerializeField]
	NavMeshAgent agent;

	[SerializeField]
	Transform target;

	void Start () 
	{
		agent.SetDestination(target.position);
	}
	
}

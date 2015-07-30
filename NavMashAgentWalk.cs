using UnityEngine;
using System.Collections;

public class NavMashAgentWalk : MonoBehaviour {

	public Transform target;
	NavMeshAgent agent;
	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
		agent.SetDestination (target.position);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Ray screenRay = Camera.main.ScreenPointToRay(Input.mousePosition);
			
			RaycastHit hit;
			if (Physics.Raycast(screenRay, out hit))
			{
				agent.SetDestination(hit.point);
			}
		}
	}
}

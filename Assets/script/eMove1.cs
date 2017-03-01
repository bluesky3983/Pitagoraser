using UnityEngine;
using System.Collections;

public class eMove1 : MonoBehaviour {

	private Transform Target;
	public GameObject Ossan;
	private NavMeshAgent navMeshAgent;
	void Start () {
		Ossan = GameObject.Find ("OssanArea");
		Target = Ossan.transform;
		navMeshAgent = GetComponent<NavMeshAgent>();

	}

	// Update is called once per frame
	void Update () {
		navMeshAgent.SetDestination(Target.position);
	}
}

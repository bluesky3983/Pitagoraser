using UnityEngine;
using System.Collections;

public class jenga : MonoBehaviour {
	private GameObject Jenga;
	public float Despeed = 0f;
	// Use this for initialization
	void Start () {
		Jenga = GameObject.Find ("jenga");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider jencol){
		if (jencol.gameObject.tag == "jenga") {
			Transform[] transformList;
			transformList = Jenga.transform.GetComponentsInChildren<Transform>();
			foreach (Transform transform in transformList) {
				//Debug.Log(transform);
				transform.gameObject.AddComponent<Rigidbody>();
			}
			//Debug.Log("ok");
			//Jenga.gameObject.transform.Translate(0.02f,0.0f,0.01f);
			/*Jenga.gameObject.transform.Rotate(0,0,-12);*/
			Destroy(Jenga,Despeed);
		}
	}
}

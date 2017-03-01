using UnityEngine;
using System.Collections;

public class BallMove : MonoBehaviour {
	public int Speed = 0;
	private GameObject ball;
	// Use this for initialization
	void Start () {
		ball = GameObject.Find("ball");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider Col)
	{
		if( Col.gameObject.tag == "tvdesk" ){
			Debug.Log("ok");
			ball.gameObject.rigidbody.AddRelativeForce(new Vector3(Speed,0,0),ForceMode.Impulse);
		}
	}
}

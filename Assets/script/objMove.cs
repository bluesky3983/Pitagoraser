using UnityEngine;
using System.Collections;

public class objMove : MonoBehaviour {
	public int Speed = 5;
	private Animator anim;
	private Transform tvRotation;
	private GameObject col;
	private int counter;
	private Vector3 temp;

	// Use this for initialization
	void Start () {
		anim = GetComponent< Animator > ();
		col = GameObject.Find ("TvCollider");
	}
	
	// Update is called once per frame
	void Update () {
		if (counter == 2) {
					anim.SetTrigger("tvdrop");
			temp.z = -90;
			col.transform.eulerAngles = temp;
				}
	}
	void OnTriggerEnter(Collider Col)
	{
		if( Col.gameObject.tag == "Gimmick" ){
			Col.gameObject.rigidbody.AddForce(new Vector3(-Speed,0,0),ForceMode.VelocityChange);
			counter++;
		}
	}
}



using UnityEngine;
using System.Collections;

public class DominoObj : MonoBehaviour {

	private void Start () {
	
	}
	
	private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Domino(Clone)")
        {
            this.gameObject.rigidbody.mass = 100;
        }
    }
}

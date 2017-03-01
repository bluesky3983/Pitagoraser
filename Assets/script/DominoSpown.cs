using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DominoSpown : MonoBehaviour {

	public GameObject dominoCube;
	private List<GameObject> objList;

	// Use this for initialization
	void Start () {
		objList = new List<GameObject> ();
		dominoCube = Resources.Load ("Domino") as GameObject;

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton (0)) {
						Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
						RaycastHit hit;


						if (Physics.Raycast (ray, out hit, Camera.main.farClipPlane)) {
								bool isSpown = true;
								foreach (GameObject hasObj in objList) {
										float dist = Vector3.Distance (hasObj.transform.position, hit.point);

										if (dist <= 1.1f) {
												isSpown = false;
												break;
										}
								}

								if (hit.transform.gameObject.name == "Plane") {
										if (isSpown) {
								
												GameObject obj = Instantiate (dominoCube, new Vector3 (hit.point.x, hit.point.y + 1f, hit.point.z), Quaternion.identity) as GameObject;
												obj.rigidbody.mass = 0.01f;
												obj.AddComponent<DominoObj>();
												objList.Add (obj);
										}
								}
						}
				}
		if (Input.GetKeyDown(KeyCode.Space))
		{
				foreach( GameObject hasObj in objList ){
				hasObj.transform.rigidbody.AddForce(new Vector3(0, 0, 0.03f), ForceMode.Impulse);
				break;
				}

		}

			
			
		
		
		foreach (GameObject obj in objList) {
			Debug.Log(obj.transform.position);
		}
	}
}

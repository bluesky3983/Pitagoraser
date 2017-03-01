using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DominoPut : MonoBehaviour {
	
	public GameObject dominoCube;
	private List<GameObject> objList;
	private GameObject atk;
	private Animator animator;
	private int putAnim;
	public AudioClip dominoposition;
	public AudioClip dominodown;
	//public GameObject chara;
	
	// Use this for initialization
	void Start () {
		objList = new List<GameObject> ();
		dominoCube = Resources.Load ("Domino") as GameObject;
		atk = GameObject.Find("Atk");
		animator = GetComponent<Animator> ();
		putAnim = Animator.StringToHash ("dominoPut");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			audio.clip = dominoposition;
			GameObject obj = Instantiate(dominoCube, new Vector3(this.transform.localPosition.x, this.transform.localPosition.y - 0.9f, this.transform.localPosition.z), this.transform.rotation) as GameObject;
			obj.rigidbody.mass = 0.01f;
			obj.AddComponent<DominoObj>();
			objList.Add (obj);
			audio.Play();
			animator.SetBool(putAnim, true );
		}
		
		if (Input.GetButtonDown("Fire2")) {
			audio.clip = dominodown;
			foreach (GameObject hasObj in objList) {
				audio.Play();
				atk.transform.position = new Vector3(hasObj.transform.position.x, hasObj.transform.position.y, hasObj.transform.position.z - 0.1f);
				atk.transform.rotation = Quaternion.Euler(hasObj.transform.eulerAngles.x, hasObj.transform.eulerAngles.y, hasObj.transform.eulerAngles.z);
				hasObj.transform.rigidbody.AddRelativeForce(new Vector3(0,0,0.01f),ForceMode.Impulse);
				break;
			}
			foreach(GameObject hasObj in objList) {
				Destroy(hasObj,7.0f);
				objList = new List<GameObject>();
				//objList.RemoveAll(();
			}
		}
		//animator.SetBool(putAnim, false);
		//if(){
		//
		//}
	}
	
	
	
	
	
	//foreach (GameObject obj in objList) {
	//	Debug.Log(obj.transform.position);
	//}
}

//	Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
//	RaycastHit hit;
//	
//	
//	if (Physics.Raycast (ray, out hit, Camera.main.farClipPlane)) {
//		bool isSpown = true;
//		foreach (GameObject hasObj in objList) {
//			float dist = Vector3.Distance (hasObj.transform.position, hit.point);
//			
//			if (dist <= 1.1f) {
//				isSpown = false;
//				break;
//			}
//		}
//		
//		if (hit.transform.gameObject.name == "Plane") {
//			if (isSpown) {
//				
//				GameObject obj = Instantiate (dominoCube, new Vector3 (hit.point.x, hit.point.y + 1f, hit.point.z), Quaternion.identity) as GameObject;
//				obj.rigidbody.mass = 0.01f;
//				obj.AddComponent<DominoObj>();
//				objList.Add (obj);
//			}
//		}
//	}
//}

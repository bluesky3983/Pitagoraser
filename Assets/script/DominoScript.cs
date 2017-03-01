using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DominoScript : MonoBehaviour {

    public GameObject dominoFirst;
    public List<GameObject> objList;
	public Transform target;

	void Start () {
		target = GameObject.Find("Cube1").GetComponent<Transform>();

        

	}
	
	private void Update () {

		if (Input.GetKeyDown (KeyCode.Tab)) 
		{
			dominoFirst = GameObject.CreatePrimitive(PrimitiveType.Cube);
			dominoFirst.transform.position = target.transform.position;
			dominoFirst.transform.localScale = new Vector3(0.2f, 1, 1);
			dominoFirst.AddComponent<Rigidbody>();
			dominoFirst.gameObject.name = "dominoObj";

			for (uint i = 0; i < 30; ++i) {
				GameObject obj = Instantiate(dominoFirst, new Vector3(i * 0.7f,0,i + target.transform.position.z), Quaternion.Euler(0, 0, 0)) as GameObject;
				obj.rigidbody.mass = 0.01f;
				obj.AddComponent<DominoObj>();
				objList.Add(obj);
			}
		}

	    if (Input.GetKeyDown(KeyCode.Space))
        {
            dominoFirst.rigidbody.AddForce(new Vector3(2, 0, 0), ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            foreach (GameObject obj in objList) {
                Destroy(obj);
            }
        }
	}
}

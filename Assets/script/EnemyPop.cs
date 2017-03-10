using UnityEngine;
using System.Collections;

public class EnemyPop : MonoBehaviour {
	
	public GameObject enemy;
	public float Interval = 5;
	private bool check =true;
	private GameObject particle1;
	private GameObject particle2;
	// Use this for initialization
	void Start () {
		enemy = Resources.Load ("Enemy") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (check) {
			check = false;
			Instantiate (enemy, new Vector3 (this.transform.localPosition.x, this.transform.localPosition.y, this.transform.localPosition.z), Quaternion.identity);
			StartCoroutine(WaitForIt());

		}
		
		
	}
	IEnumerator WaitForIt(){
		yield return new WaitForSeconds(Interval);
		check = true;
	}
}

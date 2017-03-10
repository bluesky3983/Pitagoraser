using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {
	public GameObject cs;
	public int Escore;
	// Use this for initialization
	void Start () {
		cs = GameObject.Find ("DeathCounter");
		Count enscore = cs.GetComponent<Count>();
		Escore = enscore.DestroyCount;
		enscore.DestroyCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = Escore.ToString ();
	}
}

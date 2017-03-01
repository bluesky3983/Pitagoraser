using UnityEngine;
using System.Collections;

public class Count : MonoBehaviour {
	public int DestroyCount = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = DestroyCount.ToString ();
	}
	void Awake () {
		DontDestroyOnLoad (this);//次のシーンを読み込むときに、自分自身を破壊しない。
	}
}

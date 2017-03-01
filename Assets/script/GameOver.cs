using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	private GameObject Over;
	private GameObject resetcount;
	// Use this for initialization
	void Start () {
		Over = GameObject.Find ("OssanArea");
		resetcount = GameObject.Find ("DeathCounter");
	}
	
	// Update is called once per frame
	void Update () {
		ErasedEnemy OverCounts = Over.GetComponent<ErasedEnemy> ();

		guiText.text = OverCounts.OverCount.ToString ();

		if (OverCounts.OverCount <= 0 ) {
			Count Destroyreset = resetcount.GetComponent<Count>();
			Destroyreset.DestroyCount = 0;
			Debug.Log("ok");
			// 1秒かけてフェードアウト, 終わったら LoadLevel
			Application.LoadLevel("GameOver");
		}

	}
}

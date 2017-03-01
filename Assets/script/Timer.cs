using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	//private float timer;
	// Use this for initializationc
	private float time1 = 0;
	private float time2 = 0;
	private float time3 = 2;
	private float text1;
	private float text2;
	private float text3;
	private GameObject bgm;
	public float change = 0;
	private bool flag = true;
	void Start () {
		bgm = GameObject.Find("BGM");
	}
	
	// Update is called once per frame
	void Update () {
		if (flag && time3 >= 0) {
			if(time2 <= 0 && time1 < 0){
				time3 -= 1;
				time2 = 5;
				time1 = 9;
			}
			else if(time1 < 0){
				time2 -= 1;
				time1 = 9;
			}


			text1 = time1;
			text2 = time2;
			text3 = time3;
			flag = false;
			StartCoroutine(WaitForIt());
		}


		guiText.text = "0" + text3.ToString()+":"+text2.ToString()+text1.ToString();


		//Debug.Log(Time.realtimeSinceStartup);
		//guiText.text = Time.realtimeSinceStartup.ToString();
		if (time3 == change&&time2 == 0&&time1 == 1) {
			// 1秒後に1秒かけて白色でフェードイン
			//CameraFade.StartAlphaFade(Color.white, true, 0f, 0f);
			// 1秒かけてフェードアウト, 終わったら LoadLevel
			CameraFade.StartAlphaFade (Color.white, false, 1f, 0f, () => {Application.LoadLevel ("ChangeResult");});
		}
		if (time3 == change&&time2 == 0&&time1 == 1) {
			bgm.audio.volume = 0.1f;
		}
	}
	IEnumerator WaitForIt(){
		yield return new WaitForSeconds(1);
		if (time3 >= 0) {
					time1 -= 1;	
				}
		if (flag == false) {
						flag = true;
				}

	}
}

using UnityEngine;
using System.Collections;

public class Ranking : MonoBehaviour {

	public int ranking1 = 0;
	public int ranking2 = 0;
	public int ranking3 = 0;
	public int ranking4 = 0;
	public int ranking5 = 0;
	private GameObject rank1;
	private GameObject rank2;
	private GameObject rank3;
	private GameObject rank4;
	private GameObject rank5;
	private int temp;
	private int nowScore;
	private int[] rank = new int[5];
//public int Myranking = 0;
//private int hiscore = PlayerPrefs.GetInt("HiSCORE");
	private GameObject deathcounter;
//// Use this for initialization
void Start () {
				//獲得スコアの取得
				deathcounter = GameObject.Find ("ScoreText");
				score myscore = deathcounter.GetComponent<score> ();
				nowScore = myscore.Escore;

				GameObject Ranking1 = GameObject.Find ("Ranking1") as GameObject;
				GameObject Ranking2 = GameObject.Find ("Ranking2") as GameObject;
				GameObject Ranking3 = GameObject.Find ("Ranking3") as GameObject;
				GameObject Ranking4 = GameObject.Find ("Ranking4") as GameObject;
				GameObject Ranking5 = GameObject.Find ("Ranking5") as GameObject;

				//ランキングデータの取得割り当て
				rank1 = Resources.Load ("Rank1Score") as GameObject;
				rank2 = Resources.Load ("Rank2Score") as GameObject;
				rank3 = Resources.Load ("Rank3Score") as GameObject;
				rank4 = Resources.Load ("Rank4Score") as GameObject;
				rank5 = Resources.Load ("Rank5Score") as GameObject;

				//ランキングソートの準備
				rank [0] = int.Parse (rank1.guiText.text);
				rank [1] = int.Parse (rank2.guiText.text);
				rank [2] = int.Parse (rank3.guiText.text);
				rank [3] = int.Parse (rank4.guiText.text);
				rank [4] = int.Parse (rank5.guiText.text);
				//ソート
				if (nowScore >= rank [0]) {
						for (int i = 0; i <= 4; i++) {
								temp = rank [i];
								rank [i] = nowScore;
								nowScore = temp;
						}
						
				} else if (nowScore >= rank [1]) {
						for (int i = 1; i <= 4; i++) {
								temp = rank [i];
								rank [i] = nowScore;
								nowScore = temp;
						}
						
				} else if (nowScore >= rank [2]) {
						for (int i = 2; i <= 4; i++) {
								temp = rank [i];
								rank [i] = nowScore;
								nowScore = temp;
						}
						
				} else if (nowScore >= rank [3]) {
						for (int i = 3; i <= 4; i++) {
								temp = rank [i];
								rank [i] = nowScore;
								nowScore = temp;
						}
						
				} else if (nowScore >= rank [4]) {
						for (int i = 4; i <= 4; i++) {
								temp = rank [i];
								rank [i] = nowScore;
								nowScore = temp;
						}
						
				} else {
						
				}
				rank1.guiText.text = rank [0].ToString ();
				rank2.guiText.text = rank [1].ToString ();
				rank3.guiText.text = rank [2].ToString ();
				rank4.guiText.text = rank [3].ToString ();
				rank5.guiText.text = rank [4].ToString ();
		
				GameObject Rank1 = (GameObject)Instantiate (rank1, new Vector3 (0f, 0f, 1.1f), Quaternion.identity);
				Rank1.transform.parent = Ranking1.transform;
				Rank1.transform.Translate (Vector3.forward * 1);
				GameObject Rank2 = (GameObject)Instantiate (rank2, new Vector3 (0f, 0f, 1.1f), Quaternion.identity);
				Rank2.transform.parent = Ranking2.transform;
				Rank2.transform.Translate (Vector3.forward * 1);
				GameObject Rank3 = (GameObject)Instantiate (rank3, new Vector3 (0f, 0f, 1.1f), Quaternion.identity);
				Rank3.transform.parent = Ranking3.transform;
				Rank3.transform.Translate (Vector3.forward * 1);
				GameObject Rank4 = (GameObject)Instantiate (rank4, new Vector3 (0f, 0f, 1.1f), Quaternion.identity);
				Rank4.transform.parent = Ranking4.transform;
				Rank4.transform.Translate (Vector3.forward * 1);
				GameObject Rank5 = (GameObject)Instantiate (rank5, new Vector3 (0f, 0f, 1.1f), Quaternion.identity);
				Rank5.transform.parent = Ranking5.transform;
				Rank5.transform.Translate (Vector3.forward * 1);
		}
	// Update is called once per frame
	void Update () {

		}
	}

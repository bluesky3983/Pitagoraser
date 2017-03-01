using UnityEngine;
using System.Collections;

public class ErasedEnemy : MonoBehaviour {
	public GameObject counter;
	public AudioClip enemy_down;
	AudioSource audioSource;
	public int OverCount = 10;
	// Use this for initialization
	void Start () {
		counter = GameObject.Find ("DeathCounter");
		//audioSource = gameObject.GetComponent<AudioSource> ();
		//audioSource.clip = enemy_down;
	}
	
	// Update is called once per frame
	void Update () {
		rigidbody.WakeUp();
	}
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Enemy")
		{
			//Debug.Log("ok");
			OverCount--;
			Destroy(col.gameObject);
			//audioSource.Play();
			//Count script = counter.GetComponent<Count>();
			//script.DestroyCount++;
		}
	}
}

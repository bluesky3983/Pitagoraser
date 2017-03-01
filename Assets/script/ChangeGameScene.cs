﻿using UnityEngine;
using System.Collections;

public class ChangeGameScene : MonoBehaviour {
	
	private GameObject bgm;
	public AudioClip title;
	AudioSource audioSource;
	
	// Use this for initialization
	void Start() {
		bgm = GameObject.Find ("BGM");
		audioSource = gameObject.GetComponent<AudioSource> ();
		audioSource.clip = title;
	}
	void Update() {
		if(Input.GetButtonDown("Fire1")){
			audioSource.Play();
			bgm.audio.volume = 0.2f;
			// 1秒後に1秒かけて白色でフェードイン
			//CameraFade.StartAlphaFade(Color.white, true, 2f, 1f);
			// 1秒かけてフェードアウト, 終わったら LoadLevel
			CameraFade.StartAlphaFade(Color.white, false, 2f, 0f, () => { Application.LoadLevel("GameScene"); });
		}
	}
}

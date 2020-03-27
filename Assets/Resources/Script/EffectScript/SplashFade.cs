using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashFade : MonoBehaviour {

	public Image SplashImage;
	public string LoadLevel;

	IEnumerator Start(){
		SplashImage.canvasRenderer.SetAlpha(0.0f);

		FadeIn();
		yield return new WaitForSeconds(3.5f);
		FadeOut();
		yield return new WaitForSeconds(3.5f);
		//LoadLevel
		//Application.LoadLevel ("CircularMenu");
		SceneManager.LoadScene("HomeMenu");
	}

	void FadeIn(){
		SplashImage.CrossFadeAlpha(1.0f, 1.5f, false);	
	}

	void FadeOut(){
		SplashImage.CrossFadeAlpha(0.0f, 2.5f, false);
	}
}

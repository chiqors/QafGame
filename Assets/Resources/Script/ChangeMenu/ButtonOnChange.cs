using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonOnChange : MonoBehaviour {
	public void ChangeScene (string sceneName){
		SceneManager.LoadScene (sceneName);
		//Application.LoadLevel (sceneName);
	}

}

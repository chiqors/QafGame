using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public enum Menu{
		MainMenu,
		NewGame,
		Continue
	}

	public Menu currentMenu;

	public void ChangeScene (string sceneName){
		if(currentMenu == Menu.MainMenu){
			SceneManager.LoadScene ("HomeMenu");
		}else if(currentMenu == Menu.NewGame){
			SceneManager.LoadScene ("NewGame");
		}else if(currentMenu == Menu.Continue){
			SceneManager.LoadScene ("Continue");
		}
	}
}

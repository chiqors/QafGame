using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[System.Serializable]
public class UserData : MonoBehaviour {
	public static UserData current;
	public Text username;
	public Text gender;
	public Image character;

	//public void Display(UserEntry user){
	//	username.text = user.inputName;
		//gender.ToString() = user.genderPlayer;
	//	character.sprite = user.characterPlayer;
	//}
}

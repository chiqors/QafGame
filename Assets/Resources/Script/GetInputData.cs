using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GetInputData : MonoBehaviour {

	public InputField input,inputfield1,inputfield2;
	InputField.SubmitEvent se;



	//void Update(){
	//	ShowOutputData targetScript = GetComponent<ShowOutputData> ();
	//	se = new InputField.SubmitEvent ();
	//	se.AddListener (submitInput);

	//}
	//InputField.SubmitEvent sE;
	//public Text Output;
	// Use this for initialization

		

	public void submitInput(string arg0){
		
		inputfield2.text.ToString ();

		//string newText = currentText;

		inputfield2.ActivateInputField ();
//		PlayerPrefs.SetString ("usernameInput",inputfield2);
		//O	utput.text = newText;
		//input.text = "";
		//input.ActivateInputField ();
	//}
		
}
}
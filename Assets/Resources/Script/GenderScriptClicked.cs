using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GenderScriptClicked : MonoBehaviour {

	public Image gambar;
	//public GameObject img;
	//public Button btnL,btnP;
	//public bool L,P;

	//void Start(){
	//	img = GameObject.Find ("MainCamera/Canvas/Image");

	//	Button btn = btnL.GetComponent<Button> ();
	//	btn.onClick.AddListener (ChangeL);
	//	btn.onClick.AddListener (ChangeP);

	//}

	//public Button genderL,genderP;

	//public void ChangeL(){
		//img.GetComponent (typeof(GameObject)) = Resources.Load<Sprite> ("imgsource/Character/sideboy") as Sprite;
		//img = (GameObject)this.GetComponent (typeof(GameObject));
	//	img.GetComponent<SpriteRenderer> ().sprite = Resources.Load<Sprite> ("imgsource/Character/moslemBoyFront") as Sprite;
		//return L = true; 
		//return P = false;
	//}
	//public void ChangeP(){
	//	img.GetComponent<SpriteRenderer> ().sprite = Resources.Load("imgsource/Character/sideboy",typeof(Sprite)) as Sprite;
		//return L = false;
		//return P = true;
	//}

	public void ChangeImage(string nameImage){

		gambar.sprite = Resources.Load<Sprite> ("imgsource/Character/"+nameImage) as Sprite;

		//if (genderL.onClick.AddListener) {
		//	gambar1.sprite = Resources.Load<Sprite> ("imgsource/Character/boyMoslem") as Sprite;
		//} else {
		//	gambar2.sprite = Resources.Load<Sprite> ("imgsource/Character/sideboy") as Sprite;
		//}
	}
}

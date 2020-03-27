using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    GameControl control;

	public Image imgGender;
	public Text Username;
	//public Sprite img1;
	//public Text gender;
	public static List<PlayerData> savedGames = new List<PlayerData>();
	//GameObject userName,gender,playerImg;


	//void start(){
	//	username = GameObject.Find ("Canvas/username/Text");
	//}

    public void Save() {
		GameControl.savedGames.Add (PlayerData.current);
        BinaryFormatter bf = new BinaryFormatter();
        FileStream fileStream = File.Create(Application.persistentDataPath + "/savedGames.dat");

        PlayerData playerData = new PlayerData();
		playerData.userName = Username.text;

		//playerData.Gender = gender.text;
   

		bf.Serialize(fileStream,playerData);
        fileStream.Close();
		Debug.Log("Berhasil ngeSave" + Username.text);
		//Debug.Log ("Berhasil ngeSave" + gender.text);
    }

	//public void Load(){
		//if (File.Exists (Application.persistentDataPath + "/savedGames.dat")) {
		//	BinaryFormatter bf = new BinaryFormatter ();
		//	FileStream fileStream = File.Open (Application.persistentDataPath + "/savedGames.dat", FileMode.Open);
		//	GameControl.savedGames = (List<PlayerData>)bf.Deserialize (fileStream);
		//	fileStream.Close ();
		//}
	//}

    [Serializable]
    public class PlayerData {
		public static PlayerData current;
        public string userName;
		public Image img;


		//public string Gender;
		
    }
}

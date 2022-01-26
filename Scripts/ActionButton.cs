using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ActionButton : MonoBehaviour {
	public Button MakeaButton;

	void Start () {
		Button btn = MakeaButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
		Debug.Log ("You have clicked the button!");
	}
}

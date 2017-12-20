using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Result : MonoBehaviour {
    public Text res;
	// Use this for initialization
	void Start () {
        res.text = "Вы продержались "+Timer._timer.ToString("F2")+" секунд";
        Timer._timer = 0;
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class goToFirstLevel : MonoBehaviour {
	// Use this for initialization
    public void changeLevel(int index)
    {
        SceneManager.LoadScene(index);
    }
}

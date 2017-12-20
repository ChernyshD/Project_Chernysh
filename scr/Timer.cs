using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

    static public float _timer;
    public Text _counter;
    

    void Update()
    {
        if (_timer < 99999.0f)
        {
            _timer += Time.deltaTime;
            _counter.text = _timer.ToString("F2");
        }
    }
}

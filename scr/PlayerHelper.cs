using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerHelper : MonoBehaviour
{
    Ray ray;
    RaycastHit hit, _hit;
    Vector3 cursor;
    bool _on=false;
    void Start()
    {
        Time.timeScale = 0;
    }
    void Update()       //следование за мышью
    {   if(Input.GetMouseButtonDown(0)&&Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out _hit) && _hit.collider.gameObject.name == "Sphere")
        {
            Cursor.visible = false;
            Time.timeScale = 1;
            _on = true;
        }
        if (_on)
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                cursor = new Vector3(hit.point.x, hit.point.y, 0);
                transform.position = cursor;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D shp)
    {
        if (shp.gameObject.tag == "Shape"||shp.gameObject.tag=="board")
        //||shp.gameObject.name=="fon"
        {
            Cursor.visible = true;
            SceneManager.LoadScene("Results");
            //Time.timeScale = 0;
            //Application.LoadLevel("MainScene");
            
        }
    }
}

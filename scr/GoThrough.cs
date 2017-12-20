using UnityEngine;
using System.Collections;

public class GoThrough : MonoBehaviour {
    GameObject[] shapes;
    // Use this for initialization
    void Start () {
        shapes = GameObject.FindGameObjectsWithTag("Shape");
        foreach (GameObject shape in shapes)
        {
            
            Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), shape.GetComponent<Collider2D>());
        }
       
    }
}

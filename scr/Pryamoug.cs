using UnityEngine;
using System.Collections;

public class Pryamoug : MonoBehaviour {
    public float boostSec = 3.0f;
    public float[] _boostForce = { 1.5f, 1.1f, 1.1f, 1.1f,1.0f};
    int _counter = 0;
    public GameObject shape1, shape2, shape3, shape4;
    const float speed = 5f;
    Vector2 _moveRightUp = new Vector2(speed, speed);
    Vector2 _moveLeftUp = new Vector2(-speed, speed);
    Vector2 _moveRightDown = new Vector2(speed, -speed);
    Vector2 _moveLeftDown = new Vector2(-speed, -speed);


    // Use this for initialization
    void Start () {
        shape1.GetComponent<Rigidbody2D>().velocity=_moveLeftUp;
        shape2.GetComponent<Rigidbody2D>().velocity = _moveRightUp;
        shape3.GetComponent<Rigidbody2D>().velocity = _moveRightDown;
        shape4.GetComponent<Rigidbody2D>().velocity = _moveLeftDown;
        InvokeRepeating("boost", boostSec, 3f);
        
    }

    void boost()
    {
        if (_counter != 4)
        {
            Vector2 napr = shape1.GetComponent<Rigidbody2D>().velocity;
            Vector2 napr2 = shape2.GetComponent<Rigidbody2D>().velocity;
            Vector2 napr3 = shape3.GetComponent<Rigidbody2D>().velocity;
            Vector2 napr4 = shape4.GetComponent<Rigidbody2D>().velocity;
            float x1 = napr.x;
            float y1= napr.y;
            float x2 = napr2.x;
            float y2 = napr2.y;
            float x3 = napr3.x;
            float y3 = napr3.y;
            float x4 = napr4.x;
            float y4 = napr4.y;
            napr.Set(x1 * _boostForce[_counter], y1 * _boostForce[_counter]);
            shape1.GetComponent<Rigidbody2D>().velocity = napr;
            napr2.Set(x2 * _boostForce[_counter], y2 * _boostForce[_counter]);
            shape2.GetComponent<Rigidbody2D>().velocity = napr2;
            napr3.Set(x3 * _boostForce[_counter], y3 * _boostForce[_counter]);
            shape3.GetComponent<Rigidbody2D>().velocity = napr3;
            napr4.Set(x4 * _boostForce[_counter], y4 * _boostForce[_counter]);
            shape4.GetComponent<Rigidbody2D>().velocity = napr4;

            _counter++;
        }
        
    }

/*	void OnCollisionEnter2D()
    {
        switch (_counter)
        {
            case 1: GetComponent<Rigidbody2D>().velocity=_moveRightUp;break;
            case 2: GetComponent<Rigidbody2D>().velocity = _moveRightDown;break;
            case 3: GetComponent<Rigidbody2D>().velocity = _moveLeftDown;break;
            case 4: GetComponent<Rigidbody2D>().velocity = _moveLeftUp; _counter = 0; speed *= 1.5f;break;
            default:
                break;
        }
    }*/
}

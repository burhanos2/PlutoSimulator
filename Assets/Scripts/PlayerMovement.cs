using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed;
    private float normalspeed;
    private bool rightUp;
    private bool leftUp;
    private bool collisionwall = false;
    // Use this for initialization
    void Start () {
        normalspeed = 50;
        speed = speed - speed * 2;
	}
	
	// Update is called once per frame
	void Update () {
    
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;


        if (Input.GetKey("left") && rightUp == false)
        {
            leftUp = true;
            var x = Input.GetAxis("Horizontal") * Time.deltaTime * normalspeed;
            transform.Translate(x, 0, 0);

            print("check");
            Vector3 temp = transform.rotation.eulerAngles;
            temp.z = 360.0f;
            transform.rotation = Quaternion.Euler(temp);

            if (collisionwall == true)
            {
                collisionwall = false;
            }

        }
        else leftUp = false;
        if (Input.GetKey("right") )
        {
            if (collisionwall == false)
            {


                rightUp = true;
                var x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
                transform.Translate(x, 0, 0);
                Vector3 temp = transform.rotation.eulerAngles;
                temp.z = 180.0f;
                transform.rotation = Quaternion.Euler(temp);

            }
        }
        else rightUp = false;
        
        if(Input.GetKey("up") && rightUp == false && leftUp == false)
        {
            var UpDown = Input.GetAxis("Vertical") * Time.deltaTime * speed;
            transform.Translate(UpDown, 0, 0);
            Vector3 temp = transform.rotation.eulerAngles;
            temp.z = 270.0f;
            transform.rotation = Quaternion.Euler(temp);

        }
        if (Input.GetKey("down") && rightUp == false && leftUp == false)
        {
            var UpDown = Input.GetAxis("Vertical") * Time.deltaTime * normalspeed;
            transform.Translate(UpDown, 0, 0);
            Vector3 temp = transform.rotation.eulerAngles;
            temp.z = 90.0f;
            transform.rotation = Quaternion.Euler(temp);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "wall")
        {
            print("test");
            collisionwall = true;
        }
        
    }

}

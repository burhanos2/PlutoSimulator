using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death_pluto : MonoBehaviour {
    Collider2D m_collider;
    int DO_IT = 1;
    public GameObject effect;
    public Quaternion rotation = Quaternion.identity;

    void Start()
    {
        m_collider = GetComponent<Collider2D>();
    }

    public void Kill_All_Children()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Destroy(transform.GetChild(i).gameObject, 0.1f);
        }
    }

    // Update is called once per frame
    void Update() {

        Vector3 pos = new Vector3(transform.position.x - 0.11f, transform.position.y + -0.1f, transform.position.z);
        rotation.eulerAngles = new Vector3(0, 0, 0);

        if (PlayerMovement.Died == true)
        {
            Kill_All_Children();
            gameObject.GetComponent<Renderer>().enabled = false;
           
            m_collider.enabled = false;

            if (DO_IT == 1 )
            {
                DO_IT -= 1;
                Instantiate(effect, pos, rotation);
                
            }


        }
	}
}

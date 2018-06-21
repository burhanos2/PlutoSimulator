using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death_pluto : MonoBehaviour {
    Collider2D m_collider;

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
    void Update () {
		if (PlayerMovement.Died == true)
        {
            Kill_All_Children();
            gameObject.GetComponent<Renderer>().enabled = false;
            m_collider.enabled = false;
        }
	}
}

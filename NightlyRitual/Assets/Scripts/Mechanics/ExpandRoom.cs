using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpandRoom : MonoBehaviour
{
    public GameObject[] otherRoom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            for (int i = 0; i < otherRoom.Length; i++)
            {
                if (otherRoom[i].transform.localScale.x < .06)
                {
                    StartCoroutine(waitToExpand());
                }
            }
        }
    }

    IEnumerator waitToExpand()
    {
        yield return new WaitForSeconds(.5f);
        for(int i = 0; i < otherRoom.Length;i++)
        {
            if(otherRoom[i].tag == "Hallway")
            {
                otherRoom[i].transform.localScale += new Vector3(0, 0, .005f);
            }
            else
            {
                otherRoom[i].transform.localScale += new Vector3(.005f, 0, .005f);
            }

        }

    }
}

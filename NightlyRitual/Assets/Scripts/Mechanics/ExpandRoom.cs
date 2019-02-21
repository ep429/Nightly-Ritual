using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExpandRoom : MonoBehaviour
{
    public GameObject otherRoom;
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
            if(otherRoom.transform.localScale.x < 10)
            {
                StartCoroutine(waitToExpand());
            }
        }
    }

    IEnumerator waitToExpand()
    {
        yield return new WaitForSeconds(.5f);
        otherRoom.transform.localScale += new Vector3(1, 0, 1);
    }
}

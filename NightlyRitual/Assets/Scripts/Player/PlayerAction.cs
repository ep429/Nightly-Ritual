using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    public CollectManager collectManager;
    public GameObject pressE;
    private bool inRange = false;
    private GameObject collectable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inRange)
        {
            Destroy(collectable.transform.parent.gameObject);
            pressE.SetActive(false);
            collectManager.currentCount += 1;
            inRange = false;
            collectable = null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collect")
        {
            inRange = true;
            collectable = other.gameObject;
            pressE.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Collect")
        {
            inRange = false;
            collectable = null;
            pressE.SetActive(false);
        }
    }
}

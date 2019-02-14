using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollectManager : MonoBehaviour
{
    public int currentCount = 0;
    public int totalCount = 4;
    public Text displayCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        displayCount.text = "Total: " + currentCount + "/" + totalCount;
        if(currentCount == totalCount)
        {
            SceneManager.LoadScene("Win");
        }
    }
}

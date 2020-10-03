using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class God : MonoBehaviour
{
    public GameObject clearText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(BlockDestroy.blockNum);
        if (BlockDestroy.blockNum <= 0)
        {
            print("CLEAR");
            clearText.SetActive(true);
        }
    }
}

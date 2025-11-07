using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class score : MonoBehaviour
{

    public TextMeshProUGUI seaweed;
    public int Rock = 0;
    // Start is called before the first frame update

    void Start()
    {



    }
    void Update()
    {

    }

    public void UpdateScore()
    {
        seaweed.text = "" + Rock.ToString();
        Rock += 1;
    }
   



}

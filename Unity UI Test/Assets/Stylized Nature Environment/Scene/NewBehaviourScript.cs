using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject One;
    public GameObject Two;

    public void LoadScene()
    {
        if (One.activeInHierarchy == true)
        {
            One.SetActive(false);
            Two.SetActive(true);
        }
        else
        {
            One.SetActive(true);
            Two.SetActive(false);
        }
    }
}

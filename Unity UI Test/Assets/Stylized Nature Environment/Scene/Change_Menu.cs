using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Menu : MonoBehaviour
{
    public GameObject to;
    public GameObject from;

    public void LoadScene()
    {
        from.SetActive(false);
        to.SetActive(true);
    }
}

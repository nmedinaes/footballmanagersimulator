using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showOrHidde : MonoBehaviour
{
    public GameObject menuNumberOne;
    public GameObject menuNumberTwo;

    public void show()
    {
        menuNumberOne.SetActive(false);
        menuNumberTwo.SetActive(true);
    }

    public void hidde()
    {
        menuNumberOne.SetActive(true);
        menuNumberTwo.SetActive(false);
    }
}

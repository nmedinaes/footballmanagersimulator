using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showLoadProfile : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject loadProfileMenu;

    public void show()
    {
        mainMenu.SetActive(false);
        loadProfileMenu.SetActive(true);
    }

    public void hidde()
    {
        mainMenu.SetActive(true);
        loadProfileMenu.SetActive(false);
    }
}

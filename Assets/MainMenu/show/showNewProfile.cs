using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showNewProfile : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject newProfileMenu;

    public void show()
    {
        mainMenu.SetActive(false);
        newProfileMenu.SetActive(true);
    }

    public void hidde()
    {
        mainMenu.SetActive(true);
        newProfileMenu.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showOptions : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject optionsMenu;

    public void show()
    {
        mainMenu.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void hidde()
    {
        mainMenu.SetActive(true);
        optionsMenu.SetActive(false);
    }
}

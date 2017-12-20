using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    GameObject menuPanel;

    void Start()
    {
        menuPanel = GameObject.Find("MenuPanel");
    }

    public void ToggleMenuPanel()
    {
        if (menuPanel.activeInHierarchy)
            menuPanel.SetActive(false);
        else menuPanel.SetActive(true);
    }
}



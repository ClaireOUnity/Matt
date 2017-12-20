using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    void Start()
    {

    }
    private void Update()
    {
        foreach (Transform child in this.transform)
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                child.gameObject.SetActive(false);
            }
            else if (Input.GetKey(KeyCode.M))
            {
                child.gameObject.SetActive(true);
            }
        }
    }
    
    public void QuitApplication()
    {
        GameObject thingy = new GameObject();
        //Application.Quit();
    }
    public void ResetScene()
    {
        Application.LoadLevel("Map1");
    }
}



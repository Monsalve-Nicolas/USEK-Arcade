using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Boton : MonoBehaviour
{
    public void Inicio()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            SceneManager.LoadScene("GME1_level1");
        }
    }
    public void Menu()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            SceneManager.LoadScene("GME1_menu");
        } 
    }
}

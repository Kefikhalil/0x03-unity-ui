using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    // goal material

    public Material goalMat;
   
    // trap material
    public Material trapMat;
   
    // color blind option
    public Toggle colorblindMode;

    void Start()
    {
        
    }

    public void PlayMaze()
    {

        if (colorblindMode.isOn == true)
        {
            trapMat.color = new Color32(255, 112, 0, 1);
            goalMat.color = Color.blue;
        }
        else
        {
            trapMat.color = new Color32(255, 0, 0, 0);
            goalMat.color = new Color32(0, 255, 0, 1);
        }
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitMaze()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Scene : MonoBehaviour
{
    
    

    public void Load(string sceneName)
    {
        SceneManager.LoadScene(sceneName);    
    }



}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneTrans1 : MonoBehaviour
{

    public void SceneTrans1_1()
    {
        SceneManager.LoadScene("Scene1-1");
    }

    public void SceneTrans1_2()
    {
        SceneManager.LoadScene("Scene1-2");
    }
}
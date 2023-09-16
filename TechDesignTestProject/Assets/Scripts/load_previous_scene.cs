using UnityEngine;
using UnityEngine.SceneManagement;

public class load_previous_scene : MonoBehaviour
{
    public void LoadPreviousScene()
    {
        SceneManager.LoadScene("first_scene");
    }
}


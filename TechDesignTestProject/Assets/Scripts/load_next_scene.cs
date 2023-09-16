using UnityEngine;
using UnityEngine.SceneManagement;

public class load_next_scene : MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene("second_scene");
    }
}


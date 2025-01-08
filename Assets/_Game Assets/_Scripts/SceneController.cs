using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    private string levelToLoadName;

    public void LoadScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(levelToLoadName);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LoadScene();
        }
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class pin1city : MonoBehaviour
{

    private void OnMouseDown()
    {
        SceneManager.LoadScene("cityViewScene");
    }
}
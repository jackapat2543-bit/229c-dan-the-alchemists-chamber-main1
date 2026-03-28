using UnityEngine;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour
{
    public void start_game()
    {
        SceneManager.LoadScene(0);
    }
    public void test_game()
    {
        SceneManager.LoadScene(1);
    }
    public void Credit_game()
    {
        SceneManager.LoadScene(2);
    }
}
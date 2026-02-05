using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public GameObject menu;

    public void PlayGame()
    {
        menu.SetActive(false);
    }
}
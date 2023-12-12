using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject deadPanel;
    public GameObject player;

    void OnDestroy()
    {
        if (player == null)
        {
            deadPanel.SetActive(true);
        }
    }
}
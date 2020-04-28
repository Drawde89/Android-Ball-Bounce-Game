using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    public GameObject gameStartUI;
    // Start is called before the first frame update
    
    public void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    public void GameStart()
    {
        gameStartUI.SetActive(false);
        Ball.instance.gameStarted = true;

    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }
}

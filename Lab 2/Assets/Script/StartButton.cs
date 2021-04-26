using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    private Button button;
    private GameManage gameManage;

    public int startGame;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        gameManage = GameObject.Find("Game Manager").GetComponent<GameManage>();

        button.onClick.AddListener(StartGame);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void StartGame()
    {
        Debug.Log(button.gameObject.name + "was clicked");
        gameManage.startGame(startGame);
    }
}

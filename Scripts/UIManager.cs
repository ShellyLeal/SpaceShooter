using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;

    static UIManager Instance;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = Game.GetScore().ToString();

    }
}

using UnityEngine;
using UnityEngine.UI;

public class Combo : MonoBehaviour
{
    Sprite[] spawningArrows;
    Image arrows;
    bool combination = false;
    Player playerScript;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerScript = gameObject.GetComponent<Player>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerScript.playerSpeed = 0;

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Clicking : MonoBehaviour
{
    public Button Startplay;
    public Button Instruction;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Load()
    {
        SceneManager.LoadScene(1);
    }

    public void instruction()
    {
        SceneManager.LoadScene(2);
    }
}

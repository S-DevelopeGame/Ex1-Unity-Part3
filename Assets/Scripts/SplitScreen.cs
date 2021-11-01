using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplitScreen : MonoBehaviour
{
    [SerializeField] private Camera camera1, camera2;
    public Button mybutton;
    private bool isHorizontal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetSplitScreen()
    {
        camera1.rect = new Rect(0f, 0.5f, 10f, 5f);
        camera2.rect = new Rect(0f, 0f, 10f, 0.5f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    public Button Btn;
    bool ClickButton = true;
    // Start is called before the first frame update
    void Start()
    {
        Btn = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }




   public void ButtonOnClick()
    {
        if (ClickButton == true)
        {
            
            SceneManager.LoadScene("SampleScene");
        }
    }


}

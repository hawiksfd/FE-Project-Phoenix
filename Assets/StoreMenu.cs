using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoreMenu : MonoBehaviour
{

  public GameObject rubyPanel;
  public GameObject diamondPanel;

    // Start is called before the first frame update
    void Start()
    {
      
      rubyPanel.SetActive(false);
      diamondPanel.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void backMainMenu(string sceneName){
      SceneManager.LoadScene(sceneName);
    }

    public void rubyPanelButton() {
      diamondPanel.SetActive(false);
      rubyPanel.SetActive(true);
    }

    public void diamondPanelButton() {
      rubyPanel.SetActive(false);
      diamondPanel.SetActive(true);
    }


}

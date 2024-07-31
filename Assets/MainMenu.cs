using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Runtime.CompilerServices;

public class MainMenu : MonoBehaviour
{
  public GameObject convRubyPanel;
  public GameObject convEnergyPanel;
  public GameObject mainMenuPanel;
  public GameObject tavernPanel; 
  public GameObject visibleCharPanel;
  public GameObject skinPanel;
  public GameObject leftPanel;
  public GameObject left2Panel;
  public GameObject left3Panel;


    // Start is called before the first frame update
    void Start()
    {
      mainMenuPanel.SetActive(true);
      convRubyPanel.SetActive(false);
      convEnergyPanel.SetActive(false);
      visibleCharPanel.SetActive(false);
      skinPanel.SetActive(false);
      leftPanel.SetActive(false);
      left2Panel.SetActive(false);
      left3Panel.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playButton(string input){
      SceneManager.LoadScene("Play");
    }

    public void partyButton(string input){
      SceneManager.LoadScene("PartyMenu");
    }

    public void tavernButton(string input){
      SceneManager.LoadScene("TavernMenu");
    }

    
    public void storeButton(string input){
      SceneManager.LoadScene("StoreMenu");
    }

    public void recruitButton(string input){
      SceneManager.LoadScene("RecruitMenu");
    }

    public void inventButton(string input){
      SceneManager.LoadScene("InventMenu");
    }

    public void albumButton(string input){
      SceneManager.LoadScene("AlbumMenu");
    }


    public void closeMainMenu(){
      mainMenuPanel.SetActive(false);
      convRubyPanel.SetActive(false);
      convEnergyPanel.SetActive(false);
    }

    public void tuRubyButton(){
      if (!convRubyPanel.active){
          convRubyPanel.SetActive(true);
      }
      else{
          convRubyPanel.SetActive(false);
      }
    }

    public void convEnergyButton(){
      if (!convEnergyPanel.active){
          convEnergyPanel.SetActive(true);
      }
      else{
          convEnergyPanel.SetActive(false);
      }
    }

    public void visibleButton() {
      if (visibleCharPanel.active){
          mainMenuPanel.SetActive(true);
          visibleCharPanel.SetActive(false);
      }
      else{
          closeMainMenu();
          visibleCharPanel.SetActive(true);
      }
    }

    
    public void leftButton(){
      closeMainMenu();
      leftPanel.SetActive(true);
    }

    public void backBtnLeft(){
      mainMenuPanel.SetActive(true);
      leftPanel.SetActive(false);
    }

    
    public void left2Button(){
      closeMainMenu();
      left2Panel.SetActive(true);
    }

    public void backBtnLeft2(){
      mainMenuPanel.SetActive(true);
      left2Panel.SetActive(false);
    }

    public void left3Button(){
      closeMainMenu();
      left3Panel.SetActive(true);
    }

    public void backBtnLeft3(){
      mainMenuPanel.SetActive(true);
      left3Panel.SetActive(false);
    }

    public void skinButton(){
      closeMainMenu();
      skinPanel.SetActive(true);
    }

    public void backBtnSkin(){
      mainMenuPanel.SetActive(true);
      skinPanel.SetActive(false);
    }

    
}

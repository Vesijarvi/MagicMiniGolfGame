using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.Cameras;

public class UI_Script: MonoBehaviour {

	public Text BallNumText;
	public int BallNum;
    int BallNum_orig;
	public static UI_Script Instance;
    public GameObject Ball;
    public GameObject Logo;
	public GameObject PlayButton;
	public GameObject QuitButton;
	public GameObject GameOver;
    public GameObject camera;    
    public Text YouWin;
	public bool isPlaying = false;
    public FreeLookCam freelookkam;    
    
    



    //use this for init
    void Start() {
		Logo.SetActive (true);
		PlayButton.SetActive (true);
		QuitButton.SetActive (true);
		GameOver.SetActive (false);		
		Instance = this;
		YouWin.enabled = false;
        BallNum_orig = BallNum;
        BallNumText.text = "Ball Left: " + BallNum;
    }
	public void GameStart(){
		isPlaying = true;
		Logo.SetActive (false);
		PlayButton.SetActive (false);        
		QuitButton.SetActive (false);
        Ball.active = true;
        GameOver.SetActive(false);
        FreeLookCam.enablefreelook = true;
        if (BallNum <= 0) BallNum = BallNum_orig;
        BallNumText.text = "Ball Left: " + BallNum;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && BallNum>0)
        {
            if (isPlaying)
            {
                isPlaying = false;
                Logo.SetActive(true);
                PlayButton.SetActive(true);
                QuitButton.SetActive(true);
                FreeLookCam.enablefreelook = false;

            } else
            {
                isPlaying = true;
                Logo.SetActive(false);
                PlayButton.SetActive(false);
                QuitButton.SetActive(false);                
                FreeLookCam.enablefreelook = true;
            }

        }
    }

    public void GameOverMenu(){
		GameOver.SetActive (true);
	}
	public void Winning(){
		YouWin.enabled = true;
	}
	public void QuitGame(){
		Application.Quit ();
	}

	public void MinusBall(){
        if (BallNum < 1)
        {
            FreeLookCam.enablefreelook = false;
            BallNum = 0;
            isPlaying = false;
            Logo.SetActive(false);
            PlayButton.SetActive(true);
            QuitButton.SetActive(true);
            GameOver.SetActive(true);
            YouWin.enabled = false;
            BallNumText.text = "Ball Left: " + BallNum;
            //QuitGame ();
        }
        else
        {
            BallNum--;
            BallNumText.text = "Ball Left: " + BallNum;
        }
        
    }
}

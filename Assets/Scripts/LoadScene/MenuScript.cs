using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public string sceneToLoad;
    private SoundManager soundManager;
    // Start is called before the first frame update
    void Start()
    {
        soundManager = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
        soundManager.PlayMusic(soundManager.musicClip1);
    }

    public void Salir()
    {
        Application.Quit();
    }
    void Update()
    {
       
    }

    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    public void BorraRecord()
    {
        PlayerPrefs.DeleteKey("record");
    }
    public void OtraGame(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }
}

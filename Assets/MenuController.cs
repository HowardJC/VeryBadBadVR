
using UnityEngine;
using Valve.VR;


public class MenuController : MonoBehaviour
{
    public SteamVR_LoadLevel _levelLoader;

    // Start is called before the first frame update
    public void StartGame()
    {
        Debug.Log("Starting Game");
        _levelLoader.levelName = "main_scene";
        _levelLoader.fadeOutTime = 1f;
        _levelLoader.Trigger();
    }

    // Update is called once per frame
    public void ExitGame()
    {
        Debug.Log("Exiting Game");
        SteamVR_Fade.Start(Color.black, 2);
    }
}

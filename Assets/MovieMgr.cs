using UnityEngine;
using System.Collections;

public class MovieMgr : MonoBehaviour {

    private string movie = "GangnamStyle.mp4";
    //public int sceneNumber;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(streamVideo(movie));
    }

    private IEnumerator streamVideo(string video)
    {
        Handheld.PlayFullScreenMovie(video, Color.black, FullScreenMovieControlMode.Full, FullScreenMovieScalingMode.AspectFill);
        yield return new WaitForEndOfFrame();
        Debug.Log("The Video playback is now completed.");
        //Application.loadedLevel
        //SceneManager.LoadScene(sceneNumber);
    }
}

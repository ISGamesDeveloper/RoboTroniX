using UnityEngine;
using System.Collections;

///Developed by Indie Studio
///https://www.assetstore.unity3d.com/en/#!/publisher/9268
///www.indiestd.com
///info@indiestd.com

public class MobileMoviePlayer : MonoBehaviour
{
		public string movieFileName;
		public Color backgroundColor = Color.black;

		#if UNITY_ANDROID || UNITY_IPHONE
		public FullScreenMovieControlMode controlMod = FullScreenMovieControlMode.Hidden;
		public FullScreenMovieScalingMode scalingMod = FullScreenMovieScalingMode.Fill;
#endif

    void Start()
    {
#if UNITY_ANDROID || UNITY_IPHONE
        Handheld.PlayFullScreenMovie(movieFileName, backgroundColor, controlMod, scalingMod);
#endif
        StartCoroutine(UPD());
    }
    IEnumerator UPD()
    {
        yield return new WaitForSeconds(0.5f);
        Application.LoadLevel("Menu");
    }

}
using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour 
{

	public void OpenGame()
	{
		#if !UNITY_EDITOR
		openWindow("https://christopherv21.github.io/challenge5/");
		#endif
	}

	public void OpenRepository()
	{
		#if !UNITY_EDITOR
		openWindow("https://christopherv22.github.io/challenge5/");
		#endif
	}

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

}
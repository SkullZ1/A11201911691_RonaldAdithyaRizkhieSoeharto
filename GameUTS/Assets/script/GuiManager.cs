using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuiManager : MonoBehaviour {



	public void Onplay()
	{
		SceneManager.LoadScene("gameplay");
	}
	
	public void OnPanduan()
	{
		SceneManager.LoadScene("panduan");
	}
	public void OnTentang()
	{
		SceneManager.LoadScene("tentang");
	}
	public void OnKeluar()
	{
		SceneManager.LoadScene("menu");
	}
	
	
}

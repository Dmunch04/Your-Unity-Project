using UnityEngine;
using System.Collections;

public class link : MonoBehaviour {

	public void facebook(){
        Application.OpenURL ("https://www.facebook.com/VentlusaGames/");
	}
	public void twitter(){
        Application.OpenURL("https://twitter.com/VentlusaGames");
	}
	public void instagram(){
		Application.OpenURL ("https://www.instagram.com");
	}

  public void Wesite(){
		Application.OpenURL ("https://www.wix.com");
}
	public void Email(){
		Application.OpenURL ("mailto:ryan.godbold@gmail.com");

}

	public void Discord(){
		Application.OpenURL ("https://discordapp.com");

}
}




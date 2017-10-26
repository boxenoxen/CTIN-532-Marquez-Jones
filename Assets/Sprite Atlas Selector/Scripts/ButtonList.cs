using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;	//required when using Unity UI

public class ButtonList : MonoBehaviour 
{

// VARIABLES=====================================================================

	[SerializeField]
	private Text myText;

    // Set via script in start, not editor.
	private SpriteAtlasSelector ButtonControl;

	private string myTextString;
    
    // Int variable to store 'ID'.
    private int mySpriteID;

// VOID START====================================================================  

	// Get and store reference to SpriteAtlasSelector script.
    private void Start()
    {
        //ButtonControl = GameObject.Find("SPRITE ATLAS SELECTOR").GetComponent<SpriteAtlasSelector>();
		ButtonControl = GameObject.FindGameObjectWithTag("Sprite Atlas").GetComponent<SpriteAtlasSelector>();
    }
		

// VOID SET TEXT====================================================================
    
	// Receives an additional parameter, an int, stores to myID.
	public void SetText (string textString, int myID)
	{
		myTextString = textString;

		myText.text = textString;

        // Set mySpriteID to myID.
        mySpriteID = myID;

        // When button is created, add a new Listener, point it to the 'OnClick' function below.
        // This is the same as setting the OnClick in the editor, it's just doing it via script.
        GetComponent<Button>().onClick.AddListener(OnClick);
	}
    
    
// VOID ON CLICK====================================================================

	public void OnClick()
	{
		ButtonControl.ButtonClicked (myTextString, mySpriteID);
	}

}

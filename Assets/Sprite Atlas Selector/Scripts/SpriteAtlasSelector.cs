using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.U2D; // required when using atlases
using UnityEngine.UI;	//required when using Unity UI


public class SpriteAtlasSelector : MonoBehaviour
{

// VARIABLES=====================================================================

	[SerializeField]					//Serialized field allows us to access private variables in the editor
	private List<Sprite> spriteList;	// List<TypeofList> NameOfList

	[SerializeField] 
	private SpriteAtlas atlas;

	[SerializeField] 
	private SpriteRenderer SpriteAtlasRender;

	//BUTTON ARRAY----------------------------------------------------------
	[SerializeField]
	private GameObject buttonTemplate;

	//UI TEXT FIELD---------------------------------------------------------
	[SerializeField]
	public Text spriteName;





// VOID AWAKE================================================================
	void Awake()
	{
		var spritesInAtlas = new Sprite[atlas.spriteCount];

		atlas.GetSprites (spritesInAtlas);

		spriteList = spritesInAtlas.ToList ();
	}


// VOID START================================================================
	void Start () 
	{
		//SPRITE RENDERER----------------------------------------------------
		SpriteAtlasRender.sprite = spriteList.First ();		//Renders the first sprite in the atlas (one in bottom left corner)
		Debug.Log (spriteList.Count + " sprites in " + atlas);

        // Temp int to store a reference to pass to SetText.
        // Starts with 0 to stay in-line with the spriteList List.
        int tempSpriteID = 0;

        //BUTTON INSTANTIATE using FOR LOOP-------------------------------------------------
        for (int i = 1; i <= atlas.spriteCount; i++)		//Creates buttons based on how many sprites are in the atlas
		{
            //Replace the words (Clone) with empty space for a neater naming convention
            SpriteAtlasRender.sprite.name = SpriteAtlasRender.sprite.name.Replace("(Clone)", "");

            //cloning the button prefab
            GameObject button = Instantiate (buttonTemplate) as GameObject;

			//Sets the buttons to active when instantiated
			button.SetActive (true);

            //Pass an aditional parameter to SetText, the tempSpriteID.
            //Check the ButtonList script to see what this is doing.
			//Naming the instantiated buttons in relation to the generated sprite list
			button.GetComponent<ButtonList>().SetText(SpriteAtlasRender.sprite.name, tempSpriteID); 

			button.transform.SetParent (buttonTemplate.transform.parent, false);

            // Select the next sprite, to ensure it's updated for the next iteration of the FOR loop.
            SelectSpriteNext();

            // Increment the tempSpriteID int.
            tempSpriteID++;
		
		}
	}


//VOID UPDATE=======================================================================
	void Update()
	{
		SpiteTextName ();	//Calls the method below to alow text ot change to current sprite name
	}


// SPRITE PREVIOUS BUTTON============================================================
	public void SelectSpritePrevious()
	{
		SpriteAtlasRender.sprite = spriteList.SpriteIndexPrevious (SpriteAtlasRender.sprite);
		Debug.Log ("Previous Sprite : " + SpriteAtlasRender.sprite.name);
	}


// SPRITE NEXT BUTTON================================================================
	public void SelectSpriteNext() 
	{
		SpriteAtlasRender.sprite = spriteList.SpriteIndexNext (SpriteAtlasRender.sprite);
		Debug.Log ("Next Sprite : " + SpriteAtlasRender.sprite.name);
	}
		

// VOID BUTTON CLICKED====================================================================
	public void ButtonClicked (string myTextString, int spriteID)
	{
        Debug.Log (myTextString);

        // The spriteID variable is passed back from the button, it should line up with the sprite's element in the spriteList array.
        // Update the SpriteAtlas using spriteID.
        SpriteAtlasRender.sprite = spriteList[spriteID];
	}


// VOID SPRITE TEXT NAME====================================================================
	public void SpiteTextName()
	{
		if (spriteName != null) //if the Text GameObject is assigned
		{
			//Sets the text GameObject to show the name of the sprite
			spriteName.text = SpriteAtlasRender.sprite.name;
		} 

		else 	//otherwise this will warn dveleoper to insert it.
		{
			Debug.Log ("Please insert a text GameObject here");
		}

	}
		
}

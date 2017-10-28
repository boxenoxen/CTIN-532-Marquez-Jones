using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D; // required when using atlases



// ATLAS CLASS===================================================================
public class SpriteAtlasEditor : MonoBehaviour
{

// VARIABLES=====================================================================

	//Listing of all our sprites in our atlas
	enum SpriteNames { Elephant, Giraffe, Hippo, Panda, Parrot};

	[SerializeField] // Serialized field allows us to access private variables in the editor
	private SpriteAtlas atlas;

	private SpriteRenderer SpriteAtlasRender;

	[SerializeField] // Serialized field allows us to access private variables in the editor
	private SpriteNames selectedSprite;

	private SpriteNames lastSprite;


// VOID START================================================================
	void Start () 
	{
		SpriteAtlasRender = GetComponent<SpriteRenderer>();
	
		lastSprite = SpriteNames.Parrot;
	}

// VOID UPDATE================================================================
	void Update () 
	{
		SpriteSelect();
	}

// SPRITE SELECTOR================================================================
	public void SpriteSelect()
	{
		if (selectedSprite != lastSprite || selectedSprite == lastSprite)
		{
			SpriteAtlasRender.sprite = atlas.GetSprite(selectedSprite.ToString()); // accesses the sprites under the atlas and changes it to a string in the editor

			lastSprite = selectedSprite;
		}
	}
}

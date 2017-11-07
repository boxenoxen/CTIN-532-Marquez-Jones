using UnityEngine;
using System.Collections;

/* Simple Physics Toolkit - Water
 * Description: Water applies force in upward direction (based on attached object) to all rigidbodies
 * 				I suggest setting the top edge of the collider slightly lower than water model
 * Required Components: Box Collider - If not attached, one will be attached. 
 * 						This script will also remove all other types of colliders
 * Author: Dylan Anthony Auty
 * Version: 1.0
 * Last Change: 2016-01-16
*/
public class Water : MonoBehaviour {

	public float pressure = 3.0f;
	public float waterDrag = 1.0f;
	public Vector3 size = new Vector3(1.0f,1.0f,1.0f);

	public bool onlyAffectInteractableItems = false;

	void Start(){
		pressure = pressure / 10.0f;
		//Pre-Check for any other collider types
		if (GetComponent<SphereCollider> ()) {
			Destroy(GetComponent<SphereCollider>());
		} else if (GetComponent<CapsuleCollider> ()) {
			Destroy(GetComponent<CapsuleCollider>());
		} else if (GetComponent<WheelCollider> ()) {
			Destroy(GetComponent<WheelCollider>());
		}

		//Handles setting up the trigger correctly
		BoxCollider2D col = null;
		if(GetComponent<BoxCollider2D>()){
			col = GetComponent<BoxCollider2D>();
		}
		else{ //Add box Collider
			gameObject.AddComponent<BoxCollider2D>();
			col = GetComponent<BoxCollider2D>();
		}

		if(col != null){
			col.isTrigger = true; //Force trigger
			//col.size = new Vector3 (1.0f, 0.7f, 1.0f);
		}
	}

	void OnTriggerStay2D(Collider2D other){ 
		if(other.GetComponent<Rigidbody2D>()){ 
			if (onlyAffectInteractableItems) {
				if (other.GetComponent<InteractableItem> ()) {
					other.GetComponent<Rigidbody> ().AddForce (pressure * transform.up, ForceMode.Impulse);
					other.GetComponent<Rigidbody> ().drag = waterDrag;
					other.GetComponent<Rigidbody> ().angularDrag = 2.0f;
				}
			} else {
				Rigidbody2D tempRigidBody2D = other.GetComponent<Rigidbody2D>();
				tempRigidBody2D.AddForce (pressure * Vector2.up, ForceMode2D.Impulse);
				tempRigidBody2D.drag = waterDrag;
				tempRigidBody2D.angularDrag = 2.0f;
				tempRigidBody2D.gravityScale = 0.1f;

			}
		}
		
	}

	//Note: Reset values can be altered as preferred - values based on Unity defaults
	void OnTriggerExit2D(Collider2D other){
		if(other.GetComponent<Rigidbody2D>()){
			if (onlyAffectInteractableItems) {
				if (other.GetComponent<InteractableItem> ()) {
					other.GetComponent<Rigidbody>().drag = 0.0f; //Reset Drag to zero
					other.GetComponent<Rigidbody>().angularDrag = 0.05f; //Reset to default 0.05
				}
			} else {
				Rigidbody2D tempRigidBody2D = other.GetComponent<Rigidbody2D> ();
				tempRigidBody2D.drag = 0.0f; //Reset Drag to zero
				tempRigidBody2D.angularDrag = 0.05f; //Reset to default 0.05
				tempRigidBody2D.gravityScale = 1.1f;
			}
		}
	}

	void OnDrawGizmos(){
		Gizmos.color = Color.blue;
		Gizmos.DrawWireCube(transform.position, size);
	}
}
